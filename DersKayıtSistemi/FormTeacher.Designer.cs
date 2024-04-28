namespace DersKayıtSistemi
{
    partial class FormTeacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeacher));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewT1 = new System.Windows.Forms.DataGridView();
            this.btnFTlistStudent = new System.Windows.Forms.Button();
            this.btnFTlistStudentOther = new System.Windows.Forms.Button();
            this.btnFTselectInterest = new System.Windows.Forms.Button();
            this.textFTstudentNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxInterest = new System.Windows.Forms.ComboBox();
            this.btnFTqueryAccept = new System.Windows.Forms.Button();
            this.btnFTshowProfil = new System.Windows.Forms.Button();
            this.btnFTqueryAdd = new System.Windows.Forms.Button();
            this.dataGridViewT2 = new System.Windows.Forms.DataGridView();
            this.comboBoxLesson = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFTselectLesson = new System.Windows.Forms.Button();
            this.comboBoxLessonNo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFTteacherName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textFTmessageBoxSno = new System.Windows.Forms.TextBox();
            this.textFTmessageBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFTsendMessage = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFTteacherSicilNo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textFTlessonId = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnFTback = new System.Windows.Forms.Button();
            this.btnFTshowMyLessons = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewT2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DersKayıtSistemi.Properties.Resources.Kouyenilogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 91);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewT1
            // 
            this.dataGridViewT1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewT1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewT1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewT1.Location = new System.Drawing.Point(574, 8);
            this.dataGridViewT1.Name = "dataGridViewT1";
            this.dataGridViewT1.RowHeadersWidth = 51;
            this.dataGridViewT1.RowTemplate.Height = 24;
            this.dataGridViewT1.Size = new System.Drawing.Size(396, 621);
            this.dataGridViewT1.TabIndex = 33;
            this.dataGridViewT1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewT1_CellContentClick);
            // 
            // btnFTlistStudent
            // 
            this.btnFTlistStudent.BackColor = System.Drawing.Color.Turquoise;
            this.btnFTlistStudent.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFTlistStudent.ForeColor = System.Drawing.Color.OldLace;
            this.btnFTlistStudent.Location = new System.Drawing.Point(390, 87);
            this.btnFTlistStudent.Name = "btnFTlistStudent";
            this.btnFTlistStudent.Size = new System.Drawing.Size(183, 64);
            this.btnFTlistStudent.TabIndex = 36;
            this.btnFTlistStudent.Text = "Talepte Bulunan Öğrencileri Listele";
            this.btnFTlistStudent.UseVisualStyleBackColor = false;
            this.btnFTlistStudent.Click += new System.EventHandler(this.btnFTlistStudent_Click);
            // 
            // btnFTlistStudentOther
            // 
            this.btnFTlistStudentOther.BackColor = System.Drawing.Color.Turquoise;
            this.btnFTlistStudentOther.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFTlistStudentOther.ForeColor = System.Drawing.Color.OldLace;
            this.btnFTlistStudentOther.Location = new System.Drawing.Point(391, 153);
            this.btnFTlistStudentOther.Name = "btnFTlistStudentOther";
            this.btnFTlistStudentOther.Size = new System.Drawing.Size(177, 37);
            this.btnFTlistStudentOther.TabIndex = 35;
            this.btnFTlistStudentOther.Text = "Boştakileri Listele";
            this.btnFTlistStudentOther.UseVisualStyleBackColor = false;
            this.btnFTlistStudentOther.Click += new System.EventHandler(this.btnFTlistStudentOther_Click);
            // 
            // btnFTselectInterest
            // 
            this.btnFTselectInterest.BackColor = System.Drawing.Color.Turquoise;
            this.btnFTselectInterest.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFTselectInterest.ForeColor = System.Drawing.Color.OldLace;
            this.btnFTselectInterest.Location = new System.Drawing.Point(509, 52);
            this.btnFTselectInterest.Name = "btnFTselectInterest";
            this.btnFTselectInterest.Size = new System.Drawing.Size(64, 40);
            this.btnFTselectInterest.TabIndex = 34;
            this.btnFTselectInterest.Text = "SEÇ";
            this.btnFTselectInterest.UseVisualStyleBackColor = false;
            this.btnFTselectInterest.Click += new System.EventHandler(this.btnFTselectInterest_Click);
            // 
            // textFTstudentNo
            // 
            this.textFTstudentNo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textFTstudentNo.Location = new System.Drawing.Point(396, 245);
            this.textFTstudentNo.Name = "textFTstudentNo";
            this.textFTstudentNo.Size = new System.Drawing.Size(177, 33);
            this.textFTstudentNo.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(398, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 39;
            this.label7.Text = "Öğrenci No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(386, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 27);
            this.label1.TabIndex = 38;
            this.label1.Text = "İlgi Alanı";
            // 
            // comboBoxInterest
            // 
            this.comboBoxInterest.FormattingEnabled = true;
            this.comboBoxInterest.Location = new System.Drawing.Point(391, 27);
            this.comboBoxInterest.Name = "comboBoxInterest";
            this.comboBoxInterest.Size = new System.Drawing.Size(177, 24);
            this.comboBoxInterest.TabIndex = 42;
            // 
            // btnFTqueryAccept
            // 
            this.btnFTqueryAccept.BackColor = System.Drawing.Color.Turquoise;
            this.btnFTqueryAccept.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFTqueryAccept.ForeColor = System.Drawing.Color.OldLace;
            this.btnFTqueryAccept.Location = new System.Drawing.Point(396, 330);
            this.btnFTqueryAccept.Name = "btnFTqueryAccept";
            this.btnFTqueryAccept.Size = new System.Drawing.Size(177, 40);
            this.btnFTqueryAccept.TabIndex = 43;
            this.btnFTqueryAccept.Text = "Talep Kabul";
            this.btnFTqueryAccept.UseVisualStyleBackColor = false;
            this.btnFTqueryAccept.Click += new System.EventHandler(this.btnFTqueryAccept_Click);
            // 
            // btnFTshowProfil
            // 
            this.btnFTshowProfil.BackColor = System.Drawing.Color.Turquoise;
            this.btnFTshowProfil.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFTshowProfil.ForeColor = System.Drawing.Color.OldLace;
            this.btnFTshowProfil.Location = new System.Drawing.Point(396, 402);
            this.btnFTshowProfil.Name = "btnFTshowProfil";
            this.btnFTshowProfil.Size = new System.Drawing.Size(177, 40);
            this.btnFTshowProfil.TabIndex = 44;
            this.btnFTshowProfil.Text = "Profil Görüntüle";
            this.btnFTshowProfil.UseVisualStyleBackColor = false;
            this.btnFTshowProfil.Click += new System.EventHandler(this.btnFTshowProfil_Click);
            // 
            // btnFTqueryAdd
            // 
            this.btnFTqueryAdd.BackColor = System.Drawing.Color.Turquoise;
            this.btnFTqueryAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFTqueryAdd.ForeColor = System.Drawing.Color.OldLace;
            this.btnFTqueryAdd.Location = new System.Drawing.Point(396, 365);
            this.btnFTqueryAdd.Name = "btnFTqueryAdd";
            this.btnFTqueryAdd.Size = new System.Drawing.Size(177, 40);
            this.btnFTqueryAdd.TabIndex = 45;
            this.btnFTqueryAdd.Text = "Talep Et";
            this.btnFTqueryAdd.UseVisualStyleBackColor = false;
            this.btnFTqueryAdd.Click += new System.EventHandler(this.btnFTqueryAdd_Click);
            // 
            // dataGridViewT2
            // 
            this.dataGridViewT2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewT2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewT2.Location = new System.Drawing.Point(12, 267);
            this.dataGridViewT2.Name = "dataGridViewT2";
            this.dataGridViewT2.RowHeadersWidth = 51;
            this.dataGridViewT2.RowTemplate.Height = 24;
            this.dataGridViewT2.Size = new System.Drawing.Size(378, 292);
            this.dataGridViewT2.TabIndex = 46;
            // 
            // comboBoxLesson
            // 
            this.comboBoxLesson.FormattingEnabled = true;
            this.comboBoxLesson.Location = new System.Drawing.Point(12, 175);
            this.comboBoxLesson.Name = "comboBoxLesson";
            this.comboBoxLesson.Size = new System.Drawing.Size(177, 24);
            this.comboBoxLesson.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "Ders";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnFTselectLesson
            // 
            this.btnFTselectLesson.BackColor = System.Drawing.Color.Turquoise;
            this.btnFTselectLesson.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFTselectLesson.ForeColor = System.Drawing.Color.OldLace;
            this.btnFTselectLesson.Location = new System.Drawing.Point(208, 220);
            this.btnFTselectLesson.Name = "btnFTselectLesson";
            this.btnFTselectLesson.Size = new System.Drawing.Size(174, 38);
            this.btnFTselectLesson.TabIndex = 47;
            this.btnFTselectLesson.Text = "SEÇ";
            this.btnFTselectLesson.UseVisualStyleBackColor = false;
            // 
            // comboBoxLessonNo
            // 
            this.comboBoxLessonNo.FormattingEnabled = true;
            this.comboBoxLessonNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxLessonNo.Location = new System.Drawing.Point(12, 229);
            this.comboBoxLessonNo.Name = "comboBoxLessonNo";
            this.comboBoxLessonNo.Size = new System.Drawing.Size(177, 24);
            this.comboBoxLessonNo.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 52;
            this.label3.Text = "Ders Katsayısı";
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.Turquoise;
            this.btnSort.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSort.ForeColor = System.Drawing.Color.OldLace;
            this.btnSort.Location = new System.Drawing.Point(207, 565);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(183, 64);
            this.btnSort.TabIndex = 53;
            this.btnSort.Text = "Sırala";
            this.btnSort.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(115, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 37);
            this.label4.TabIndex = 54;
            this.label4.Text = "Hoş Geldiniz";
            // 
            // lblFTteacherName
            // 
            this.lblFTteacherName.AutoSize = true;
            this.lblFTteacherName.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFTteacherName.ForeColor = System.Drawing.Color.Red;
            this.lblFTteacherName.Location = new System.Drawing.Point(115, 62);
            this.lblFTteacherName.Name = "lblFTteacherName";
            this.lblFTteacherName.Size = new System.Drawing.Size(262, 37);
            this.lblFTteacherName.TabIndex = 56;
            this.lblFTteacherName.Text = "Hikmetcan Özcan";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.OldLace;
            this.button1.Location = new System.Drawing.Point(12, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 64);
            this.button1.TabIndex = 57;
            this.button1.Text = "Mesaj Görüntüle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(396, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 27);
            this.label5.TabIndex = 65;
            this.label5.Text = "Öğrenci No";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textFTmessageBoxSno
            // 
            this.textFTmessageBoxSno.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textFTmessageBoxSno.Location = new System.Drawing.Point(396, 499);
            this.textFTmessageBoxSno.Name = "textFTmessageBoxSno";
            this.textFTmessageBoxSno.Size = new System.Drawing.Size(177, 33);
            this.textFTmessageBoxSno.TabIndex = 66;
            // 
            // textFTmessageBox
            // 
            this.textFTmessageBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textFTmessageBox.Location = new System.Drawing.Point(396, 565);
            this.textFTmessageBox.Name = "textFTmessageBox";
            this.textFTmessageBox.Size = new System.Drawing.Size(177, 33);
            this.textFTmessageBox.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(396, 535);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 27);
            this.label6.TabIndex = 67;
            this.label6.Text = "Mesaj";
            // 
            // btnFTsendMessage
            // 
            this.btnFTsendMessage.BackColor = System.Drawing.Color.Turquoise;
            this.btnFTsendMessage.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFTsendMessage.ForeColor = System.Drawing.Color.OldLace;
            this.btnFTsendMessage.Location = new System.Drawing.Point(391, 589);
            this.btnFTsendMessage.Name = "btnFTsendMessage";
            this.btnFTsendMessage.Size = new System.Drawing.Size(183, 40);
            this.btnFTsendMessage.TabIndex = 69;
            this.btnFTsendMessage.Text = "Gönder";
            this.btnFTsendMessage.UseVisualStyleBackColor = false;
            this.btnFTsendMessage.Click += new System.EventHandler(this.btnFTsendMessage_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(418, 445);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 24);
            this.label8.TabIndex = 70;
            this.label8.Text = "Mesaj Gönder";
            // 
            // lblFTteacherSicilNo
            // 
            this.lblFTteacherSicilNo.AutoSize = true;
            this.lblFTteacherSicilNo.Location = new System.Drawing.Point(40, 98);
            this.lblFTteacherSicilNo.Name = "lblFTteacherSicilNo";
            this.lblFTteacherSicilNo.Size = new System.Drawing.Size(44, 16);
            this.lblFTteacherSicilNo.TabIndex = 71;
            this.lblFTteacherSicilNo.Text = "label9";
            this.lblFTteacherSicilNo.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(398, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 19);
            this.label9.TabIndex = 72;
            this.label9.Text = "Ders Id";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textFTlessonId
            // 
            this.textFTlessonId.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textFTlessonId.Location = new System.Drawing.Point(396, 303);
            this.textFTlessonId.Name = "textFTlessonId";
            this.textFTlessonId.Size = new System.Drawing.Size(177, 33);
            this.textFTlessonId.TabIndex = 73;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Turquoise;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.OldLace;
            this.button2.Location = new System.Drawing.Point(208, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 40);
            this.button2.TabIndex = 74;
            this.button2.Text = "Öğrenci Listele";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Turquoise;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.OldLace;
            this.button3.Location = new System.Drawing.Point(391, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 37);
            this.button3.TabIndex = 75;
            this.button3.Text = "Beni Seçmeyenleri Listele";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnFTback
            // 
            this.btnFTback.BackColor = System.Drawing.Color.Turquoise;
            this.btnFTback.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFTback.ForeColor = System.Drawing.Color.OldLace;
            this.btnFTback.Location = new System.Drawing.Point(12, 114);
            this.btnFTback.Name = "btnFTback";
            this.btnFTback.Size = new System.Drawing.Size(80, 33);
            this.btnFTback.TabIndex = 93;
            this.btnFTback.Text = "GERİ";
            this.btnFTback.UseVisualStyleBackColor = false;
            this.btnFTback.Click += new System.EventHandler(this.btnFTback_Click);
            // 
            // btnFTshowMyLessons
            // 
            this.btnFTshowMyLessons.BackColor = System.Drawing.Color.Turquoise;
            this.btnFTshowMyLessons.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFTshowMyLessons.ForeColor = System.Drawing.Color.OldLace;
            this.btnFTshowMyLessons.Location = new System.Drawing.Point(199, 105);
            this.btnFTshowMyLessons.Name = "btnFTshowMyLessons";
            this.btnFTshowMyLessons.Size = new System.Drawing.Size(183, 64);
            this.btnFTshowMyLessons.TabIndex = 94;
            this.btnFTshowMyLessons.Text = "Bu dönem Verdiğim Dersleri Listele";
            this.btnFTshowMyLessons.UseVisualStyleBackColor = false;
            this.btnFTshowMyLessons.Click += new System.EventHandler(this.btnFTshowMyLessons_Click);
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DersKayıtSistemi.Properties.Resources.kouIcon;
            this.ClientSize = new System.Drawing.Size(962, 634);
            this.Controls.Add(this.btnFTshowMyLessons);
            this.Controls.Add(this.btnFTback);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textFTlessonId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblFTteacherSicilNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnFTsendMessage);
            this.Controls.Add(this.textFTmessageBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textFTmessageBoxSno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFTteacherName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxLessonNo);
            this.Controls.Add(this.comboBoxLesson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFTselectLesson);
            this.Controls.Add(this.dataGridViewT2);
            this.Controls.Add(this.btnFTqueryAdd);
            this.Controls.Add(this.btnFTshowProfil);
            this.Controls.Add(this.btnFTqueryAccept);
            this.Controls.Add(this.comboBoxInterest);
            this.Controls.Add(this.textFTstudentNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFTlistStudent);
            this.Controls.Add(this.btnFTlistStudentOther);
            this.Controls.Add(this.btnFTselectInterest);
            this.Controls.Add(this.dataGridViewT1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTeacher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTeacher_FormClosing);
            this.Load += new System.EventHandler(this.FormTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewT2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewT1;
        private System.Windows.Forms.Button btnFTlistStudent;
        private System.Windows.Forms.Button btnFTlistStudentOther;
        private System.Windows.Forms.Button btnFTselectInterest;
        private System.Windows.Forms.TextBox textFTstudentNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxInterest;
        private System.Windows.Forms.Button btnFTqueryAccept;
        private System.Windows.Forms.Button btnFTshowProfil;
        private System.Windows.Forms.Button btnFTqueryAdd;
        private System.Windows.Forms.DataGridView dataGridViewT2;
        private System.Windows.Forms.ComboBox comboBoxLesson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFTselectLesson;
        private System.Windows.Forms.ComboBox comboBoxLessonNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblFTteacherName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textFTmessageBoxSno;
        private System.Windows.Forms.TextBox textFTmessageBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFTsendMessage;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblFTteacherSicilNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textFTlessonId;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnFTback;
        private System.Windows.Forms.Button btnFTshowMyLessons;
    }
}