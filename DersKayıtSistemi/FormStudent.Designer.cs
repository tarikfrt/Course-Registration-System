namespace DersKayıtSistemi
{
    partial class FormStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudent));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFSstudentName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFTpdfAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textFSteacherSicilNoMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFSsendMessage = new System.Windows.Forms.Button();
            this.btnFSaddRequest = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnFSlistByInterest = new System.Windows.Forms.Button();
            this.btnFSshowOpenLesson = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textFSmessage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textFSteacherSicilNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textFSlessonId = new System.Windows.Forms.TextBox();
            this.comboBoxFSinterest = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFSlistAcceptedLesson = new System.Windows.Forms.Button();
            this.btnFSlistMyRequest = new System.Windows.Forms.Button();
            this.textFSlessonId2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFScancelRequest = new System.Windows.Forms.Button();
            this.btnFSshowMessage = new System.Windows.Forms.Button();
            this.lblFSstudentNo = new System.Windows.Forms.Label();
            this.textFScancelSicilNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFSshowOldLesson = new System.Windows.Forms.Button();
            this.btnFSback = new System.Windows.Forms.Button();
            this.btnFSshowRequestFromTeacher = new System.Windows.Forms.Button();
            this.textFSRequestSicilNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textFSRequestLessonId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DersKayıtSistemi.Properties.Resources.Kouyenilogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 96);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // lblFSstudentName
            // 
            this.lblFSstudentName.AutoSize = true;
            this.lblFSstudentName.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFSstudentName.ForeColor = System.Drawing.Color.Red;
            this.lblFSstudentName.Location = new System.Drawing.Point(129, 14);
            this.lblFSstudentName.Name = "lblFSstudentName";
            this.lblFSstudentName.Size = new System.Drawing.Size(263, 37);
            this.lblFSstudentName.TabIndex = 58;
            this.lblFSstudentName.Text = "Ahmet Tarık Fırat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(129, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 37);
            this.label4.TabIndex = 57;
            this.label4.Text = "Hoş Geldiniz";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(415, 336);
            this.dataGridView1.TabIndex = 59;
            // 
            // btnFTpdfAdd
            // 
            this.btnFTpdfAdd.BackColor = System.Drawing.Color.Turquoise;
            this.btnFTpdfAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnFTpdfAdd.ForeColor = System.Drawing.Color.OldLace;
            this.btnFTpdfAdd.Location = new System.Drawing.Point(8, 223);
            this.btnFTpdfAdd.Name = "btnFTpdfAdd";
            this.btnFTpdfAdd.Size = new System.Drawing.Size(128, 57);
            this.btnFTpdfAdd.TabIndex = 61;
            this.btnFTpdfAdd.Text = "PDF Yükle";
            this.btnFTpdfAdd.UseVisualStyleBackColor = false;
            this.btnFTpdfAdd.Click += new System.EventHandler(this.btnFTpdfAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(89, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 27);
            this.label7.TabIndex = 63;
            this.label7.Text = "Mesaj Gönder";
            // 
            // textFSteacherSicilNoMessage
            // 
            this.textFSteacherSicilNoMessage.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textFSteacherSicilNoMessage.Location = new System.Drawing.Point(8, 183);
            this.textFSteacherSicilNoMessage.Name = "textFSteacherSicilNoMessage";
            this.textFSteacherSicilNoMessage.Size = new System.Drawing.Size(148, 33);
            this.textFSteacherSicilNoMessage.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(425, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 64;
            this.label1.Text = "Sicil No";
            // 
            // btnFSsendMessage
            // 
            this.btnFSsendMessage.BackColor = System.Drawing.Color.Turquoise;
            this.btnFSsendMessage.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFSsendMessage.ForeColor = System.Drawing.Color.OldLace;
            this.btnFSsendMessage.Location = new System.Drawing.Point(343, 183);
            this.btnFSsendMessage.Name = "btnFSsendMessage";
            this.btnFSsendMessage.Size = new System.Drawing.Size(80, 33);
            this.btnFSsendMessage.TabIndex = 69;
            this.btnFSsendMessage.Text = "GÖNDER";
            this.btnFSsendMessage.UseVisualStyleBackColor = false;
            this.btnFSsendMessage.Click += new System.EventHandler(this.btnFSsendMessage_Click);
            // 
            // btnFSaddRequest
            // 
            this.btnFSaddRequest.BackColor = System.Drawing.Color.Turquoise;
            this.btnFSaddRequest.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnFSaddRequest.ForeColor = System.Drawing.Color.OldLace;
            this.btnFSaddRequest.Location = new System.Drawing.Point(431, 140);
            this.btnFSaddRequest.Name = "btnFSaddRequest";
            this.btnFSaddRequest.Size = new System.Drawing.Size(166, 57);
            this.btnFSaddRequest.TabIndex = 68;
            this.btnFSaddRequest.Text = "Talep Et";
            this.btnFSaddRequest.UseVisualStyleBackColor = false;
            this.btnFSaddRequest.Click += new System.EventHandler(this.btnFSaddRequest_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(601, 14);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(361, 461);
            this.dataGridView2.TabIndex = 70;
            // 
            // btnFSlistByInterest
            // 
            this.btnFSlistByInterest.BackColor = System.Drawing.Color.Turquoise;
            this.btnFSlistByInterest.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFSlistByInterest.ForeColor = System.Drawing.Color.OldLace;
            this.btnFSlistByInterest.Location = new System.Drawing.Point(431, 315);
            this.btnFSlistByInterest.Name = "btnFSlistByInterest";
            this.btnFSlistByInterest.Size = new System.Drawing.Size(166, 57);
            this.btnFSlistByInterest.TabIndex = 72;
            this.btnFSlistByInterest.Text = "İlgi Alanına Göre Listele";
            this.btnFSlistByInterest.UseVisualStyleBackColor = false;
            this.btnFSlistByInterest.Click += new System.EventHandler(this.btnFSlistByInterest_Click);
            // 
            // btnFSshowOpenLesson
            // 
            this.btnFSshowOpenLesson.BackColor = System.Drawing.Color.Turquoise;
            this.btnFSshowOpenLesson.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnFSshowOpenLesson.ForeColor = System.Drawing.Color.OldLace;
            this.btnFSshowOpenLesson.Location = new System.Drawing.Point(431, 193);
            this.btnFSshowOpenLesson.Name = "btnFSshowOpenLesson";
            this.btnFSshowOpenLesson.Size = new System.Drawing.Size(166, 57);
            this.btnFSshowOpenLesson.TabIndex = 71;
            this.btnFSshowOpenLesson.Text = "Açılan Dersleri Listele";
            this.btnFSshowOpenLesson.UseVisualStyleBackColor = false;
            this.btnFSshowOpenLesson.Click += new System.EventHandler(this.btnFSshowOpenLesson_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(169, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 27);
            this.label2.TabIndex = 66;
            this.label2.Text = "Mesaj";
            // 
            // textFSmessage
            // 
            this.textFSmessage.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textFSmessage.Location = new System.Drawing.Point(174, 183);
            this.textFSmessage.Name = "textFSmessage";
            this.textFSmessage.Size = new System.Drawing.Size(163, 33);
            this.textFSmessage.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(429, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 27);
            this.label5.TabIndex = 75;
            this.label5.Text = "Ders Id";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textFSteacherSicilNo
            // 
            this.textFSteacherSicilNo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textFSteacherSicilNo.Location = new System.Drawing.Point(433, 109);
            this.textFSteacherSicilNo.Name = "textFSteacherSicilNo";
            this.textFSteacherSicilNo.Size = new System.Drawing.Size(163, 33);
            this.textFSteacherSicilNo.TabIndex = 78;
            this.textFSteacherSicilNo.TextChanged += new System.EventHandler(this.textFSteacherSicilNo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(426, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 27);
            this.label3.TabIndex = 77;
            this.label3.Text = "Ö.Ü. Sicil No";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textFSlessonId
            // 
            this.textFSlessonId.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textFSlessonId.Location = new System.Drawing.Point(433, 47);
            this.textFSlessonId.Name = "textFSlessonId";
            this.textFSlessonId.Size = new System.Drawing.Size(163, 33);
            this.textFSlessonId.TabIndex = 76;
            this.textFSlessonId.TextChanged += new System.EventHandler(this.textFSlessonId_TextChanged);
            // 
            // comboBoxFSinterest
            // 
            this.comboBoxFSinterest.FormattingEnabled = true;
            this.comboBoxFSinterest.Location = new System.Drawing.Point(434, 283);
            this.comboBoxFSinterest.Name = "comboBoxFSinterest";
            this.comboBoxFSinterest.Size = new System.Drawing.Size(163, 24);
            this.comboBoxFSinterest.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(429, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 27);
            this.label6.TabIndex = 81;
            this.label6.Text = "İlgi Alanı";
            // 
            // btnFSlistAcceptedLesson
            // 
            this.btnFSlistAcceptedLesson.BackColor = System.Drawing.Color.Turquoise;
            this.btnFSlistAcceptedLesson.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFSlistAcceptedLesson.ForeColor = System.Drawing.Color.OldLace;
            this.btnFSlistAcceptedLesson.Location = new System.Drawing.Point(431, 366);
            this.btnFSlistAcceptedLesson.Name = "btnFSlistAcceptedLesson";
            this.btnFSlistAcceptedLesson.Size = new System.Drawing.Size(166, 57);
            this.btnFSlistAcceptedLesson.TabIndex = 82;
            this.btnFSlistAcceptedLesson.Text = "Talebi Kabul Edilen Dersleri Listele";
            this.btnFSlistAcceptedLesson.UseVisualStyleBackColor = false;
            this.btnFSlistAcceptedLesson.Click += new System.EventHandler(this.btnFSlistAcceptedLesson_Click);
            // 
            // btnFSlistMyRequest
            // 
            this.btnFSlistMyRequest.BackColor = System.Drawing.Color.Turquoise;
            this.btnFSlistMyRequest.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFSlistMyRequest.ForeColor = System.Drawing.Color.OldLace;
            this.btnFSlistMyRequest.Location = new System.Drawing.Point(431, 418);
            this.btnFSlistMyRequest.Name = "btnFSlistMyRequest";
            this.btnFSlistMyRequest.Size = new System.Drawing.Size(166, 57);
            this.btnFSlistMyRequest.TabIndex = 83;
            this.btnFSlistMyRequest.Text = "Ders Taleblerimi  Göster ";
            this.btnFSlistMyRequest.UseVisualStyleBackColor = false;
            this.btnFSlistMyRequest.Click += new System.EventHandler(this.btnFSlistMyRequest_Click);
            // 
            // textFSlessonId2
            // 
            this.textFSlessonId2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textFSlessonId2.Location = new System.Drawing.Point(496, 517);
            this.textFSlessonId2.Name = "textFSlessonId2";
            this.textFSlessonId2.Size = new System.Drawing.Size(101, 33);
            this.textFSlessonId2.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(428, 531);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 19);
            this.label8.TabIndex = 85;
            this.label8.Text = "Ders Id";
            // 
            // btnFScancelRequest
            // 
            this.btnFScancelRequest.BackColor = System.Drawing.Color.Turquoise;
            this.btnFScancelRequest.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFScancelRequest.ForeColor = System.Drawing.Color.OldLace;
            this.btnFScancelRequest.Location = new System.Drawing.Point(431, 556);
            this.btnFScancelRequest.Name = "btnFScancelRequest";
            this.btnFScancelRequest.Size = new System.Drawing.Size(166, 57);
            this.btnFScancelRequest.TabIndex = 86;
            this.btnFScancelRequest.Text = "Talep İptal Et";
            this.btnFScancelRequest.UseVisualStyleBackColor = false;
            this.btnFScancelRequest.Click += new System.EventHandler(this.btnFScancelRequest_Click);
            // 
            // btnFSshowMessage
            // 
            this.btnFSshowMessage.BackColor = System.Drawing.Color.Turquoise;
            this.btnFSshowMessage.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnFSshowMessage.ForeColor = System.Drawing.Color.OldLace;
            this.btnFSshowMessage.Location = new System.Drawing.Point(295, 222);
            this.btnFSshowMessage.Name = "btnFSshowMessage";
            this.btnFSshowMessage.Size = new System.Drawing.Size(128, 57);
            this.btnFSshowMessage.TabIndex = 87;
            this.btnFSshowMessage.Text = "Mesaj Göster";
            this.btnFSshowMessage.UseVisualStyleBackColor = false;
            this.btnFSshowMessage.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFSstudentNo
            // 
            this.lblFSstudentNo.AutoSize = true;
            this.lblFSstudentNo.Location = new System.Drawing.Point(487, 616);
            this.lblFSstudentNo.Name = "lblFSstudentNo";
            this.lblFSstudentNo.Size = new System.Drawing.Size(44, 16);
            this.lblFSstudentNo.TabIndex = 88;
            this.lblFSstudentNo.Text = "label9";
            this.lblFSstudentNo.Visible = false;
            // 
            // textFScancelSicilNo
            // 
            this.textFScancelSicilNo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textFScancelSicilNo.Location = new System.Drawing.Point(496, 478);
            this.textFScancelSicilNo.Name = "textFScancelSicilNo";
            this.textFScancelSicilNo.Size = new System.Drawing.Size(101, 33);
            this.textFScancelSicilNo.TabIndex = 89;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.Location = new System.Drawing.Point(3, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 27);
            this.label9.TabIndex = 90;
            this.label9.Text = "Sicil No";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnFSshowOldLesson
            // 
            this.btnFSshowOldLesson.BackColor = System.Drawing.Color.Turquoise;
            this.btnFSshowOldLesson.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnFSshowOldLesson.ForeColor = System.Drawing.Color.OldLace;
            this.btnFSshowOldLesson.Location = new System.Drawing.Point(136, 224);
            this.btnFSshowOldLesson.Name = "btnFSshowOldLesson";
            this.btnFSshowOldLesson.Size = new System.Drawing.Size(153, 56);
            this.btnFSshowOldLesson.TabIndex = 91;
            this.btnFSshowOldLesson.Text = "Pdf deki dersleri görüntüle";
            this.btnFSshowOldLesson.UseVisualStyleBackColor = false;
            this.btnFSshowOldLesson.Click += new System.EventHandler(this.btnFSshowOldLesson_Click);
            // 
            // btnFSback
            // 
            this.btnFSback.BackColor = System.Drawing.Color.Turquoise;
            this.btnFSback.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFSback.ForeColor = System.Drawing.Color.OldLace;
            this.btnFSback.Location = new System.Drawing.Point(3, 109);
            this.btnFSback.Name = "btnFSback";
            this.btnFSback.Size = new System.Drawing.Size(80, 33);
            this.btnFSback.TabIndex = 92;
            this.btnFSback.Text = "GERİ";
            this.btnFSback.UseVisualStyleBackColor = false;
            this.btnFSback.Click += new System.EventHandler(this.btnFSback_Click);
            // 
            // btnFSshowRequestFromTeacher
            // 
            this.btnFSshowRequestFromTeacher.BackColor = System.Drawing.Color.Turquoise;
            this.btnFSshowRequestFromTeacher.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFSshowRequestFromTeacher.ForeColor = System.Drawing.Color.OldLace;
            this.btnFSshowRequestFromTeacher.Location = new System.Drawing.Point(601, 558);
            this.btnFSshowRequestFromTeacher.Name = "btnFSshowRequestFromTeacher";
            this.btnFSshowRequestFromTeacher.Size = new System.Drawing.Size(166, 57);
            this.btnFSshowRequestFromTeacher.TabIndex = 93;
            this.btnFSshowRequestFromTeacher.Text = "Ö.Ü den gelen talepleri göster";
            this.btnFSshowRequestFromTeacher.UseVisualStyleBackColor = false;
            this.btnFSshowRequestFromTeacher.Click += new System.EventHandler(this.btnFSshowRequestFromTeacher_Click);
            // 
            // textFSRequestSicilNo
            // 
            this.textFSRequestSicilNo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textFSRequestSicilNo.Location = new System.Drawing.Point(837, 483);
            this.textFSRequestSicilNo.Name = "textFSRequestSicilNo";
            this.textFSRequestSicilNo.Size = new System.Drawing.Size(101, 33);
            this.textFSRequestSicilNo.TabIndex = 97;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(769, 536);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 19);
            this.label10.TabIndex = 96;
            this.label10.Text = "Ders Id";
            // 
            // textFSRequestLessonId
            // 
            this.textFSRequestLessonId.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textFSRequestLessonId.Location = new System.Drawing.Point(837, 522);
            this.textFSRequestLessonId.Name = "textFSRequestLessonId";
            this.textFSRequestLessonId.Size = new System.Drawing.Size(101, 33);
            this.textFSRequestLessonId.TabIndex = 95;
            this.textFSRequestLessonId.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(766, 492);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 19);
            this.label11.TabIndex = 94;
            this.label11.Text = "Sicil No";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Turquoise;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.OldLace;
            this.button2.Location = new System.Drawing.Point(773, 558);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 57);
            this.button2.TabIndex = 98;
            this.button2.Text = "Talep Kabul et";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DersKayıtSistemi.Properties.Resources.kouIcon;
            this.ClientSize = new System.Drawing.Size(962, 634);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textFSRequestSicilNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textFSRequestLessonId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnFSshowRequestFromTeacher);
            this.Controls.Add(this.btnFSback);
            this.Controls.Add(this.btnFSshowOldLesson);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textFScancelSicilNo);
            this.Controls.Add(this.lblFSstudentNo);
            this.Controls.Add(this.btnFSshowMessage);
            this.Controls.Add(this.btnFScancelRequest);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textFSlessonId2);
            this.Controls.Add(this.btnFSlistMyRequest);
            this.Controls.Add(this.btnFSlistAcceptedLesson);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxFSinterest);
            this.Controls.Add(this.textFSteacherSicilNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textFSlessonId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFSlistByInterest);
            this.Controls.Add(this.btnFSshowOpenLesson);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnFSsendMessage);
            this.Controls.Add(this.btnFSaddRequest);
            this.Controls.Add(this.textFSmessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textFSteacherSicilNoMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFTpdfAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblFSstudentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStudent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStudent_FormClosing);
            this.Load += new System.EventHandler(this.FormStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblFSstudentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFTpdfAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textFSteacherSicilNoMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFSsendMessage;
        private System.Windows.Forms.Button btnFSaddRequest;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnFSlistByInterest;
        private System.Windows.Forms.Button btnFSshowOpenLesson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textFSmessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textFSteacherSicilNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textFSlessonId;
        private System.Windows.Forms.ComboBox comboBoxFSinterest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFSlistAcceptedLesson;
        private System.Windows.Forms.Button btnFSlistMyRequest;
        private System.Windows.Forms.TextBox textFSlessonId2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFScancelRequest;
        private System.Windows.Forms.Button btnFSshowMessage;
        public System.Windows.Forms.Label lblFSstudentNo;
        private System.Windows.Forms.TextBox textFScancelSicilNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFSshowOldLesson;
        private System.Windows.Forms.Button btnFSback;
        private System.Windows.Forms.Button btnFSshowRequestFromTeacher;
        private System.Windows.Forms.TextBox textFSRequestSicilNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textFSRequestLessonId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
    }
}