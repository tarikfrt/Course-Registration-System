namespace DersKayıtSistemi
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.btnListTeacher = new System.Windows.Forms.Button();
            this.btnListStudent = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textFASicilNo = new System.Windows.Forms.TextBox();
            this.textFAstudentSurname = new System.Windows.Forms.TextBox();
            this.textFAstudentName = new System.Windows.Forms.TextBox();
            this.textFAstudentPassword = new System.Windows.Forms.TextBox();
            this.textFAstudentNo = new System.Windows.Forms.TextBox();
            this.textFAteacherSurname = new System.Windows.Forms.TextBox();
            this.textFAteacherName = new System.Windows.Forms.TextBox();
            this.textFAteacherPassword = new System.Windows.Forms.TextBox();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnUpdateTeacher = new System.Windows.Forms.Button();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.btnTeacherAdd = new System.Windows.Forms.Button();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRandom25student = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sayac = new System.Windows.Forms.Label();
            this.btnFAback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sicil no";
            // 
            // btnListTeacher
            // 
            this.btnListTeacher.BackColor = System.Drawing.Color.Turquoise;
            this.btnListTeacher.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListTeacher.ForeColor = System.Drawing.Color.OldLace;
            this.btnListTeacher.Location = new System.Drawing.Point(12, 558);
            this.btnListTeacher.Name = "btnListTeacher";
            this.btnListTeacher.Size = new System.Drawing.Size(183, 64);
            this.btnListTeacher.TabIndex = 6;
            this.btnListTeacher.Text = "Hocaları Listele";
            this.btnListTeacher.UseVisualStyleBackColor = false;
            this.btnListTeacher.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListStudent
            // 
            this.btnListStudent.BackColor = System.Drawing.Color.Turquoise;
            this.btnListStudent.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListStudent.ForeColor = System.Drawing.Color.OldLace;
            this.btnListStudent.Location = new System.Drawing.Point(767, 558);
            this.btnListStudent.Name = "btnListStudent";
            this.btnListStudent.Size = new System.Drawing.Size(183, 64);
            this.btnListStudent.TabIndex = 5;
            this.btnListStudent.Text = "Öğrencileri Listele";
            this.btnListStudent.UseVisualStyleBackColor = false;
            this.btnListStudent.Click += new System.EventHandler(this.btnListStudent_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(241, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(482, 518);
            this.dataGridView1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(762, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(762, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(762, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Öğrenci no";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(7, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "Soyad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(7, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(7, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = "Şifre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(762, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 27);
            this.label8.TabIndex = 14;
            this.label8.Text = "Şifre";
            // 
            // textFASicilNo
            // 
            this.textFASicilNo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textFASicilNo.Location = new System.Drawing.Point(12, 52);
            this.textFASicilNo.Name = "textFASicilNo";
            this.textFASicilNo.Size = new System.Drawing.Size(145, 33);
            this.textFASicilNo.TabIndex = 15;
            // 
            // textFAstudentSurname
            // 
            this.textFAstudentSurname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textFAstudentSurname.Location = new System.Drawing.Point(767, 287);
            this.textFAstudentSurname.Name = "textFAstudentSurname";
            this.textFAstudentSurname.Size = new System.Drawing.Size(145, 33);
            this.textFAstudentSurname.TabIndex = 16;
            // 
            // textFAstudentName
            // 
            this.textFAstudentName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textFAstudentName.Location = new System.Drawing.Point(767, 210);
            this.textFAstudentName.Name = "textFAstudentName";
            this.textFAstudentName.Size = new System.Drawing.Size(145, 33);
            this.textFAstudentName.TabIndex = 17;
            // 
            // textFAstudentPassword
            // 
            this.textFAstudentPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textFAstudentPassword.Location = new System.Drawing.Point(767, 129);
            this.textFAstudentPassword.Name = "textFAstudentPassword";
            this.textFAstudentPassword.Size = new System.Drawing.Size(145, 33);
            this.textFAstudentPassword.TabIndex = 18;
            // 
            // textFAstudentNo
            // 
            this.textFAstudentNo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textFAstudentNo.Location = new System.Drawing.Point(767, 52);
            this.textFAstudentNo.Name = "textFAstudentNo";
            this.textFAstudentNo.Size = new System.Drawing.Size(145, 33);
            this.textFAstudentNo.TabIndex = 19;
            // 
            // textFAteacherSurname
            // 
            this.textFAteacherSurname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textFAteacherSurname.Location = new System.Drawing.Point(12, 287);
            this.textFAteacherSurname.Name = "textFAteacherSurname";
            this.textFAteacherSurname.Size = new System.Drawing.Size(145, 33);
            this.textFAteacherSurname.TabIndex = 20;
            // 
            // textFAteacherName
            // 
            this.textFAteacherName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textFAteacherName.Location = new System.Drawing.Point(12, 210);
            this.textFAteacherName.Name = "textFAteacherName";
            this.textFAteacherName.Size = new System.Drawing.Size(145, 33);
            this.textFAteacherName.TabIndex = 21;
            // 
            // textFAteacherPassword
            // 
            this.textFAteacherPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textFAteacherPassword.Location = new System.Drawing.Point(12, 129);
            this.textFAteacherPassword.Name = "textFAteacherPassword";
            this.textFAteacherPassword.Size = new System.Drawing.Size(145, 33);
            this.textFAteacherPassword.TabIndex = 22;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.Color.Turquoise;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.OldLace;
            this.btnDeleteStudent.Location = new System.Drawing.Point(767, 407);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(183, 64);
            this.btnDeleteStudent.TabIndex = 25;
            this.btnDeleteStudent.Text = "Öğrenci Sil";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.BackColor = System.Drawing.Color.Turquoise;
            this.btnUpdateStudent.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateStudent.ForeColor = System.Drawing.Color.OldLace;
            this.btnUpdateStudent.Location = new System.Drawing.Point(767, 337);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(183, 64);
            this.btnUpdateStudent.TabIndex = 26;
            this.btnUpdateStudent.Text = "Öğrenci Güncelle";
            this.btnUpdateStudent.UseVisualStyleBackColor = false;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnUpdateTeacher
            // 
            this.btnUpdateTeacher.BackColor = System.Drawing.Color.Turquoise;
            this.btnUpdateTeacher.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateTeacher.ForeColor = System.Drawing.Color.OldLace;
            this.btnUpdateTeacher.Location = new System.Drawing.Point(12, 337);
            this.btnUpdateTeacher.Name = "btnUpdateTeacher";
            this.btnUpdateTeacher.Size = new System.Drawing.Size(183, 64);
            this.btnUpdateTeacher.TabIndex = 23;
            this.btnUpdateTeacher.Text = "Hoca Güncelle";
            this.btnUpdateTeacher.UseVisualStyleBackColor = false;
            this.btnUpdateTeacher.Click += new System.EventHandler(this.btnUpdateTeacher_Click);
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.BackColor = System.Drawing.Color.Turquoise;
            this.btnDeleteTeacher.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteTeacher.ForeColor = System.Drawing.Color.OldLace;
            this.btnDeleteTeacher.Location = new System.Drawing.Point(12, 407);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(183, 64);
            this.btnDeleteTeacher.TabIndex = 24;
            this.btnDeleteTeacher.Text = "Hoca Sil";
            this.btnDeleteTeacher.UseVisualStyleBackColor = false;
            this.btnDeleteTeacher.Click += new System.EventHandler(this.btnDeleteTeacher_Click);
            // 
            // btnTeacherAdd
            // 
            this.btnTeacherAdd.BackColor = System.Drawing.Color.Turquoise;
            this.btnTeacherAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeacherAdd.ForeColor = System.Drawing.Color.OldLace;
            this.btnTeacherAdd.Location = new System.Drawing.Point(12, 486);
            this.btnTeacherAdd.Name = "btnTeacherAdd";
            this.btnTeacherAdd.Size = new System.Drawing.Size(183, 64);
            this.btnTeacherAdd.TabIndex = 27;
            this.btnTeacherAdd.Text = "Hoca Ekle";
            this.btnTeacherAdd.UseVisualStyleBackColor = false;
            this.btnTeacherAdd.Click += new System.EventHandler(this.btnTeacherAdd_Click);
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.BackColor = System.Drawing.Color.Turquoise;
            this.btnStudentAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStudentAdd.ForeColor = System.Drawing.Color.OldLace;
            this.btnStudentAdd.Location = new System.Drawing.Point(767, 488);
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.Size = new System.Drawing.Size(183, 64);
            this.btnStudentAdd.TabIndex = 28;
            this.btnStudentAdd.Text = "Öğrenci Ekle";
            this.btnStudentAdd.UseVisualStyleBackColor = false;
            this.btnStudentAdd.Click += new System.EventHandler(this.btnStudentAdd_Click);
            // 
            // npgsqlCommandBuilder1
            // 
            this.npgsqlCommandBuilder1.QuotePrefix = "\"";
            this.npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.OldLace;
            this.button1.Location = new System.Drawing.Point(241, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 64);
            this.button1.TabIndex = 29;
            this.button1.Text = "Ders Seçim İşlemleri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnRandom25student
            // 
            this.btnRandom25student.BackColor = System.Drawing.Color.Turquoise;
            this.btnRandom25student.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandom25student.ForeColor = System.Drawing.Color.OldLace;
            this.btnRandom25student.Location = new System.Drawing.Point(540, 558);
            this.btnRandom25student.Name = "btnRandom25student";
            this.btnRandom25student.Size = new System.Drawing.Size(183, 64);
            this.btnRandom25student.TabIndex = 30;
            this.btnRandom25student.Text = "Rastgele 25 Öğrenci Oluştur";
            this.btnRandom25student.UseVisualStyleBackColor = false;
            this.btnRandom25student.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DersKayıtSistemi.Properties.Resources.Kouyenilogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(430, 536);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 96);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // sayac
            // 
            this.sayac.AutoSize = true;
            this.sayac.Location = new System.Drawing.Point(520, 616);
            this.sayac.Name = "sayac";
            this.sayac.Size = new System.Drawing.Size(14, 16);
            this.sayac.TabIndex = 32;
            this.sayac.Text = "0";
            this.sayac.Visible = false;
            // 
            // btnFAback
            // 
            this.btnFAback.BackColor = System.Drawing.Color.Turquoise;
            this.btnFAback.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFAback.ForeColor = System.Drawing.Color.OldLace;
            this.btnFAback.Location = new System.Drawing.Point(155, 12);
            this.btnFAback.Name = "btnFAback";
            this.btnFAback.Size = new System.Drawing.Size(80, 33);
            this.btnFAback.TabIndex = 93;
            this.btnFAback.Text = "GERİ";
            this.btnFAback.UseVisualStyleBackColor = false;
            this.btnFAback.Click += new System.EventHandler(this.btnFAback_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DersKayıtSistemi.Properties.Resources.kouIcon;
            this.ClientSize = new System.Drawing.Size(962, 634);
            this.Controls.Add(this.btnFAback);
            this.Controls.Add(this.sayac);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRandom25student);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStudentAdd);
            this.Controls.Add(this.btnTeacherAdd);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnDeleteTeacher);
            this.Controls.Add(this.btnUpdateTeacher);
            this.Controls.Add(this.textFAteacherPassword);
            this.Controls.Add(this.textFAteacherName);
            this.Controls.Add(this.textFAteacherSurname);
            this.Controls.Add(this.textFAstudentNo);
            this.Controls.Add(this.textFAstudentPassword);
            this.Controls.Add(this.textFAstudentName);
            this.Controls.Add(this.textFAstudentSurname);
            this.Controls.Add(this.textFASicilNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListTeacher);
            this.Controls.Add(this.btnListStudent);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdmin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListTeacher;
        private System.Windows.Forms.Button btnListStudent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textFASicilNo;
        private System.Windows.Forms.TextBox textFAstudentSurname;
        private System.Windows.Forms.TextBox textFAstudentName;
        private System.Windows.Forms.TextBox textFAstudentPassword;
        private System.Windows.Forms.TextBox textFAstudentNo;
        private System.Windows.Forms.TextBox textFAteacherSurname;
        private System.Windows.Forms.TextBox textFAteacherName;
        private System.Windows.Forms.TextBox textFAteacherPassword;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnUpdateTeacher;
        private System.Windows.Forms.Button btnDeleteTeacher;
        private System.Windows.Forms.Button btnTeacherAdd;
        private System.Windows.Forms.Button btnStudentAdd;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRandom25student;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label sayac;
        private System.Windows.Forms.Button btnFAback;
    }
}