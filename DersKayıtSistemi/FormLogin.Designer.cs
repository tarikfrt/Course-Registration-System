namespace DersKayıtSistemi
{
    partial class FormLogin
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.adminPage = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblAdminPassword = new System.Windows.Forms.Label();
            this.textAdminPassword = new System.Windows.Forms.TextBox();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.textAdminUsername = new System.Windows.Forms.TextBox();
            this.lblAdminUsername = new System.Windows.Forms.Label();
            this.teacherPage = new System.Windows.Forms.TabPage();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.lblTeacherPassword = new System.Windows.Forms.Label();
            this.textTeacherPassword = new System.Windows.Forms.TextBox();
            this.btnTeacherLogin = new System.Windows.Forms.Button();
            this.textTeacherSicilNo = new System.Windows.Forms.TextBox();
            this.lblSicilNo = new System.Windows.Forms.Label();
            this.studentPage = new System.Windows.Forms.TabPage();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.lblStudentPassword = new System.Windows.Forms.Label();
            this.textStudentPassword = new System.Windows.Forms.TextBox();
            this.btnStudentLogin = new System.Windows.Forms.Button();
            this.textStudentNo = new System.Windows.Forms.TextBox();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1.SuspendLayout();
            this.adminPage.SuspendLayout();
            this.teacherPage.SuspendLayout();
            this.studentPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.adminPage);
            this.tabControl1.Controls.Add(this.teacherPage);
            this.tabControl1.Controls.Add(this.studentPage);
            this.tabControl1.Location = new System.Drawing.Point(7, 140);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(944, 587);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // adminPage
            // 
            this.adminPage.BackgroundImage = global::DersKayıtSistemi.Properties.Resources.WhatsApp_Image_2023_10_19_at_12_26_10;
            this.adminPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminPage.Controls.Add(this.checkBox1);
            this.adminPage.Controls.Add(this.lblAdminPassword);
            this.adminPage.Controls.Add(this.textAdminPassword);
            this.adminPage.Controls.Add(this.btnAdminLogin);
            this.adminPage.Controls.Add(this.textAdminUsername);
            this.adminPage.Controls.Add(this.lblAdminUsername);
            this.adminPage.Location = new System.Drawing.Point(4, 25);
            this.adminPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminPage.Name = "adminPage";
            this.adminPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminPage.Size = new System.Drawing.Size(936, 558);
            this.adminPage.TabIndex = 0;
            this.adminPage.Text = "Yönetici";
            this.adminPage.UseVisualStyleBackColor = true;
            this.adminPage.Click += new System.EventHandler(this.adminPage_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(575, 302);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(165, 29);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // lblAdminPassword
            // 
            this.lblAdminPassword.AutoSize = true;
            this.lblAdminPassword.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminPassword.Location = new System.Drawing.Point(366, 245);
            this.lblAdminPassword.Name = "lblAdminPassword";
            this.lblAdminPassword.Size = new System.Drawing.Size(81, 37);
            this.lblAdminPassword.TabIndex = 11;
            this.lblAdminPassword.Text = "Şifre";
            // 
            // textAdminPassword
            // 
            this.textAdminPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textAdminPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAdminPassword.Location = new System.Drawing.Point(373, 295);
            this.textAdminPassword.Name = "textAdminPassword";
            this.textAdminPassword.Size = new System.Drawing.Size(196, 37);
            this.textAdminPassword.TabIndex = 10;
            this.textAdminPassword.UseSystemPasswordChar = true;
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.Color.Turquoise;
            this.btnAdminLogin.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogin.ForeColor = System.Drawing.Color.White;
            this.btnAdminLogin.Location = new System.Drawing.Point(373, 366);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(138, 57);
            this.btnAdminLogin.TabIndex = 9;
            this.btnAdminLogin.Text = "GİRİŞ YAP";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // textAdminUsername
            // 
            this.textAdminUsername.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textAdminUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAdminUsername.Location = new System.Drawing.Point(373, 181);
            this.textAdminUsername.Name = "textAdminUsername";
            this.textAdminUsername.Size = new System.Drawing.Size(196, 37);
            this.textAdminUsername.TabIndex = 6;
            // 
            // lblAdminUsername
            // 
            this.lblAdminUsername.AutoSize = true;
            this.lblAdminUsername.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminUsername.Location = new System.Drawing.Point(366, 130);
            this.lblAdminUsername.Name = "lblAdminUsername";
            this.lblAdminUsername.Size = new System.Drawing.Size(190, 37);
            this.lblAdminUsername.TabIndex = 5;
            this.lblAdminUsername.Text = "Kullanıcı Adı";
            // 
            // teacherPage
            // 
            this.teacherPage.BackgroundImage = global::DersKayıtSistemi.Properties.Resources.WhatsApp_Image_2023_10_19_at_12_26_10;
            this.teacherPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.teacherPage.Controls.Add(this.checkBox2);
            this.teacherPage.Controls.Add(this.lblTeacherPassword);
            this.teacherPage.Controls.Add(this.textTeacherPassword);
            this.teacherPage.Controls.Add(this.btnTeacherLogin);
            this.teacherPage.Controls.Add(this.textTeacherSicilNo);
            this.teacherPage.Controls.Add(this.lblSicilNo);
            this.teacherPage.Location = new System.Drawing.Point(4, 25);
            this.teacherPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teacherPage.Name = "teacherPage";
            this.teacherPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teacherPage.Size = new System.Drawing.Size(936, 558);
            this.teacherPage.TabIndex = 1;
            this.teacherPage.Text = "Öğretim Üyesi";
            this.teacherPage.UseVisualStyleBackColor = true;
            this.teacherPage.Click += new System.EventHandler(this.teacherPage_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox2.Location = new System.Drawing.Point(576, 305);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(165, 29);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Şifreyi Göster";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckStateChanged += new System.EventHandler(this.checkBox2_CheckStateChanged);
            // 
            // lblTeacherPassword
            // 
            this.lblTeacherPassword.AutoSize = true;
            this.lblTeacherPassword.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeacherPassword.Location = new System.Drawing.Point(367, 248);
            this.lblTeacherPassword.Name = "lblTeacherPassword";
            this.lblTeacherPassword.Size = new System.Drawing.Size(81, 37);
            this.lblTeacherPassword.TabIndex = 16;
            this.lblTeacherPassword.Text = "Şifre";
            // 
            // textTeacherPassword
            // 
            this.textTeacherPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textTeacherPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textTeacherPassword.Location = new System.Drawing.Point(374, 298);
            this.textTeacherPassword.Name = "textTeacherPassword";
            this.textTeacherPassword.Size = new System.Drawing.Size(196, 37);
            this.textTeacherPassword.TabIndex = 15;
            this.textTeacherPassword.UseSystemPasswordChar = true;
            // 
            // btnTeacherLogin
            // 
            this.btnTeacherLogin.BackColor = System.Drawing.Color.Turquoise;
            this.btnTeacherLogin.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherLogin.ForeColor = System.Drawing.Color.White;
            this.btnTeacherLogin.Location = new System.Drawing.Point(374, 369);
            this.btnTeacherLogin.Name = "btnTeacherLogin";
            this.btnTeacherLogin.Size = new System.Drawing.Size(138, 57);
            this.btnTeacherLogin.TabIndex = 14;
            this.btnTeacherLogin.Text = "GİRİŞ YAP";
            this.btnTeacherLogin.UseVisualStyleBackColor = false;
            this.btnTeacherLogin.Click += new System.EventHandler(this.btnTeacherLogin_Click);
            // 
            // textTeacherSicilNo
            // 
            this.textTeacherSicilNo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textTeacherSicilNo.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textTeacherSicilNo.Location = new System.Drawing.Point(374, 184);
            this.textTeacherSicilNo.Name = "textTeacherSicilNo";
            this.textTeacherSicilNo.Size = new System.Drawing.Size(196, 37);
            this.textTeacherSicilNo.TabIndex = 13;
            // 
            // lblSicilNo
            // 
            this.lblSicilNo.AutoSize = true;
            this.lblSicilNo.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSicilNo.Location = new System.Drawing.Point(367, 133);
            this.lblSicilNo.Name = "lblSicilNo";
            this.lblSicilNo.Size = new System.Drawing.Size(122, 37);
            this.lblSicilNo.TabIndex = 12;
            this.lblSicilNo.Text = "Sicil No";
            // 
            // studentPage
            // 
            this.studentPage.BackgroundImage = global::DersKayıtSistemi.Properties.Resources.WhatsApp_Image_2023_10_19_at_12_26_10;
            this.studentPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.studentPage.Controls.Add(this.checkBox3);
            this.studentPage.Controls.Add(this.lblStudentPassword);
            this.studentPage.Controls.Add(this.textStudentPassword);
            this.studentPage.Controls.Add(this.btnStudentLogin);
            this.studentPage.Controls.Add(this.textStudentNo);
            this.studentPage.Controls.Add(this.lblStudentNo);
            this.studentPage.Location = new System.Drawing.Point(4, 25);
            this.studentPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentPage.Name = "studentPage";
            this.studentPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentPage.Size = new System.Drawing.Size(936, 558);
            this.studentPage.TabIndex = 2;
            this.studentPage.Text = "Öğrenci";
            this.studentPage.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox3.Location = new System.Drawing.Point(576, 306);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(165, 29);
            this.checkBox3.TabIndex = 18;
            this.checkBox3.Text = "Şifreyi Göster";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckStateChanged += new System.EventHandler(this.checkBox3_CheckStateChanged);
            // 
            // lblStudentPassword
            // 
            this.lblStudentPassword.AutoSize = true;
            this.lblStudentPassword.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentPassword.Location = new System.Drawing.Point(367, 248);
            this.lblStudentPassword.Name = "lblStudentPassword";
            this.lblStudentPassword.Size = new System.Drawing.Size(81, 37);
            this.lblStudentPassword.TabIndex = 16;
            this.lblStudentPassword.Text = "Şifre";
            // 
            // textStudentPassword
            // 
            this.textStudentPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textStudentPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textStudentPassword.Location = new System.Drawing.Point(374, 298);
            this.textStudentPassword.Name = "textStudentPassword";
            this.textStudentPassword.Size = new System.Drawing.Size(196, 37);
            this.textStudentPassword.TabIndex = 15;
            this.textStudentPassword.UseSystemPasswordChar = true;
            // 
            // btnStudentLogin
            // 
            this.btnStudentLogin.BackColor = System.Drawing.Color.Turquoise;
            this.btnStudentLogin.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentLogin.ForeColor = System.Drawing.Color.White;
            this.btnStudentLogin.Location = new System.Drawing.Point(374, 369);
            this.btnStudentLogin.Name = "btnStudentLogin";
            this.btnStudentLogin.Size = new System.Drawing.Size(138, 57);
            this.btnStudentLogin.TabIndex = 14;
            this.btnStudentLogin.Text = "GİRİŞ YAP";
            this.btnStudentLogin.UseVisualStyleBackColor = false;
            this.btnStudentLogin.Click += new System.EventHandler(this.btnStudentLogin_Click);
            // 
            // textStudentNo
            // 
            this.textStudentNo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textStudentNo.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textStudentNo.Location = new System.Drawing.Point(374, 184);
            this.textStudentNo.Name = "textStudentNo";
            this.textStudentNo.Size = new System.Drawing.Size(196, 37);
            this.textStudentNo.TabIndex = 13;
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentNo.Location = new System.Drawing.Point(367, 133);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(177, 37);
            this.lblStudentNo.TabIndex = 12;
            this.lblStudentNo.Text = "Öğrenci No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(164, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(749, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kocaeli Üniversitesi Ders Kayıt Sistemine Hoş Geldiniz";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ImageLocation = "C:\\Users\\AhmetTarikFirat\\OneDrive - Kocaeli Universitesi Uzaktan Egitim Merkezi\\M" +
    "asaüstü\\YazLab1 Belgeler\\Kouyenilogo.png";
            this.pictureBox1.Location = new System.Drawing.Point(24, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders Kayıt Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.adminPage.ResumeLayout(false);
            this.adminPage.PerformLayout();
            this.teacherPage.ResumeLayout(false);
            this.teacherPage.PerformLayout();
            this.studentPage.ResumeLayout(false);
            this.studentPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage adminPage;
        private System.Windows.Forms.TabPage teacherPage;
        private System.Windows.Forms.TabPage studentPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.TextBox textAdminUsername;
        private System.Windows.Forms.Label lblAdminUsername;
        private System.Windows.Forms.TextBox textAdminPassword;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblAdminPassword;
        private System.Windows.Forms.Label lblTeacherPassword;
        private System.Windows.Forms.TextBox textTeacherPassword;
        private System.Windows.Forms.Button btnTeacherLogin;
        private System.Windows.Forms.TextBox textTeacherSicilNo;
        private System.Windows.Forms.Label lblSicilNo;
        private System.Windows.Forms.Label lblStudentPassword;
        private System.Windows.Forms.TextBox textStudentPassword;
        private System.Windows.Forms.Button btnStudentLogin;
        private System.Windows.Forms.TextBox textStudentNo;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

