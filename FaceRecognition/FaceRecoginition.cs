using Emgu.CV.Face;
using Emgu.CV.Structure;
using Emgu.CV;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Emgu.CV.CvEnum;
using System.Diagnostics;
using Emgu.CV.Util;
using System.Xml.Linq;
using Microsoft.Data.Sqlite;
using System.Data.Common;
using System.IO;
using FaceRecognition.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Net.Mail;
using System.Net;
using DirectShowLib;
using System.Text.RegularExpressions;

namespace FaceRecognition
{
    public partial class FaceRecoginition : Form
    {
        private readonly ClassAttendanceContext _context;
        #region Variables
        public bool qualityCheck = false;
        public double totalImage = 0;
        public double correctScore = 0;
        public double unknownScore = 0;
        public double falseScore = 0;
        public bool streamVideo = false;
        public DsDevice[] devices;
        bool faceDetectEnable = false;
        bool savePerson = false;
        bool isTrained = false;
        bool isRecognition = false;

        List<Image<Gray, Byte>> TrainedFaces = new List<Image<Gray, byte>>();
        List<int> TrainedLabels = new List<int>();
        SortedList<int, string> listLabel = new SortedList<int, string>();
        private EigenFaceRecognizer recognizer { set; get; }
        #endregion
        VideoCapture capture ;
        List<AttendanceItem> attendanceItems = new List<AttendanceItem>();
        CascadeClassifier faceCascadeClassifier = new CascadeClassifier(Directory.GetCurrentDirectory() + "/haarcascade_frontalface_alt.xml");

        public FaceRecoginition(ClassAttendanceContext context)
        {
            InitializeComponent();
            if (File.Exists("recognizer.xml"))
            {
                recognizer = new EigenFaceRecognizer();
                recognizer.Read("recognizer.xml");
            }
            _context = context;
        }
        private void FaceRecoginition_Load(object sender, EventArgs e)
        {
            // Get available video devices
            devices = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            foreach (DsDevice device in devices)
            {
                cboDevices.Items.Add(device.Name);
            }

            if (devices.Length > 0)
            {
                cboDevices.SelectedIndex = 0; // Select the first device by default
            }
            else
            {
                MessageBox.Show("No video devices found.");
            }
        }
        //SAVE IMAGE POCESS
        public async Task SaveImageProcessAsync()
        {
            if (idTrainTextBox.Text != "" && nameTrainTextBox != null)
            {
                int i = 0;
                Mat frame = new Mat();
                capture.Retrieve(frame);
                var faces = DetectFaces(frame);
                string path = Directory.GetCurrentDirectory() + @"\TrainedImages\" + idTrainTextBox.Text;
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                if (faces.Length == 1)
                {
                    var face = faces[0];
                    Task.Run(() =>
                    {
                        Image<Bgr, Byte> resultImage = frame.ToImage<Bgr, Byte>();
                        resultImage.ROI = face;

                        try
                        {
                            string filePath = Path.Combine(path, DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss-fff") + ".jpg");
                            resultImage.Resize(100, 100, Inter.Cubic).Save(filePath);
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex);
                        }
                    });

                }
            }
            else
            {

            }


        }

        //TRAIN IMAGE IN DATASET
        private Task TrainImageFromDir()
        {
            //RESET DATABASE AND RECOGINIZER
            var allStudent = _context.Students.ToList();
            _context.Students.RemoveRange(allStudent);
            var allLabel = _context.LabelStudents.ToList();
            _context.LabelStudents.RemoveRange(allLabel);
            _context.SaveChanges();
            recognizer.Dispose();

            //INIT 
            int trainLabel = 0;
            int loop = 0;
            double Threshold = 5500;
            TrainedFaces.Clear();
            TrainedLabels.Clear();
            try
            {
                UpdateTrainProcessTextBox("Training ...");
                string path = Path.Combine(Directory.GetCurrentDirectory(), "TrainedImages");
                Debug.WriteLine($"{path}");
                string[] parentDirectories = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);
                string? label = null;
                foreach (var parentDirectory in parentDirectories)
                {
                    // Lấy tên của thư mục cha
                    string parentFolderName = Path.GetFileName(parentDirectory);
                    Debug.WriteLine($"Parent folder: {parentFolderName}");
                    label = parentFolderName;

                    var newLabel = new LabelStudent()
                    {
                        StudentId = parentFolderName,
                        LabelName = trainLabel
                    };
                    _context.LabelStudents.Add(newLabel);
                    var newStudent = new Student()
                    {
                        Name = label,
                        StudentId = label,

                    };
                    _context.Students.Add(newStudent);
                    // Lặp qua các tệp trong thư mục cha
                    string[] parentFiles = Directory.GetFiles(parentDirectory, "*.jpg", SearchOption.AllDirectories);
                    foreach (var file in parentFiles)
                    {
                        string name = Path.GetFileName(file);
                        Debug.WriteLine($"  File in parent folder: {file}");

                        Image<Gray, byte> trainedImage = new Image<Gray, byte>(file);
                        Rectangle[] faces = faceCascadeClassifier.DetectMultiScale(trainedImage, 1.1, 3, Size.Empty, Size.Empty);


                        if (faces.Length == 1)
                        {
                            trainedImage.ROI = faces[0];
                            trainedImage = trainedImage.Resize(100, 100, Inter.Cubic);
                            //Increase contrast and normalize brightness
                            CvInvoke.EqualizeHist(trainedImage, trainedImage);

                            //Add images and label to train
                            TrainedFaces.Add(trainedImage);
                            TrainedLabels.Add(trainLabel);
                            Debug.WriteLine(trainLabel + ". " + label + ". " + name);
                        }
                    }
                    listLabel.Add(trainLabel, label);
                    trainLabel++;

                }
                _context.SaveChanges();

                foreach (KeyValuePair<int, string> item in listLabel)
                {
                    Debug.WriteLine($"{item.Key} - {item.Value}");
                }

                if (TrainedFaces.Count > 0)
                {

                    recognizer = new EigenFaceRecognizer(int.MaxValue, Threshold);
                    //Convert list of image to vector of Mat
                    Image<Gray, byte>[] Faces = TrainedFaces.ToArray();
                    VectorOfMat vectorOfImages = new VectorOfMat();
                    vectorOfImages.Push(Faces);
                    Debug.WriteLine(Faces[0]);
                    Console.WriteLine(TrainedLabels);

                    //Convert list of labels to vector of Int
                    int[] labels = TrainedLabels.ToArray();
                    VectorOfInt vectorOfLabels = new VectorOfInt();
                    vectorOfLabels.Push(labels);

                    //Train all images and labels
                    Task training = new Task(() =>
                    {
                        recognizer.Train(vectorOfImages, vectorOfLabels);
                        UpdateTrainProcessTextBox("Training successfully");
                        recognizer.Write("recognizer.xml");
                    }
                    );
                    training.Start();


                }
                else
                {
                    trainProcessTextBox.Text = "No images";
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
        private async void Capture_Recognite_ImageGrabbed(object? sender, EventArgs e)
        {
            Mat frame = new Mat();
            capture.Retrieve(frame);/*
            var frameSize = new System.Drawing.Size(cameraBox.Width, cameraBox.Height);
            CvInvoke.Resize(frame, frame, frameSize);*/


            if (isRecognition == true && recognizer != null)
            {
                var faces = DetectFaces(frame);
                if (faces.Length > 0)
                {
                    foreach (var face in faces)
                    {
                        Image<Bgr, Byte> resultImage = frame.ToImage<Bgr, Byte>();
                        resultImage.ROI = face;

                        // Recognize the face 
                        Image<Gray, Byte> grayFaceResult = resultImage.Convert<Gray, Byte>().Resize(100, 100, Inter.Cubic);

                        CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                        var result = recognizer.Predict(grayFaceResult);
                        Debug.WriteLine(result.Label + ". " + result.Distance);
                        //Here results found known faces
                        if (result.Label != -1)
                        {
                            var labelEntry = _context.LabelStudents.FirstOrDefault(q => q.LabelName == result.Label);
                            if (labelEntry != null)
                            {
                                CvInvoke.PutText(frame, labelEntry.StudentId, new Point(face.X - 2, face.Y - 2),
                                FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                CvInvoke.Rectangle(frame, face, new Bgr(Color.Green).MCvScalar, 2);

                                var existItem = attendanceItems.FirstOrDefault(x => x.StudentId == labelEntry.StudentId);
                                if (existItem == null)
                                {
                                    var student = _context.Students.FirstOrDefault(q => q.StudentId == labelEntry.StudentId);
                                    var attendanceItem = new AttendanceItem()
                                    {
                                        StudentId = student.StudentId,
                                        StudentForeignID = student.Id,
                                        Status = "Present"
                                    };
                                    attendanceItems.Add(attendanceItem);
                                    string listStudent = string.Join(Environment.NewLine, attendanceItems.Select(q => q.StudentId));
                                    UpdateListStudentTextBox(listStudent);
                                }

                                if (qualityCheck == true)
                                {
                                    if (qualityCheckTextbox.Text != labelEntry.StudentId)
                                    {
                                        falseScore++;
                                    }
                                    else
                                    {
                                        correctScore++;
                                    }
                                    UpdateQualityTextbox(correctScore.ToString(), falseScore.ToString(), unknownScore.ToString());
                                }
                            }


                        }
                        //here results did not found any know faces
                        else
                        {
                            CvInvoke.PutText(frame, "Unknown", new Point(face.X - 2, face.Y - 2),
                                FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                            CvInvoke.Rectangle(frame, face, new Bgr(Color.Red).MCvScalar, 2);
                            if (qualityCheck == true)
                            {
                                unknownScore++;
                                UpdateQualityTextbox(correctScore.ToString(), falseScore.ToString(), unknownScore.ToString());
                            }
                        }
                        totalImage++;
                        if (totalImage == 5000)
                        {
                            qualityCheck = false;
                        }

                    }
                }

            }
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
            // Now 'grayImage' contains the thresholded result using Otsu's Method
            /*var frameSize = new System.Drawing.Size(cameraBox.Width, cameraBox.Height);
            CvInvoke.Resize(frame, frame, frameSize);*/
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
        public Rectangle[] DetectFaces(Mat frame)
        {
            if (streamVideo)
            {
                Mat grayImage = new Mat();
                CvInvoke.CvtColor(frame, grayImage, ColorConversion.Bgr2Gray);
                //Enhance the image to get better result
                CvInvoke.EqualizeHist(grayImage, grayImage);

                Rectangle[] faces = faceCascadeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);
                return faces;
            }
            return Array.Empty<Rectangle>();
        }

        //EVENT HANDLER
        private void UpdateTrainProcessTextBox(string text)
        {
            if (trainProcessTextBox.InvokeRequired)
            {
                trainProcessTextBox.Invoke(new Action(() => UpdateTrainProcessTextBox(text)));
            }
            else
            {
                trainProcessTextBox.Text = text;
            }
        }

        private void UpdateListStudentTextBox(string text)
        {
            if (listStudentBox.InvokeRequired)
            {
                listStudentBox.Invoke(new Action(() => UpdateListStudentTextBox(text)));
            }
            else
            {
                listStudentBox.Text = text;
            }
        }
        private void UpdateProgressText(string text)
        {
            if (percentProgess.InvokeRequired)
            {
                percentProgess.Invoke(new Action(() => UpdateProgressText(text)));
            }
            else
            {
                Console.Write(text);
                percentProgess.Text = text;
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            selectDatePicker.MinDate = DateTime.Now;

        }
        private void closeCamera()
        {
            streamVideo = false;
            if(capture != null)
            {
                capture.Stop();
            }
        }

        private void openCameraBtn_Click(object sender, EventArgs e)
        {
            capture = new VideoCapture(cboDevices.SelectedIndex);
            streamVideo = true;
            capture.ImageGrabbed += Capture_Recognite_ImageGrabbed;
            capture.Start();
        }
        private void buttonTrainImage_Click(object sender, EventArgs e)
        {
            TrainImageFromDir();
        }
        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            closeCamera();
        }
        private void closeCameraBtn_Click(object sender, EventArgs e)
        {
            closeCamera();
        }
        private void closeTrainCamera_Click(object sender, EventArgs e)
        {
            closeCamera();
        }
        private void openTrainCamera_Click(object sender, EventArgs e)
        {
            capture = new VideoCapture(cboDevices.SelectedIndex);
            streamVideo = true;
            capture.ImageGrabbed += Capture_Train_ImageGrabbed;
            capture.Start();

        }


        private async void saveStudentImage_Click(object sender, EventArgs e)
        {
            UpdateTrainProcessTextBox("Saving images ...!");
            saveStudentImageBtn.Enabled = false;
            var existStudent = _context.Students.FirstOrDefault(q => q.StudentId == idTrainTextBox.Text);
            if (existStudent == null)
            {
                Student newStudent = new Student()
                {
                    Name = nameTrainTextBox.Text,
                    StudentId = idTrainTextBox.Text,
                    Email = emailTextBox.Text,
                };
                await _context.Students.AddAsync(newStudent);
                await _context.SaveChangesAsync();
            }

            Task saving = new Task(async () =>
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "TrainedImages");
                var oldFiles = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories).Count();
                var newFiles = 200;

                //Make sure the total files increase 100 image
                while ((Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories)).Count() < oldFiles + newFiles)
                {
                    //The loop may be skipped if the face is not detected
                    await SaveImageProcessAsync();
                    var currentFiles = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories).Count();
                    /*(((currentFiles - oldFiles) / newFiles) * 100).ToString() + " %"*/
                    var percentage = (currentFiles - oldFiles) * 100 / newFiles;
                    UpdateProgressText(percentage.ToString() + " %");
                }
                UpdateTrainProcessTextBox("Saving image successfully");
                saveStudentImageBtn.Invoke(new ThreadStart(delegate
                {
                    saveStudentImageBtn.Enabled = true;
                }));
            }
            );
            saving.Start();
        }


        private void checkAttendanceButton_Click(object sender, EventArgs e)
        {
            var attendance = new Attendance()
            {
                AttendanceDate = selectDatePicker.Value,
                Note = noteTextBox.Text,
            };
            _context.Attendances.Add(attendance);
            _context.SaveChanges();

            // Insert present student
            foreach (var item in attendanceItems)
            {
                item.AttendanceId = attendance.Id;
            }
            // Insert absent student
            var allStudents = _context.Students.ToList();
            var presentStudent = attendanceItems.Select(q => q.StudentId).ToList();
            var absentStudent = allStudents.Where(q => !presentStudent.Contains(q.StudentId)).ToList();
            foreach (var student in absentStudent)
            {
                var attendanceItem = new AttendanceItem()
                {
                    AttendanceId = attendance.Id,
                    StudentForeignID = student.Id,
                    StudentId = student.StudentId,
                    Status = "Absent"
                };
                attendanceItems.Add(attendanceItem);

            }
            _context.AttendanceItems.AddRange(attendanceItems);
            _context.SaveChanges();

            foreach (var student in absentStudent)
            {
                //SEND EMAIL TO ABSENT STUDENT
                if (student.Email != null)
                {
                    try
                    {
                        MailMessage mail = new MailMessage();
                        SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                        mail.From = new MailAddress("vuqcbao@gmail.com");
                        mail.To.Add(student.Email);
                        mail.Subject = "THÔNG BÁO ĐIỂM DANH TỪ NHÀ TRƯỜNG";
                        mail.Body = $"Sinh viên : {student.Name} - MSSV: {student.StudentId} đã vắng mặt trong buổi học ngày {attendance.AttendanceDate.ToString()}";

                        smtpServer.Port = 587;
                        smtpServer.Credentials = new NetworkCredential("vuqcbao@gmail.com", "valw kigj hfrc ajpd");
                        smtpServer.EnableSsl = true;

                        smtpServer.Send(mail);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            MessageBox.Show("Sent email to absent students successfully");
        }

        private void recognitionBtn_Click(object sender, EventArgs e)
        {
            isRecognition = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            streamVideo = true;
            capture.ImageGrabbed += Capture_Train_ImageGrabbed;
            capture.Start();

        }


        private void getAttendanceInfoBtn_Click(object sender, EventArgs e)
        {
            // Ensure your TextBox uses a monospaced font for proper alignment
            attendanceTableTextBox.Font = new Font("Courier New", 10);

            // Query data from the database
            var attendances = _context.Attendances.ToList();
            var attendanceItems = _context.AttendanceItems.ToList();

            // Get the list of unique attendance dates
            var attendanceDates = attendances.Select(a => a.AttendanceDate).Distinct().OrderBy(d => d).ToList();

            // Create the header for the table
            var header = "ATTENDANCE INFORMATION";

            // Create the column headers for the table
            var columns = "Attendance Dates:".PadRight(20);
            foreach (var date in attendanceDates)
            {
                columns += date.ToString("dd/MM/yyyy").PadRight(15);
            }

            // Create the data rows
            var rows = new List<string>();
            var studentIds = attendanceItems.Select(ai => ai.StudentId).Distinct().OrderBy(id => id).ToList();
            foreach (var studentId in studentIds)
            {
                var row = studentId.PadRight(20);
                foreach (var date in attendanceDates)
                {
                    var attendanceId = attendances.FirstOrDefault(a => a.AttendanceDate == date)?.Id ?? 0;
                    var status = attendanceItems.FirstOrDefault(ai => ai.StudentId == studentId && ai.AttendanceId == attendanceId)?.Status ?? "Absent";
                    row += status.PadRight(15);
                }
                rows.Add(row);
            }

            // Combine the header and data rows into a single string
            var result = header + Environment.NewLine + columns + Environment.NewLine + string.Join(Environment.NewLine, rows);

            // Display the result in the TextBox
            attendanceTableTextBox.Text = result;
        }

        private void checkQualityBtn_Click(object sender, EventArgs e)
        {
            qualityCheck = true;
        }

        private void UpdateQualityTextbox(string correct, string fail, string unknown)
        {
            if (qualityCorrectTextbox.InvokeRequired || qualityFailTextbox.InvokeRequired || qualityUnkTextbox.InvokeRequired)
            {
                qualityCorrectTextbox.Invoke(new Action(() => UpdateQualityTextbox(correct, fail, unknown)));
                qualityFailTextbox.Invoke(new Action(() => UpdateQualityTextbox(correct, fail, unknown)));
                qualityUnkTextbox.Invoke(new Action(() => UpdateQualityTextbox(correct, fail, unknown)));
            }
            else
            {
                qualityCorrectTextbox.Text = correct;
                qualityFailTextbox.Text = fail;
                qualityUnkTextbox.Text = unknown;
            }
        }

        
    }
}
