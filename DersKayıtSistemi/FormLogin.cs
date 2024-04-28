using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DersKayıtSistemi
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void teacherPage_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            Boolean state = textAdminPassword.UseSystemPasswordChar;
            textAdminPassword.UseSystemPasswordChar = !state;
        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            Boolean state = textTeacherPassword.UseSystemPasswordChar;
            textTeacherPassword.UseSystemPasswordChar = !state;
        }

        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {
            Boolean state = textStudentPassword.UseSystemPasswordChar;
            textStudentPassword.UseSystemPasswordChar = !state;
        }
        NpgsqlConnection connection = new NpgsqlConnection("server = localHost; port = 5432; Database = desktopapplication; user ID=postgres; password = 12345;");
        NpgsqlCommand command;
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {


            
            AdminPassword adminPassword = new AdminPassword();
            String query = "Select * from admin";
            connection.Open();
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query,connection);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            
            command= new NpgsqlCommand(query,connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                adminPassword.userName = reader["username"].ToString();
                adminPassword.password = reader["password"].ToString();
            }
            


            if ((adminPassword.userName.Equals(textAdminUsername.Text.ToString())) && (adminPassword.password.Equals(textAdminPassword.Text.ToString())))
            {
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.Show();
                this.Hide();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre hatalı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        private void btnTeacherLogin_Click(object sender, EventArgs e)
        {
            TeacherPassword teacherPassword = new TeacherPassword();

            String query = "Select * from teachers";
            connection.Open();
            command = new NpgsqlCommand(query, connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            int control = 1;
            while (reader.Read())
            {
                
                teacherPassword.sicilNo = reader["sicil_no"].ToString();
                teacherPassword.password = reader["password"].ToString();

                if ((teacherPassword.sicilNo.Equals(textTeacherSicilNo.Text.ToString())) && (teacherPassword.password.Equals(textTeacherPassword.Text.ToString())))
                {
                    
                    control = 0;
                    FormTeacher formTeacher = new FormTeacher();
                    formTeacher.Show();
                    formTeacher.lblFTteacherName.Text= reader["name"].ToString()+" "+ reader["surname"].ToString();
                    formTeacher.lblFTteacherSicilNo.Text = teacherPassword.sicilNo.ToString();
                    this.Hide();
                }
                


            }
            if(control == 1) {
                MessageBox.Show("Kullanıcı adı ya da şifre hatalı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
            
            
            connection.Close();
        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            StudentPassword studentPassword = new StudentPassword();

            String query = "Select * from students";
            connection.Open();
            command = new NpgsqlCommand(query, connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            int control = 1;
            while (reader.Read())
            {

                studentPassword.studentNo = reader["student_no"].ToString();
                studentPassword.password = reader["password"].ToString();

                if ((studentPassword.studentNo.Equals(textStudentNo.Text.ToString())) && (studentPassword.password.Equals(textStudentPassword.Text.ToString())))
                {
                    control = 0;
                    FormStudent formStudent = new FormStudent();
                    formStudent.Show();
                    formStudent.lblFSstudentName.Text = reader["name"].ToString() + " " + reader["surname"].ToString();
                    formStudent.lblFSstudentNo.Text = studentPassword.studentNo.ToString();
                    this.Hide();
                }



            }
            if (control == 1)
            {
                MessageBox.Show("Kullanıcı adı ya da şifre hatalı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



            connection.Close();
        }

        private void adminPage_Click(object sender, EventArgs e)
        {

        }
    }
}
