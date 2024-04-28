using Npgsql;
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
    public partial class FormTeacher : Form
    {
        NpgsqlCommand command44;
        public FormTeacher()
        {
            InitializeComponent();
        }

        private void FormTeacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        NpgsqlConnection connection = new NpgsqlConnection("server = localHost; port = 5432; Database = desktopapplication; user ID=postgres; password = 12345;");

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlDataAdapter dataAdapterInterest = new NpgsqlDataAdapter("select * from areas_of_interest",connection);
            DataTable dataTableInterest = new DataTable();
            dataAdapterInterest.Fill(dataTableInterest);
            comboBoxInterest.DisplayMember = "interest_name";
            comboBoxInterest.ValueMember = "id";
            comboBoxInterest.DataSource = dataTableInterest;
            connection.Close();

            connection.Open();
            NpgsqlDataAdapter dataAdapterLesson = new NpgsqlDataAdapter("select * from lessons", connection);
            DataTable dataTableLesson = new DataTable();
            dataAdapterLesson.Fill(dataTableLesson);
            comboBoxLesson.DisplayMember = "name";
            comboBoxLesson.ValueMember = "id";
            comboBoxLesson.DataSource = dataTableLesson;
            connection.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnFTselectInterest_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(comboBoxInterest.SelectedValue.ToString()))
            {
                MessageBox.Show("Lütfen bir İlgi alanı seçiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("insert into aoi_teacher (sicil_no,aoi_id) values(@p1,@p2)", connection);
                command.Parameters.AddWithValue("@p1", lblFTteacherSicilNo.Text);
                command.Parameters.AddWithValue("@p2", int.Parse(comboBoxInterest.SelectedValue.ToString()));
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(" İlgi alanı başarılı bir şekilde kayıt edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFTsendMessage_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textFTmessageBoxSno.Text))
            {
                MessageBox.Show("Öğrenci no kısmı boş bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(textFTmessageBox.Text))
            {
                MessageBox.Show("Mesaj kısmı boş bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("insert into message_box_student (student_no,message,sender) values(@p1,@p2,@p3)", connection);
                command.Parameters.AddWithValue("@p1", textFTmessageBoxSno.Text);
                command.Parameters.AddWithValue("@p2", textFTmessageBox.Text);
                command.Parameters.AddWithValue("@p3", lblFTteacherSicilNo.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Mesaj başarılı bir şekilde gönderildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            String query = "Select message,students.name,students.surname from message_box_teacher inner join students on message_box_teacher.sender = students.student_no where message_box_teacher.sicil_no = @p1";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@p1",lblFTteacherSicilNo.Text);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridViewT2.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void btnFTlistStudentOther_Click(object sender, EventArgs e)
        {
            connection.Open();
            String query = "select lessons.name,lesson_request.lesson_id,students.student_no,students.name,students.surname from lesson_request inner join lessons on lesson_request.lesson_id = lessons.id inner join students on lesson_request.student_no = students.student_no where lesson_request.sicil_no = @p1";
            NpgsqlCommand command = new NpgsqlCommand(query,connection);
            command.Parameters.AddWithValue("@p1", lblFTteacherSicilNo.Text);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridViewT1.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void btnFTlistStudent_Click(object sender, EventArgs e)
        {
            connection.Open();
            String query = "select lessons.name,lesson_request.lesson_id,students.student_no,students.name,students.surname from lesson_request inner join lessons on lesson_request.lesson_id = lessons.id inner join students on lesson_request.student_no = students.student_no where lesson_request.sicil_no = @p1";
            NpgsqlCommand command = new NpgsqlCommand(query,connection);
            command.Parameters.AddWithValue("@p1", lblFTteacherSicilNo.Text);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridViewT1.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnFTqueryAccept_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textFTstudentNo.Text))
            {
                MessageBox.Show("Öğrenci no kısmı boş bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(textFTlessonId.Text))
            {
                MessageBox.Show("Ders Id kısmı boş bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("insert into lesson_registrations (student_no,sicil_no,lesson_id) values(@p1,@p2,@p3)", connection);
                command.Parameters.AddWithValue("@p1", textFTstudentNo.Text);
                command.Parameters.AddWithValue("@p2", lblFTteacherSicilNo.Text);
                command.Parameters.AddWithValue("@p3", int.Parse(textFTlessonId.Text.ToString()));
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(textFTstudentNo.Text+" no lu öğrencinin ders talebi kabul edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                connection.Open();
                NpgsqlCommand command2 = new NpgsqlCommand("Delete from lesson_request where student_no = @p1 and sicil_no =@p2 and lesson_id=@p3", connection);
                command2.Parameters.AddWithValue("@p1", textFTstudentNo.Text);
                command2.Parameters.AddWithValue("@p2", lblFTteacherSicilNo.Text);
                command2.Parameters.AddWithValue("@p3", int.Parse(textFTlessonId.Text.ToString()));
                command2.ExecuteNonQuery();
                connection.Close();
                



            }
        }

        private void dataGridViewT1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnFTshowProfil_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textFTstudentNo.Text))
            {
                MessageBox.Show("Öğrenci no kısmı boş bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                connection.Open();
                String query = "select lessons.name,students.name,students.surname,teachers.name,teachers.surname from lesson_registrations inner join lessons on lesson_registrations.lesson_id = lessons.id inner join teachers on lesson_registrations.sicil_no = teachers.sicil_no inner join students on lesson_registrations.student_no = students.student_no where lesson_registrations.student_no = @p1";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@p1", textFTstudentNo.Text);
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridViewT2.DataSource = dataSet.Tables[0];
                connection.Close();

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            String query = "Select student_no,name,surname from students order by student_no";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridViewT1.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            String query = "Select distinct students.student_no,students.name,students.surname,lessons.name,lessons.id from lesson_registrations join teachers_lesson on lesson_registrations.lesson_id = teachers_lesson.lesson_id join lessons on  lesson_registrations.lesson_id= lessons.id inner join students on lesson_registrations.student_no = students.student_no where not lesson_registrations.sicil_no = @p1";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@p1", lblFTteacherSicilNo.Text);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridViewT1.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void btnFTback_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void btnFTshowMyLessons_Click(object sender, EventArgs e)
        {
            connection.Open();
            String query = "select teachers_lesson.lesson_id ,lessons.name from teachers_lesson inner join teachers on teachers_lesson.sicil_no = teachers.sicil_no inner join lessons on teachers_lesson.lesson_id = lessons.id where teachers_lesson.sicil_no = @p1";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@p1", lblFTteacherSicilNo.Text);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridViewT2.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void btnFTqueryAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textFTstudentNo.Text))
            {
                MessageBox.Show("Öğrenci no kısmı boş bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(textFTlessonId.Text))
            {
                MessageBox.Show("Ders Id kısmı boş bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("insert into request_teacher (sicil_no,lesson_id,student_no) values(@p1,@p2,@p3)", connection);
                command.Parameters.AddWithValue("@p1", lblFTteacherSicilNo.Text);
                command.Parameters.AddWithValue("@p2", int.Parse(textFTlessonId.Text.ToString()));
                command.Parameters.AddWithValue("@p3", textFTstudentNo.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(textFTstudentNo.Text + " no lu öğrenciye talep gönderildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
    }
}
