using Emgu.CV.Face;
using Emgu.CV.Structure;
using Emgu.CV;
using System.Linq;
using FaceRecognition.Models;
using Microsoft.EntityFrameworkCore;
using Emgu.CV.CvEnum;
using System.Diagnostics;
using Emgu.CV.Util;
using System.Xml.Linq;
using Microsoft.Data.Sqlite;
using System.Data.Common;

namespace FaceRecognition
{
    public partial class FaceRecoginition : Form
    {
        #region Variables
        public bool streamVideo = false;
        bool faceDetectEnable = false;
        bool savePerson = false;
        bool isTrained = false;
        bool isRecognition = false;
        List<Image<Gray, Byte>> TrainedFaces = new List<Image<Gray, byte>>();
        List<int> StudentLabels = new List<int>();
        List<string> StudentIds = new List<string>();
        List<Student> Students = new List<Student>();
        VideoCapture capture = new VideoCapture(0);

        EigenFaceRecognizer recognizer;
        #endregion


        private DatabaseContext _dbContext;
        public FaceRecoginition()
        {
            InitializeComponent();
        }

        //SAVE IMAGE POCESS
        private async Task SaveImagePocessAsync()
        {
            if (idTrainTextBox.Text != "" && nameTrainTextBox != null)
            {
                var student = await _dbContext.Students.SingleOrDefaultAsync(x => x.StudentId == idTrainTextBox.Text);
                if (student == null)
                {
                    _dbContext.Students.Add(new Student() { StudentId = idTrainTextBox.Text, StudentName = nameTrainTextBox.Text });
                    _dbContext.CheckDates.Add(new CheckDate() { StudentId = idTrainTextBox.Text, StudentName = nameTrainTextBox.Text });
                    _dbContext.SaveChanges();
                }

                Mat frame = new Mat();
                capture.Retrieve(frame);
                var faces = DetectFaces(frame);
                if (faces.Length == 1)
                {
                    foreach (var face in faces)
                    {
                        Image<Bgr, Byte> resultImage = frame.ToImage<Bgr, Byte>();
                        resultImage.ROI = face;

                        string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
                        if (!Directory.Exists(path))
                            Directory.CreateDirectory(path);


                        Image<Bgr, Byte> saveImagePerson = resultImage;
                        try
                        {
                            saveImagePerson.Resize(250, 250, Inter.Cubic).Save(path + @"\" + idTrainTextBox.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex);
                        }
                    }

                }
                else
                {

                }

                if (saveStudentImageBtn.InvokeRequired)
                {
                    saveStudentImageBtn.Invoke(new ThreadStart(delegate
                    {
                        saveStudentImageBtn.Enabled = true;
                    }));
                }
            }


        }

        //TRAIN IMAGE IN DATASET
        private Task TrainImageFromDir()
        {
            int ImagesCount = 0;
            double Threshold = 7000;
            TrainedFaces.Clear();
            StudentLabels.Clear();
            StudentIds.Clear();
            try
            {
                string path = Directory.GetCurrentDirectory() + @"\ImageDataset";
                string[] files = Directory.GetFiles(path, "*.jpeg", SearchOption.AllDirectories);
                Thread.Sleep(3000);

                trainPocessTextBox.Text = "wait";
                Thread.Sleep(3000);
                foreach (var file in files)
                {
                    Image<Gray, byte> trainedImage = new Image<Gray, byte>(file).Resize(250, 250, Inter.Cubic);
                    //Increase contrast and normalize brightness
                    CvInvoke.EqualizeHist(trainedImage, trainedImage);

                    //Add images and label to train
                    TrainedFaces.Add(trainedImage);
                    StudentLabels.Add(ImagesCount);
                    string name = file.Split('\\').Last().Split('_')[0];
                    StudentIds.Add(name);
                    ImagesCount++;
                    Debug.WriteLine(ImagesCount + ". " + name);

                }

                if (TrainedFaces.Count > 0)
                {
                    //Create new recognizer
                    recognizer = new EigenFaceRecognizer(ImagesCount, Threshold);

                    //Convert list of image to vector of Mat
                    Image<Gray, byte>[] Faces = TrainedFaces.ToArray();
                    VectorOfMat vectorOfMat = new VectorOfMat();
                    vectorOfMat.Push(Faces);
                    Debug.WriteLine(Faces[0]);
                    Console.WriteLine(StudentLabels);

                    //Convert list of labels to vector of Int
                    int[] labels = StudentLabels.ToArray();
                    VectorOfInt vectorOfInt = new VectorOfInt();
                    vectorOfInt.Push(labels);
                    //Train all images and labels
                    Task training = new Task(() => recognizer.Train(vectorOfMat, vectorOfInt));
                    training.Start();

                }
                else
                {
                    isTrained = false;
                }
            }
            catch (Exception ex)
            {
                isTrained = false;
                MessageBox.Show("Error in Train Images: " + ex.Message);
            }

            return Task.CompletedTask;
        }

        //CAPTURE IMAGE AND DISPLAY ON RECOGNITION PAGE
        private void Capture_Recognite_ImageGrabbed(object? sender, EventArgs e)
        {
            Mat frame = new Mat();
            capture.Retrieve(frame);
            var frameSize = new System.Drawing.Size(cameraBox.Width, cameraBox.Height);
            CvInvoke.Resize(frame, frame, frameSize);


            if (isRecognition == true)
            {
                var faces = DetectFaces(frame);
                if (faces.Length > 0)
                {
                    foreach (var face in faces)
                    {
                        Image<Bgr, Byte> resultImage = frame.ToImage<Bgr, Byte>();
                        resultImage.ROI = face;

                        // Recognize the face 
                        Image<Gray, Byte> grayFaceResult = resultImage.Convert<Gray, Byte>().Resize(250, 250, Inter.Cubic);
                        CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                        var result = recognizer.Predict(grayFaceResult);
                        var studentId = StudentIds[result.Label];
                        if (studentId != null)
                        {
                            Debug.WriteLine(result.Label + ". " + result.Distance);
                            //Here results found known faces
                            if (result.Label != -1 && result.Distance < 7000)
                            {
                                var studentResult = _dbContext.Students.FirstOrDefault(m => m.StudentId == studentId);
                                if (studentResult != null)
                                {
                                    Students.Add(studentResult);
                                    CvInvoke.PutText(frame, studentResult.StudentName, new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                    CvInvoke.Rectangle(frame, face, new Bgr(Color.Green).MCvScalar, 2);
                                }
                            }
                            //here results did not found any know faces
                            else
                            {
                                CvInvoke.PutText(frame, "Unknown", new Point(face.X - 2, face.Y - 2),
                                    FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                CvInvoke.Rectangle(frame, face, new Bgr(Color.Red).MCvScalar, 2);

                            }
                        }

                    }
                }
            }
            countedStudents.Text = Students.Count().ToString();
            cameraBox.Image = frame.ToBitmap();
            if (frame != null)
            {
                frame.Dispose();
            }

        }

        // IMAGEGRABBED OF TRAINING PAGE

        private void Capture_Train_ImageGrabbed(object? sender, EventArgs e)
        {
            Mat frame = new Mat();
            capture.Retrieve(frame);
            var frameSize = new System.Drawing.Size(cameraBox.Width, cameraBox.Height);
            CvInvoke.Resize(frame, frame, frameSize);
            var faces = DetectFaces(frame);
            if (faces.Length > 0)
            {
                foreach (var face in faces)
                {
                    Image<Bgr, Byte> resultImage = frame.ToImage<Bgr, Byte>();
                    resultImage.ROI = face;
                    faceDetectTrainBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    faceDetectTrainBox.Image = resultImage.ToBitmap();

                }
            }

            trainingCameraBox.Image = frame.ToBitmap();
            if (frame != null)
            {
                frame.Dispose();
            }
        }


        //DETECT FACE USING HAARCASCADE
        private Rectangle[] DetectFaces(Mat frame)
        {
            CascadeClassifier faceCascadeClassifier = new CascadeClassifier("Haarcascade/haarcascade_frontalface_alt.xml");
            if (streamVideo)
            {
                if (faceDetectEnable)
                {
                    Mat grayImage = new Mat();
                    CvInvoke.CvtColor(frame, grayImage, ColorConversion.Bgr2Gray);
                    //Enhance the image to get better result
                    CvInvoke.EqualizeHist(grayImage, grayImage);

                    Rectangle[] faces = faceCascadeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);
                    return faces;
                }
            }
            return Array.Empty<Rectangle>();
        }
        //EVENT HANDLER
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this._dbContext = new DatabaseContext();
            this._dbContext.Database.EnsureCreated();

        }
        private void closeCamera()
        {
            streamVideo = false;
            capture.Stop();
        }

        private void openCameraBtn_Click(object sender, EventArgs e)
        {
            streamVideo = true;
            capture.ImageGrabbed += Capture_Recognite_ImageGrabbed;
            capture.Start();
        }


        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            closeCamera();
        }
        private void closeCameraBtn_Click(object sender, EventArgs e)
        {
            //Close current camera when switch tab
            closeCamera();
        }
        private void closeTrainCamera_Click(object sender, EventArgs e)
        {
            closeCamera();
        }
        private void openTrainCamera_Click(object sender, EventArgs e)
        {
            streamVideo = true;
            capture.ImageGrabbed += Capture_Train_ImageGrabbed;
            capture.Start();
        }


        private async void saveStudentImage_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                await SaveImagePocessAsync();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
             TrainImageFromDir();
        }

        private void checkAttendanceButton_Click(object sender, EventArgs e)
        {
            Attendance attendance = new Attendance() { AttendanceDate = selectDatePicker.Value, Note = noteTextBox.Text, Attend = Students.Count() };
            _dbContext.Attendances.Add(attendance);

            // ADO .NET TO CREATE DATE COLUMNS 
            var sqlStringBuilder = new SqliteConnectionStringBuilder();
            sqlStringBuilder["filename"] = Path.Combine(Directory.GetCurrentDirectory() + "Database/database.db");

            var sqlStringConnection = sqlStringBuilder.ToString();
            using var connection = new SqliteConnection(sqlStringConnection);
            connection.Open();

            using DbCommand command = new SqliteCommand();
            command.Connection = connection;
            command.CommandText = $"alter table CheckDate add {selectDatePicker.Value} nvarchar(10)";
            command.ExecuteNonQuery();
            //... insert Attend or Absent for this column ...// 
            connection.Close();
        }
    }
}
