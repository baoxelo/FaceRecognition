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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaceRecoginition));
            tabMain = new TabControl();
            Recognition = new TabPage();
            groupBox6 = new GroupBox();
            cboDevices = new ComboBox();
            groupBox5 = new GroupBox();
            qualityFailTextbox = new TextBox();
            qualityUnkTextbox = new TextBox();
            qualityCorrectTextbox = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            qualityCheckTextbox = new TextBox();
            checkQualityBtn = new Button();
            groupBox2 = new GroupBox();
            cameraBox = new PictureBox();
            groupBox1 = new GroupBox();
            listStudentBox = new RichTextBox();
            label6 = new Label();
            countedStudents = new TextBox();
            label5 = new Label();
            attendanceHandleGroup = new GroupBox();
            textBox1 = new TextBox();
            label10 = new Label();
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
            label15 = new Label();
            emailTextBox = new TextBox();
            percentProgess = new TextBox();
            saveStudentImageBtn = new Button();
            buttonTrainImage = new Button();
            trainProcessTextBox = new TextBox();
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
            attendanceTableTextBox = new RichTextBox();
            getAttendanceInfoBtn = new Button();
            label1 = new Label();
            GroupLogo = new PictureBox();
            UniversityLogo = new PictureBox();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabMain.SuspendLayout();
            Recognition.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
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
            Attendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GroupLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UniversityLogo).BeginInit();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(Recognition);
            tabMain.Controls.Add(Training);
            tabMain.Controls.Add(Attendance);
            tabMain.Location = new Point(41, 177);
            tabMain.Margin = new Padding(3, 4, 3, 4);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(1623, 791);
            tabMain.TabIndex = 0;
            tabMain.SelectedIndexChanged += tabMain_SelectedIndexChanged;
            // 
            // Recognition
            // 
            Recognition.Controls.Add(groupBox6);
            Recognition.Controls.Add(groupBox5);
            Recognition.Controls.Add(groupBox2);
            Recognition.Controls.Add(groupBox1);
            Recognition.Controls.Add(attendanceHandleGroup);
            Recognition.Controls.Add(cameraHandleGroup);
            Recognition.Location = new Point(4, 29);
            Recognition.Margin = new Padding(3, 4, 3, 4);
            Recognition.Name = "Recognition";
            Recognition.Padding = new Padding(3, 4, 3, 4);
            Recognition.Size = new Size(1615, 758);
            Recognition.TabIndex = 0;
            Recognition.Text = "Recognition";
            Recognition.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(cboDevices);
            groupBox6.Location = new Point(1242, 451);
            groupBox6.Margin = new Padding(3, 4, 3, 4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 4, 3, 4);
            groupBox6.Size = new Size(367, 293);
            groupBox6.TabIndex = 7;
            groupBox6.TabStop = false;
            groupBox6.Text = "Camera Devices";
            // 
            // cboDevices
            // 
            cboDevices.FormattingEnabled = true;
            cboDevices.Location = new Point(21, 31);
            cboDevices.Name = "cboDevices";
            cboDevices.Size = new Size(307, 28);
            cboDevices.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(qualityFailTextbox);
            groupBox5.Controls.Add(qualityUnkTextbox);
            groupBox5.Controls.Add(qualityCorrectTextbox);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(qualityCheckTextbox);
            groupBox5.Controls.Add(checkQualityBtn);
            groupBox5.Location = new Point(1248, 11);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(351, 432);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Quality Check";
            // 
            // qualityFailTextbox
            // 
            qualityFailTextbox.Location = new Point(168, 275);
            qualityFailTextbox.Margin = new Padding(3, 4, 3, 4);
            qualityFailTextbox.Name = "qualityFailTextbox";
            qualityFailTextbox.Size = new Size(154, 27);
            qualityFailTextbox.TabIndex = 13;
            // 
            // qualityUnkTextbox
            // 
            qualityUnkTextbox.Location = new Point(168, 236);
            qualityUnkTextbox.Margin = new Padding(3, 4, 3, 4);
            qualityUnkTextbox.Name = "qualityUnkTextbox";
            qualityUnkTextbox.Size = new Size(154, 27);
            qualityUnkTextbox.TabIndex = 12;
            // 
            // qualityCorrectTextbox
            // 
            qualityCorrectTextbox.Location = new Point(168, 192);
            qualityCorrectTextbox.Margin = new Padding(3, 4, 3, 4);
            qualityCorrectTextbox.Name = "qualityCorrectTextbox";
            qualityCorrectTextbox.Size = new Size(154, 27);
            qualityCorrectTextbox.TabIndex = 11;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(15, 195);
            label14.Name = "label14";
            label14.Size = new Size(103, 20);
            label14.TabIndex = 10;
            label14.Text = "Correct score :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 239);
            label13.Name = "label13";
            label13.Size = new Size(116, 20);
            label13.TabIndex = 9;
            label13.Text = "Unknown score :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 282);
            label12.Name = "label12";
            label12.Size = new Size(77, 20);
            label12.TabIndex = 8;
            label12.Text = "Fail score :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 55);
            label11.Name = "label11";
            label11.Size = new Size(92, 20);
            label11.TabIndex = 7;
            label11.Text = "Students ID :";
            // 
            // qualityCheckTextbox
            // 
            qualityCheckTextbox.Location = new Point(168, 48);
            qualityCheckTextbox.Margin = new Padding(3, 4, 3, 4);
            qualityCheckTextbox.Name = "qualityCheckTextbox";
            qualityCheckTextbox.Size = new Size(154, 27);
            qualityCheckTextbox.TabIndex = 4;
            // 
            // checkQualityBtn
            // 
            checkQualityBtn.Location = new Point(132, 94);
            checkQualityBtn.Margin = new Padding(3, 4, 3, 4);
            checkQualityBtn.Name = "checkQualityBtn";
            checkQualityBtn.Size = new Size(190, 31);
            checkQualityBtn.TabIndex = 2;
            checkQualityBtn.Text = "Check quality";
            checkQualityBtn.UseVisualStyleBackColor = true;
            checkQualityBtn.Click += checkQualityBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cameraBox);
            groupBox2.Location = new Point(7, 11);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(829, 733);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Camera";
            // 
            // cameraBox
            // 
            cameraBox.Location = new Point(7, 29);
            cameraBox.Margin = new Padding(3, 4, 3, 4);
            cameraBox.Name = "cameraBox";
            cameraBox.Size = new Size(815, 691);
            cameraBox.TabIndex = 0;
            cameraBox.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listStudentBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(countedStudents);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(863, 451);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(367, 293);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recognition Information";
            // 
            // listStudentBox
            // 
            listStudentBox.Location = new Point(19, 110);
            listStudentBox.Margin = new Padding(3, 4, 3, 4);
            listStudentBox.Name = "listStudentBox";
            listStudentBox.Size = new Size(328, 170);
            listStudentBox.TabIndex = 6;
            listStudentBox.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 73);
            label6.Name = "label6";
            label6.Size = new Size(153, 20);
            label6.TabIndex = 5;
            label6.Text = "Students recognition :";
            // 
            // countedStudents
            // 
            countedStudents.Location = new Point(158, 35);
            countedStudents.Margin = new Padding(3, 4, 3, 4);
            countedStudents.Name = "countedStudents";
            countedStudents.Size = new Size(154, 27);
            countedStudents.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 39);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 2;
            label5.Text = "Students counted :";
            // 
            // attendanceHandleGroup
            // 
            attendanceHandleGroup.Controls.Add(textBox1);
            attendanceHandleGroup.Controls.Add(label10);
            attendanceHandleGroup.Controls.Add(checkAttendanceButton);
            attendanceHandleGroup.Controls.Add(label4);
            attendanceHandleGroup.Controls.Add(noteTextBox);
            attendanceHandleGroup.Controls.Add(label3);
            attendanceHandleGroup.Controls.Add(selectDatePicker);
            attendanceHandleGroup.Location = new Point(863, 175);
            attendanceHandleGroup.Margin = new Padding(3, 4, 3, 4);
            attendanceHandleGroup.Name = "attendanceHandleGroup";
            attendanceHandleGroup.Padding = new Padding(3, 4, 3, 4);
            attendanceHandleGroup.Size = new Size(367, 268);
            attendanceHandleGroup.TabIndex = 2;
            attendanceHandleGroup.TabStop = false;
            attendanceHandleGroup.Text = "Attendance Options";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 237);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 27);
            textBox1.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 244);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 5;
            label10.Text = "Progress :";
            // 
            // checkAttendanceButton
            // 
            checkAttendanceButton.Location = new Point(19, 194);
            checkAttendanceButton.Margin = new Padding(3, 4, 3, 4);
            checkAttendanceButton.Name = "checkAttendanceButton";
            checkAttendanceButton.Size = new Size(328, 31);
            checkAttendanceButton.TabIndex = 4;
            checkAttendanceButton.Text = "Check Attendance";
            checkAttendanceButton.UseVisualStyleBackColor = true;
            checkAttendanceButton.Click += checkAttendanceButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 89);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Note :";
            // 
            // noteTextBox
            // 
            noteTextBox.Location = new Point(94, 85);
            noteTextBox.Margin = new Padding(3, 4, 3, 4);
            noteTextBox.Name = "noteTextBox";
            noteTextBox.Size = new Size(253, 101);
            noteTextBox.TabIndex = 2;
            noteTextBox.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 55);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 1;
            label3.Text = "Select date :";
            // 
            // selectDatePicker
            // 
            selectDatePicker.Location = new Point(94, 47);
            selectDatePicker.Margin = new Padding(3, 4, 3, 4);
            selectDatePicker.Name = "selectDatePicker";
            selectDatePicker.Size = new Size(253, 27);
            selectDatePicker.TabIndex = 0;
            // 
            // cameraHandleGroup
            // 
            cameraHandleGroup.Controls.Add(recognitionBtn);
            cameraHandleGroup.Controls.Add(closeCameraBtn);
            cameraHandleGroup.Controls.Add(openCameraBtn);
            cameraHandleGroup.Location = new Point(863, 11);
            cameraHandleGroup.Margin = new Padding(3, 4, 3, 4);
            cameraHandleGroup.Name = "cameraHandleGroup";
            cameraHandleGroup.Padding = new Padding(3, 4, 3, 4);
            cameraHandleGroup.Size = new Size(367, 156);
            cameraHandleGroup.TabIndex = 1;
            cameraHandleGroup.TabStop = false;
            cameraHandleGroup.Text = "Camera Handler";
            // 
            // recognitionBtn
            // 
            recognitionBtn.Location = new Point(94, 107);
            recognitionBtn.Margin = new Padding(3, 4, 3, 4);
            recognitionBtn.Name = "recognitionBtn";
            recognitionBtn.Size = new Size(190, 31);
            recognitionBtn.TabIndex = 2;
            recognitionBtn.Text = "Recognize";
            recognitionBtn.UseVisualStyleBackColor = true;
            recognitionBtn.Click += recognitionBtn_Click;
            // 
            // closeCameraBtn
            // 
            closeCameraBtn.Location = new Point(94, 68);
            closeCameraBtn.Margin = new Padding(3, 4, 3, 4);
            closeCameraBtn.Name = "closeCameraBtn";
            closeCameraBtn.Size = new Size(190, 31);
            closeCameraBtn.TabIndex = 1;
            closeCameraBtn.Text = "Turn off Camera";
            closeCameraBtn.UseVisualStyleBackColor = true;
            closeCameraBtn.Click += closeCameraBtn_Click;
            // 
            // openCameraBtn
            // 
            openCameraBtn.Location = new Point(94, 29);
            openCameraBtn.Margin = new Padding(3, 4, 3, 4);
            openCameraBtn.Name = "openCameraBtn";
            openCameraBtn.Size = new Size(190, 31);
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
            Training.Location = new Point(4, 29);
            Training.Margin = new Padding(3, 4, 3, 4);
            Training.Name = "Training";
            Training.Padding = new Padding(3, 4, 3, 4);
            Training.Size = new Size(1615, 758);
            Training.TabIndex = 1;
            Training.Text = "Training";
            Training.UseVisualStyleBackColor = true;
            // 
            // InformationGroup
            // 
            InformationGroup.Controls.Add(label15);
            InformationGroup.Controls.Add(emailTextBox);
            InformationGroup.Controls.Add(percentProgess);
            InformationGroup.Controls.Add(saveStudentImageBtn);
            InformationGroup.Controls.Add(buttonTrainImage);
            InformationGroup.Controls.Add(trainProcessTextBox);
            InformationGroup.Controls.Add(label9);
            InformationGroup.Controls.Add(idTrainTextBox);
            InformationGroup.Controls.Add(nameTrainTextBox);
            InformationGroup.Controls.Add(label8);
            InformationGroup.Controls.Add(label7);
            InformationGroup.Location = new Point(1035, 423);
            InformationGroup.Margin = new Padding(3, 4, 3, 4);
            InformationGroup.Name = "InformationGroup";
            InformationGroup.Padding = new Padding(3, 4, 3, 4);
            InformationGroup.Size = new Size(398, 325);
            InformationGroup.TabIndex = 3;
            InformationGroup.TabStop = false;
            InformationGroup.Text = "Information";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(27, 96);
            label15.Name = "label15";
            label15.Size = new Size(53, 20);
            label15.TabIndex = 10;
            label15.Text = "Email :";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(142, 96);
            emailTextBox.Margin = new Padding(3, 4, 3, 4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(199, 27);
            emailTextBox.TabIndex = 9;
            // 
            // percentProgess
            // 
            percentProgess.Font = new Font("Segoe UI", 15F);
            percentProgess.Location = new Point(133, 221);
            percentProgess.Margin = new Padding(3, 4, 3, 4);
            percentProgess.Name = "percentProgess";
            percentProgess.Size = new Size(199, 41);
            percentProgess.TabIndex = 8;
            // 
            // saveStudentImageBtn
            // 
            saveStudentImageBtn.Location = new Point(133, 131);
            saveStudentImageBtn.Margin = new Padding(3, 4, 3, 4);
            saveStudentImageBtn.Name = "saveStudentImageBtn";
            saveStudentImageBtn.Size = new Size(200, 39);
            saveStudentImageBtn.TabIndex = 7;
            saveStudentImageBtn.Text = "Save Student Images";
            saveStudentImageBtn.UseVisualStyleBackColor = true;
            saveStudentImageBtn.Click += saveStudentImage_Click;
            // 
            // buttonTrainImage
            // 
            buttonTrainImage.Location = new Point(133, 178);
            buttonTrainImage.Margin = new Padding(3, 4, 3, 4);
            buttonTrainImage.Name = "buttonTrainImage";
            buttonTrainImage.Size = new Size(200, 35);
            buttonTrainImage.TabIndex = 6;
            buttonTrainImage.Text = "Train";
            buttonTrainImage.UseVisualStyleBackColor = true;
            buttonTrainImage.Click += buttonTrainImage_Click;
            // 
            // trainProcessTextBox
            // 
            trainProcessTextBox.Font = new Font("Segoe UI", 15F);
            trainProcessTextBox.Location = new Point(12, 267);
            trainProcessTextBox.Margin = new Padding(3, 4, 3, 4);
            trainProcessTextBox.Name = "trainProcessTextBox";
            trainProcessTextBox.Size = new Size(329, 41);
            trainProcessTextBox.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 230);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 4;
            label9.Text = "Progress :";
            // 
            // idTrainTextBox
            // 
            idTrainTextBox.Location = new Point(142, 59);
            idTrainTextBox.Margin = new Padding(3, 4, 3, 4);
            idTrainTextBox.Name = "idTrainTextBox";
            idTrainTextBox.Size = new Size(199, 27);
            idTrainTextBox.TabIndex = 3;
            // 
            // nameTrainTextBox
            // 
            nameTrainTextBox.Location = new Point(142, 21);
            nameTrainTextBox.Margin = new Padding(3, 4, 3, 4);
            nameTrainTextBox.Name = "nameTrainTextBox";
            nameTrainTextBox.Size = new Size(199, 27);
            nameTrainTextBox.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 59);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 1;
            label8.Text = "Student ID :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 24);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 0;
            label7.Text = "Student name :";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(closeTrainCamera);
            groupBox4.Controls.Add(openTrainCamera);
            groupBox4.Controls.Add(faceDetectTrainBox);
            groupBox4.Location = new Point(1035, 8);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(398, 408);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Detect";
            // 
            // closeTrainCamera
            // 
            closeTrainCamera.Location = new Point(225, 371);
            closeTrainCamera.Margin = new Padding(3, 4, 3, 4);
            closeTrainCamera.Name = "closeTrainCamera";
            closeTrainCamera.Size = new Size(131, 31);
            closeTrainCamera.TabIndex = 2;
            closeTrainCamera.Text = "Close Camera";
            closeTrainCamera.UseVisualStyleBackColor = true;
            closeTrainCamera.Click += closeTrainCamera_Click;
            // 
            // openTrainCamera
            // 
            openTrainCamera.Location = new Point(49, 371);
            openTrainCamera.Margin = new Padding(3, 4, 3, 4);
            openTrainCamera.Name = "openTrainCamera";
            openTrainCamera.Size = new Size(131, 31);
            openTrainCamera.TabIndex = 1;
            openTrainCamera.Text = "Open Camera";
            openTrainCamera.UseVisualStyleBackColor = true;
            openTrainCamera.Click += openTrainCamera_Click;
            // 
            // faceDetectTrainBox
            // 
            faceDetectTrainBox.Location = new Point(27, 29);
            faceDetectTrainBox.Margin = new Padding(3, 4, 3, 4);
            faceDetectTrainBox.Name = "faceDetectTrainBox";
            faceDetectTrainBox.Size = new Size(343, 333);
            faceDetectTrainBox.TabIndex = 0;
            faceDetectTrainBox.TabStop = false;
            // 
            // trainingCameraBox
            // 
            trainingCameraBox.Location = new Point(14, 36);
            trainingCameraBox.Margin = new Padding(3, 4, 3, 4);
            trainingCameraBox.Name = "trainingCameraBox";
            trainingCameraBox.Size = new Size(978, 704);
            trainingCameraBox.TabIndex = 1;
            trainingCameraBox.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(7, 8);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(1001, 740);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Camera";
            // 
            // Attendance
            // 
            Attendance.Controls.Add(attendanceTableTextBox);
            Attendance.Controls.Add(getAttendanceInfoBtn);
            Attendance.Location = new Point(4, 29);
            Attendance.Margin = new Padding(3, 4, 3, 4);
            Attendance.Name = "Attendance";
            Attendance.Padding = new Padding(3, 4, 3, 4);
            Attendance.Size = new Size(1615, 758);
            Attendance.TabIndex = 2;
            Attendance.Text = "Attendance";
            Attendance.UseVisualStyleBackColor = true;
            // 
            // attendanceTableTextBox
            // 
            attendanceTableTextBox.Location = new Point(20, 62);
            attendanceTableTextBox.Name = "attendanceTableTextBox";
            attendanceTableTextBox.Size = new Size(1552, 675);
            attendanceTableTextBox.TabIndex = 1;
            attendanceTableTextBox.Text = "";
            // 
            // getAttendanceInfoBtn
            // 
            getAttendanceInfoBtn.Location = new Point(20, 19);
            getAttendanceInfoBtn.Name = "getAttendanceInfoBtn";
            getAttendanceInfoBtn.Size = new Size(159, 29);
            getAttendanceInfoBtn.TabIndex = 0;
            getAttendanceInfoBtn.Text = "Get attendance table";
            getAttendanceInfoBtn.UseVisualStyleBackColor = true;
            getAttendanceInfoBtn.Click += getAttendanceInfoBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(502, 55);
            label1.Name = "label1";
            label1.Size = new Size(409, 57);
            label1.TabIndex = 1;
            label1.Text = "CLASS ATTENDANCE";
            // 
            // GroupLogo
            // 
            GroupLogo.Image = (Image)resources.GetObject("GroupLogo.Image");
            GroupLogo.InitialImage = (Image)resources.GetObject("GroupLogo.InitialImage");
            GroupLogo.Location = new Point(185, 34);
            GroupLogo.Margin = new Padding(3, 4, 3, 4);
            GroupLogo.Name = "GroupLogo";
            GroupLogo.Size = new Size(105, 112);
            GroupLogo.TabIndex = 2;
            GroupLogo.TabStop = false;
            // 
            // UniversityLogo
            // 
            UniversityLogo.ErrorImage = (Image)resources.GetObject("UniversityLogo.ErrorImage");
            UniversityLogo.ImageLocation = "@\"~Data/assest/logo.png\"";
            UniversityLogo.InitialImage = (Image)resources.GetObject("UniversityLogo.InitialImage");
            UniversityLogo.Location = new Point(45, 23);
            UniversityLogo.Margin = new Padding(3, 4, 3, 4);
            UniversityLogo.Name = "UniversityLogo";
            UniversityLogo.Size = new Size(114, 123);
            UniversityLogo.TabIndex = 3;
            UniversityLogo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(520, 116);
            label2.Name = "label2";
            label2.Size = new Size(331, 30);
            label2.TabIndex = 4;
            label2.Text = "Facial Recoginition with Emgu CV";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // FaceRecoginition
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1717, 1055);
            Controls.Add(label2);
            Controls.Add(UniversityLogo);
            Controls.Add(GroupLogo);
            Controls.Add(label1);
            Controls.Add(tabMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FaceRecoginition";
            Text = "Form1";
            Load += FaceRecoginition_Load;
            tabMain.ResumeLayout(false);
            Recognition.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
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
            Attendance.ResumeLayout(false);
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
        private TextBox countedStudents;
        private Label label5;
        private RichTextBox noteTextBox;
        private GroupBox groupBox2;
        private PictureBox cameraBox;
        private GroupBox groupBox4;
        private PictureBox trainingCameraBox;
        private GroupBox groupBox3;
        private Button closeTrainCamera;
        private Button openTrainCamera;
        private PictureBox faceDetectTrainBox;
        private Button checkAttendanceButton;
        private TextBox textBox1;
        private Label label10;
        private Label label4;
        private ContextMenuStrip contextMenuStrip1;
        private RichTextBox listStudentBox;
        private GroupBox groupBox5;
        private Label label11;
        private TextBox qualityCheckTextbox;
        private Button checkQualityBtn;
        private Label label14;
        private Label label13;
        private Label label12;
        private Button getAttendanceInfoBtn;
        private RichTextBox attendanceTableTextBox;
        private TextBox qualityFailTextbox;
        private TextBox qualityUnkTextbox;
        private TextBox qualityCorrectTextbox;
        private GroupBox InformationGroup;
        private Label label15;
        private TextBox emailTextBox;
        private TextBox percentProgess;
        private Button saveStudentImageBtn;
        private Button buttonTrainImage;
        private TextBox trainProcessTextBox;
        private Label label9;
        private TextBox idTrainTextBox;
        private TextBox nameTrainTextBox;
        private Label label8;
        private Label label7;
        private GroupBox groupBox6;
        private ComboBox cboDevices;
    }
}
