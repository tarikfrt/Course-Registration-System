using iTextSharp.text.pdf.parser;
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
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("server = localHost; port = 5432; Database = desktopapplication; user ID=postgres; password = 12345;");


        private void FormStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            String query = "Select message,teachers.name,teachers.surname from message_box_student inner join teachers on message_box_student.sender = teachers.sicil_no where message_box_student.student_no = @p1";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@p1", lblFSstudentNo.Text);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void btnFSsendMessage_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textFSteacherSicilNoMessage.Text))
            {
                MessageBox.Show("Sicil no kısmı boş bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(textFSmessage.Text))
            {
                MessageBox.Show("Mesaj kısmı boş bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("insert into message_box_teacher (sicil_no,message,sender) values(@p1,@p2,@p3)", connection);
                command.Parameters.AddWithValue("@p1", textFSteacherSicilNoMessage.Text);
                command.Parameters.AddWithValue("@p2", textFSmessage.Text);
                command.Parameters.AddWithValue("@p3", lblFSstudentNo.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Mesaj başarılı bir şekilde gönderildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFSshowOpenLesson_Click(object sender, EventArgs e)
        {
            connection.Open();
            String query = "select teachers_lesson.lesson_id ,teachers_lesson.sicil_no,lessons.name,teachers.name,teachers.surname from teachers_lesson inner join teachers on teachers_lesson.sicil_no = teachers.sicil_no inner join lessons on teachers_lesson.lesson_id = lessons.id order by teachers_lesson.lesson_id";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView2.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void btnFSaddRequest_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textFSlessonId.Text))
            {
                MessageBox.Show("Ders Id kısmı boş bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(textFSteacherSicilNo.Text))
            {
                MessageBox.Show("Öğretim Üyesi sicil no kısmı boş bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("insert into lesson_request (lesson_id,student_no,sicil_no) values(@p1,@p2,@p3)", connection);
                command.Parameters.AddWithValue("@p1",int.Parse(textFSlessonId.Text));
                command.Parameters.AddWithValue("@p2", lblFSstudentNo.Text);
                command.Parameters.AddWithValue("@p3", textFSteacherSicilNo.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Talep Başarılı bir şekilde gönderildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFSlistMyRequest_Click(object sender, EventArgs e)
        {
            connection.Open();
            String query = "select lessons.name,teachers.name,teachers.surname from lesson_request inner join lessons on lesson_request.lesson_id = lessons.id inner join teachers on lesson_request.sicil_no = teachers.sicil_no where lesson_request.student_no = @p1";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@p1", lblFSstudentNo.Text);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView2.DataSource = dataSet.Tables[0];
            connection.Close();

        }

        private void btnFScancelRequest_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("Delete from lesson_request where student_no = @p1 and sicil_no =@p2 and lesson_id=@p3", connection);
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show(textFSlessonId2.Text+ " id li ders talebinizi iptal etmek istediğinizden emin misiniz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                command.Parameters.AddWithValue("@p1", lblFSstudentNo.Text);
                command.Parameters.AddWithValue("@p2", textFScancelSicilNo.Text);
                command.Parameters.AddWithValue("@p3", int.Parse(textFSlessonId2.Text));
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Talep Başarılı bir şekilde iptal edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Talep iptal edilemedi", "Mesaj", MessageBoxButtons.OK);
                connection.Close();

            }
        }

        private void btnFSlistAcceptedLesson_Click(object sender, EventArgs e)
        {
            connection.Open();
            String query = "select lessons.name,teachers.name,teachers.surname from lesson_registrations inner join lessons on lesson_registrations.lesson_id = lessons.id inner join teachers on lesson_registrations.sicil_no = teachers.sicil_no where lesson_registrations.student_no = @p1";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@p1",lblFSstudentNo.Text);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView2.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlDataAdapter dataAdapterInterest = new NpgsqlDataAdapter("select * from areas_of_interest", connection);
            DataTable dataTableInterest = new DataTable();
            dataAdapterInterest.Fill(dataTableInterest);
            comboBoxFSinterest.DisplayMember = "interest_name";
            comboBoxFSinterest.ValueMember = "id";
            comboBoxFSinterest.DataSource = dataTableInterest;
            connection.Close();
        }

        private void btnFSlistByInterest_Click(object sender, EventArgs e)
        {
            connection.Open();
            String query = "select teachers.name,teachers.surname,areas_of_interest.interest_name from aoi_teacher inner join teachers on aoi_teacher.sicil_no = teachers.sicil_no inner join areas_of_interest on aoi_teacher.aoi_id = areas_of_interest.id where aoi_teacher.aoi_id = @p1";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@p1", int.Parse(comboBoxFSinterest.SelectedValue.ToString()));
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void btnFTpdfAdd_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                int sayac = 0;
                //string file = "C:\\Users\\AhmetTarikFirat\\OneDrive - Kocaeli Universitesi Uzaktan Egitim Merkezi\\Masaüstü\\YazLab1 Belgeler\\transkript.pdf\"";
                string file = openFileDialog1.FileName;
                using (iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(file))
                {
                    for (int pageNum = 1; pageNum <= reader.NumberOfPages - 1; pageNum++)
                    {
                        ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                        string text = PdfTextExtractor.GetTextFromPage(reader, pageNum, strategy);
                        text = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(text)));
                        sb.Append(text);
                    }
                }

                String[] allstr = sb.ToString().Split('\n');
                String[] lessons = new string[36];
                String[] lessonsCode = new string[35];
                String[] lessonsName = new string[35];

                char[] factors = new char[36];
                string studentNo = allstr[4];
                string studentName = allstr[6];
                String[] surname = allstr[16].Split(' ');
                string studentSurname = surname[3];

                String[] letterGrade = new string[36];
                int sayac2 = 0;
                int sayac3 = 0;
                for (int i = 0; i < allstr.Length; i++)
                {
                    if ((allstr[i][0] == 'Z' && allstr[i][1] == ' ') || (allstr[i][0] == 'S' && allstr[i][1] == ' '))
                    {
                        String[] str2 = allstr[i].Split(' ');
                        if (str2.Length >= 2)
                        {
                            letterGrade[sayac3] = str2[str2.Length - 2];
                            factors[sayac2] = str2[5][0];
                            lessons[sayac] = (allstr[i - 2]);
                        }
                        sayac++;
                        sayac2++;
                        sayac3++;
                    }
                }

               
                for (int i = 0; i < lessons.Length - 1; i++)
                {
                    lessonsCode[i] = lessons[i].Substring(0, 7);
                    lessonsName[i] = lessons[i].Substring(7);
                }
                for (int i = 0; i < 35; i++)
                {
                    connection.Open();
                    NpgsqlCommand command2 = new NpgsqlCommand("insert into lesson_information (lesson_id,lesson_name,letter_grade,factor,student_no) values(@p1,@p2,@p3,@p4,@p5)", connection);
                    command2.Parameters.AddWithValue("@p1", lessonsCode[i]);
                    command2.Parameters.AddWithValue("@p2", lessonsName[i]);
                    command2.Parameters.AddWithValue("@p3", letterGrade[i ]);
                    command2.Parameters.AddWithValue("@p4", factors[i]);
                    command2.Parameters.AddWithValue("@p5", studentNo);
                    command2.ExecuteNonQuery();
                    connection.Close();


                }

                MessageBox.Show("PDF başarılı bir şekilde yüklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Dosya Seçilemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFSshowOldLesson_Click(object sender, EventArgs e)
        {
            connection.Open();
            String query = "Select lesson_id,lesson_name,letter_grade,factor from lesson_information where student_no = @p1";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@p1", lblFSstudentNo.Text);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void btnFSback_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void btnFSshowRequestFromTeacher_Click(object sender, EventArgs e)
        {
            connection.Open();
            String query = "select lessons.name,request_teacher.lesson_id,request_teacher.sicil_no,teachers.name,teachers.surname from request_teacher inner join lessons on request_teacher.lesson_id = lessons.id inner join teachers on request_teacher.sicil_no = teachers.sicil_no inner join students on request_teacher.student_no = students.student_no where request_teacher.student_no = @p1";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@p1", lblFSstudentNo.Text);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView2.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textFSRequestSicilNo.Text))
            {
                MessageBox.Show("Sicil no kısmı boş bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(textFSRequestLessonId.Text))
            {
                MessageBox.Show("Ders Id kısmı boş bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("insert into lesson_registrations (student_no,sicil_no,lesson_id) values(@p1,@p2,@p3)", connection);
                command.Parameters.AddWithValue("@p1", lblFSstudentNo.Text);
                command.Parameters.AddWithValue("@p2", textFSRequestSicilNo.Text);
                command.Parameters.AddWithValue("@p3", int.Parse(textFSRequestLessonId.Text.ToString()));
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Ders talebi kabul edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                connection.Open();
                NpgsqlCommand command2 = new NpgsqlCommand("Delete from request_teacher where sicil_no = @p4 and lesson_id = @p5 and student_no = @p6", connection);
                command2.Parameters.AddWithValue("@p4", textFSRequestSicilNo.Text);
                command2.Parameters.AddWithValue("@p5", int.Parse(textFSRequestLessonId.Text.ToString()));
                command2.Parameters.AddWithValue("@p6", lblFSstudentNo.Text);
                command2.ExecuteNonQuery();
                connection.Close();




            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textFSlessonId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textFSteacherSicilNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
