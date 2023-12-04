namespace FaceRecognition
{
    partial class FaceRecoginition
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaceRecoginition));
            tabMain = new TabControl();
            Recognition = new TabPage();
            groupBox2 = new GroupBox();
            cameraBox = new PictureBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            listStudentsBox = new ListBox();
            countedStudents = new TextBox();
            label5 = new Label();
            attendanceHandleGroup = new GroupBox();
            checkAttendanceButton = new Button();
            label4 = new Label();
            noteTextBox = new RichTextBox();
            label3 = new Label();
            selectDatePicker = new DateTimePicker();
            cameraHandleGroup = new GroupBox();
            recognitionBtn = new Button();
            closeCameraBtn = new Button();
            openCameraBtn = new Button();
            Training = new TabPage();
            InformationGroup = new GroupBox();
            saveStudentImageBtn = new Button();
            button4 = new Button();
            trainPocessTextBox = new TextBox();
            label9 = new Label();
            idTrainTextBox = new TextBox();
            nameTrainTextBox = new TextBox();
            label8 = new Label();
            label7 = new Label();
            groupBox4 = new GroupBox();
            closeTrainCamera = new Button();
            openTrainCamera = new Button();
            faceDetectTrainBox = new PictureBox();
            trainingCameraBox = new PictureBox();
            groupBox3 = new GroupBox();
            Attendance = new TabPage();
            label1 = new Label();
            GroupLogo = new PictureBox();
            UniversityLogo = new PictureBox();
            label2 = new Label();
            tabMain.SuspendLayout();
            Recognition.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cameraBox).BeginInit();
            groupBox1.SuspendLayout();
            attendanceHandleGroup.SuspendLayout();
            cameraHandleGroup.SuspendLayout();
            Training.SuspendLayout();
            InformationGroup.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)faceDetectTrainBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trainingCameraBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GroupLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UniversityLogo).BeginInit();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(Recognition);
            tabMain.Controls.Add(Training);
            tabMain.Controls.Add(Attendance);
            tabMain.Location = new Point(36, 131);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(1095, 595);
            tabMain.TabIndex = 0;
            tabMain.SelectedIndexChanged += tabMain_SelectedIndexChanged;
            // 
            // Recognition
            // 
            Recognition.Controls.Add(groupBox2);
            Recognition.Controls.Add(groupBox1);
            Recognition.Controls.Add(attendanceHandleGroup);
            Recognition.Controls.Add(cameraHandleGroup);
            Recognition.Location = new Point(4, 24);
            Recognition.Name = "Recognition";
            Recognition.Padding = new Padding(3);
            Recognition.Size = new Size(1087, 567);
            Recognition.TabIndex = 0;
            Recognition.Text = "Recognition";
            Recognition.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cameraBox);
            groupBox2.Location = new Point(6, 8);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(725, 550);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Camera";
            // 
            // cameraBox
            // 
            cameraBox.Location = new Point(6, 22);
            cameraBox.Name = "cameraBox";
            cameraBox.Size = new Size(713, 518);
            cameraBox.TabIndex = 0;
            cameraBox.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(listStudentsBox);
            groupBox1.Controls.Add(countedStudents);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(755, 338);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 220);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recognition Information";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 55);
            label6.Name = "label6";
            label6.Size = new Size(123, 15);
            label6.TabIndex = 5;
            label6.Text = "Students recognition :";
            // 
            // listStudentsBox
            // 
            listStudentsBox.FormattingEnabled = true;
            listStudentsBox.ItemHeight = 15;
            listStudentsBox.Location = new Point(6, 85);
            listStudentsBox.Name = "listStudentsBox";
            listStudentsBox.Size = new Size(309, 124);
            listStudentsBox.TabIndex = 4;
            // 
            // countedStudents
            // 
            countedStudents.Location = new Point(138, 26);
            countedStudents.Name = "countedStudents";
            countedStudents.Size = new Size(135, 23);
            countedStudents.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 29);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 2;
            label5.Text = "Students counted :";
            // 
            // attendanceHandleGroup
            // 
            attendanceHandleGroup.Controls.Add(checkAttendanceButton);
            attendanceHandleGroup.Controls.Add(label4);
            attendanceHandleGroup.Controls.Add(noteTextBox);
            attendanceHandleGroup.Controls.Add(label3);
            attendanceHandleGroup.Controls.Add(selectDatePicker);
            attendanceHandleGroup.Location = new Point(755, 131);
            attendanceHandleGroup.Name = "attendanceHandleGroup";
            attendanceHandleGroup.Size = new Size(321, 201);
            attendanceHandleGroup.TabIndex = 2;
            attendanceHandleGroup.TabStop = false;
            attendanceHandleGroup.Text = "Attendance Options";
            // 
            // checkAttendanceButton
            // 
            checkAttendanceButton.Location = new Point(6, 156);
            checkAttendanceButton.Name = "checkAttendanceButton";
            checkAttendanceButton.Size = new Size(298, 23);
            checkAttendanceButton.TabIndex = 4;
            checkAttendanceButton.Text = "Check Attendance";
            checkAttendanceButton.UseVisualStyleBackColor = true;
            checkAttendanceButton.Click += checkAttendanceButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 67);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Note :";
            // 
            // noteTextBox
            // 
            noteTextBox.Location = new Point(82, 64);
            noteTextBox.Name = "noteTextBox";
            noteTextBox.Size = new Size(222, 77);
            noteTextBox.TabIndex = 2;
            noteTextBox.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 41);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 1;
            label3.Text = "Select date :";
            // 
            // selectDatePicker
            // 
            selectDatePicker.Location = new Point(82, 35);
            selectDatePicker.Name = "selectDatePicker";
            selectDatePicker.Size = new Size(222, 23);
            selectDatePicker.TabIndex = 0;
            // 
            // cameraHandleGroup
            // 
            cameraHandleGroup.Controls.Add(recognitionBtn);
            cameraHandleGroup.Controls.Add(closeCameraBtn);
            cameraHandleGroup.Controls.Add(openCameraBtn);
            cameraHandleGroup.Location = new Point(755, 8);
            cameraHandleGroup.Name = "cameraHandleGroup";
            cameraHandleGroup.Size = new Size(321, 117);
            cameraHandleGroup.TabIndex = 1;
            cameraHandleGroup.TabStop = false;
            cameraHandleGroup.Text = "Camera Handler";
            // 
            // recognitionBtn
            // 
            recognitionBtn.Location = new Point(82, 80);
            recognitionBtn.Name = "recognitionBtn";
            recognitionBtn.Size = new Size(166, 23);
            recognitionBtn.TabIndex = 2;
            recognitionBtn.Text = "Recognition";
            recognitionBtn.UseVisualStyleBackColor = true;
            // 
            // closeCameraBtn
            // 
            closeCameraBtn.Location = new Point(82, 51);
            closeCameraBtn.Name = "closeCameraBtn";
            closeCameraBtn.Size = new Size(166, 23);
            closeCameraBtn.TabIndex = 1;
            closeCameraBtn.Text = "Turn off Camera";
            closeCameraBtn.UseVisualStyleBackColor = true;
            closeCameraBtn.Click += closeCameraBtn_Click;
            // 
            // openCameraBtn
            // 
            openCameraBtn.Location = new Point(82, 22);
            openCameraBtn.Name = "openCameraBtn";
            openCameraBtn.Size = new Size(166, 23);
            openCameraBtn.TabIndex = 0;
            openCameraBtn.Text = "Turn on Camera";
            openCameraBtn.UseVisualStyleBackColor = true;
            openCameraBtn.Click += openCameraBtn_Click;
            // 
            // Training
            // 
            Training.Controls.Add(InformationGroup);
            Training.Controls.Add(groupBox4);
            Training.Controls.Add(trainingCameraBox);
            Training.Controls.Add(groupBox3);
            Training.Location = new Point(4, 24);
            Training.Name = "Training";
            Training.Padding = new Padding(3);
            Training.Size = new Size(1087, 567);
            Training.TabIndex = 1;
            Training.Text = "Training";
            Training.UseVisualStyleBackColor = true;
            // 
            // InformationGroup
            // 
            InformationGroup.Controls.Add(saveStudentImageBtn);
            InformationGroup.Controls.Add(button4);
            InformationGroup.Controls.Add(trainPocessTextBox);
            InformationGroup.Controls.Add(label9);
            InformationGroup.Controls.Add(idTrainTextBox);
            InformationGroup.Controls.Add(nameTrainTextBox);
            InformationGroup.Controls.Add(label8);
            InformationGroup.Controls.Add(label7);
            InformationGroup.Location = new Point(772, 317);
            InformationGroup.Name = "InformationGroup";
            InformationGroup.Size = new Size(298, 244);
            InformationGroup.TabIndex = 3;
            InformationGroup.TabStop = false;
            InformationGroup.Text = "Information";
            // 
            // saveStudentImageBtn
            // 
            saveStudentImageBtn.Location = new Point(99, 98);
            saveStudentImageBtn.Name = "saveStudentImageBtn";
            saveStudentImageBtn.Size = new Size(175, 28);
            saveStudentImageBtn.TabIndex = 7;
            saveStudentImageBtn.Text = "Save Student Images";
            saveStudentImageBtn.UseVisualStyleBackColor = true;
            saveStudentImageBtn.Click += saveStudentImage_Click;
            // 
            // button4
            // 
            button4.Location = new Point(99, 132);
            button4.Name = "button4";
            button4.Size = new Size(175, 28);
            button4.TabIndex = 6;
            button4.Text = "Train";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // trainPocessTextBox
            // 
            trainPocessTextBox.Font = new Font("Segoe UI", 30F);
            trainPocessTextBox.Location = new Point(145, 166);
            trainPocessTextBox.Name = "trainPocessTextBox";
            trainPocessTextBox.Size = new Size(114, 61);
            trainPocessTextBox.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 187);
            label9.Name = "label9";
            label9.Size = new Size(85, 15);
            label9.TabIndex = 4;
            label9.Text = "Traning Pocess";
            // 
            // idTrainTextBox
            // 
            idTrainTextBox.Location = new Point(99, 62);
            idTrainTextBox.Name = "idTrainTextBox";
            idTrainTextBox.Size = new Size(175, 23);
            idTrainTextBox.TabIndex = 3;
            // 
            // nameTrainTextBox
            // 
            nameTrainTextBox.Location = new Point(99, 33);
            nameTrainTextBox.Name = "nameTrainTextBox";
            nameTrainTextBox.Size = new Size(175, 23);
            nameTrainTextBox.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 65);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 1;
            label8.Text = "Student ID :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 36);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 0;
            label7.Text = "Student name :";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(closeTrainCamera);
            groupBox4.Controls.Add(openTrainCamera);
            groupBox4.Controls.Add(faceDetectTrainBox);
            groupBox4.Location = new Point(772, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(298, 306);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Detect";
            // 
            // closeTrainCamera
            // 
            closeTrainCamera.Location = new Point(159, 278);
            closeTrainCamera.Name = "closeTrainCamera";
            closeTrainCamera.Size = new Size(115, 23);
            closeTrainCamera.TabIndex = 2;
            closeTrainCamera.Text = "Close Camera";
            closeTrainCamera.UseVisualStyleBackColor = true;
            closeTrainCamera.Click += closeTrainCamera_Click;
            // 
            // openTrainCamera
            // 
            openTrainCamera.Location = new Point(24, 278);
            openTrainCamera.Name = "openTrainCamera";
            openTrainCamera.Size = new Size(115, 23);
            openTrainCamera.TabIndex = 1;
            openTrainCamera.Text = "Open Camera";
            openTrainCamera.UseVisualStyleBackColor = true;
            openTrainCamera.Click += openTrainCamera_Click;
            // 
            // faceDetectTrainBox
            // 
            faceDetectTrainBox.Location = new Point(24, 22);
            faceDetectTrainBox.Name = "faceDetectTrainBox";
            faceDetectTrainBox.Size = new Size(250, 250);
            faceDetectTrainBox.TabIndex = 0;
            faceDetectTrainBox.TabStop = false;
            // 
            // trainingCameraBox
            // 
            trainingCameraBox.Location = new Point(12, 28);
            trainingCameraBox.Name = "trainingCameraBox";
            trainingCameraBox.Size = new Size(745, 527);
            trainingCameraBox.TabIndex = 1;
            trainingCameraBox.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(6, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(757, 555);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Camera";
            // 
            // Attendance
            // 
            Attendance.Location = new Point(4, 24);
            Attendance.Name = "Attendance";
            Attendance.Padding = new Padding(3);
            Attendance.Size = new Size(1087, 567);
            Attendance.TabIndex = 2;
            Attendance.Text = "Attendance";
            Attendance.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(439, 41);
            label1.Name = "label1";
            label1.Size = new Size(332, 46);
            label1.TabIndex = 1;
            label1.Text = "CLASS ATTENDANCE";
            // 
            // GroupLogo
            // 
            GroupLogo.Image = (Image)resources.GetObject("GroupLogo.Image");
            GroupLogo.InitialImage = (Image)resources.GetObject("GroupLogo.InitialImage");
            GroupLogo.Location = new Point(153, 12);
            GroupLogo.Name = "GroupLogo";
            GroupLogo.Size = new Size(100, 100);
            GroupLogo.TabIndex = 2;
            GroupLogo.TabStop = false;
            // 
            // UniversityLogo
            // 
            UniversityLogo.ErrorImage = (Image)resources.GetObject("UniversityLogo.ErrorImage");
            UniversityLogo.ImageLocation = "@\"~Data/assest/logo.png\"";
            UniversityLogo.InitialImage = (Image)resources.GetObject("UniversityLogo.InitialImage");
            UniversityLogo.Location = new Point(36, 12);
            UniversityLogo.Name = "UniversityLogo";
            UniversityLogo.Size = new Size(100, 100);
            UniversityLogo.TabIndex = 3;
            UniversityLogo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(455, 87);
            label2.Name = "label2";
            label2.Size = new Size(273, 25);
            label2.TabIndex = 4;
            label2.Text = "Facial Recoginition with Emgu CV";
            // 
            // FaceRecoginition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 738);
            Controls.Add(label2);
            Controls.Add(UniversityLogo);
            Controls.Add(GroupLogo);
            Controls.Add(label1);
            Controls.Add(tabMain);
            Name = "FaceRecoginition";
            Text = "Form1";
            tabMain.ResumeLayout(false);
            Recognition.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cameraBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            attendanceHandleGroup.ResumeLayout(false);
            attendanceHandleGroup.PerformLayout();
            cameraHandleGroup.ResumeLayout(false);
            Training.ResumeLayout(false);
            InformationGroup.ResumeLayout(false);
            InformationGroup.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)faceDetectTrainBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)trainingCameraBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)GroupLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)UniversityLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabMain;
        private TabPage Recognition;
        private TabPage Training;
        private Label label1;
        private PictureBox GroupLogo;
        private PictureBox UniversityLogo;
        private Label label2;
        private TabPage Attendance;
        private GroupBox cameraHandleGroup;
        private GroupBox attendanceHandleGroup;
        private Label label3;
        private DateTimePicker selectDatePicker;
        private Button recognitionBtn;
        private Button closeCameraBtn;
        private Button openCameraBtn;
        private GroupBox groupBox1;
        private Label label6;
        private ListBox listStudentsBox;
        private TextBox countedStudents;
        private Label label5;
        private Label label4;
        private RichTextBox noteTextBox;
        private GroupBox groupBox2;
        private PictureBox cameraBox;
        private GroupBox groupBox4;
        private PictureBox trainingCameraBox;
        private GroupBox groupBox3;
        private GroupBox InformationGroup;
        private Button closeTrainCamera;
        private Button openTrainCamera;
        private PictureBox faceDetectTrainBox;
        private Label label9;
        private TextBox idTrainTextBox;
        private TextBox nameTrainTextBox;
        private Label label8;
        private Label label7;
        private Button button4;
        private TextBox trainPocessTextBox;
        private Button checkAttendanceButton;
        private Button saveStudentImageBtn;
    }
}
