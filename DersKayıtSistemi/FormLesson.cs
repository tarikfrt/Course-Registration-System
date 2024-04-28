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
    public partial class FormLesson : Form
    {
        public FormLesson()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("server = localHost; port = 5432; Database = desktopapplication; user ID=postgres; password = 12345;");

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            String query = "Select student_no,name,surname from students order by student_no";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView2.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void btnFSshowOpenLesson_Click(object sender, EventArgs e)
        {
            connection.Open();
            String query = "select teachers_lesson.lesson_id ,teachers_lesson.sicil_no,lessons.name,teachers.name,teachers.surname from teachers_lesson inner join teachers on teachers_lesson.sicil_no = teachers.sicil_no inner join lessons on teachers_lesson.lesson_id = lessons.id order by teachers_lesson.lesson_id";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox100.Text))
            {
                MessageBox.Show("Ders Id kısmı boş bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(textBox101.Text))
            {
                MessageBox.Show("Sicil No kısmı boş bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(textBox102.Text))
            {
                MessageBox.Show("Öğrenci no kısmı boş bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("insert into lesson_registrations (lesson_id,sicil_no,student_no) values(@p1,@p2,@p3)", connection);
                command.Parameters.AddWithValue("@p1", int.Parse(textBox100.Text.ToString()));
                command.Parameters.AddWithValue("@p2", textBox101.Text);
                command.Parameters.AddWithValue("@p3", textBox102.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(textBox102.Text + " no lu öğrenciye ders atandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFAback_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }
    }
}
