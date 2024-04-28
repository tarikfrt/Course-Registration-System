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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        NpgsqlConnection connection = new NpgsqlConnection("server = localHost; port = 5432; Database = desktopapplication; user ID=postgres; password = 12345;");
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            String query = "Select sicil_no,name,surname from teachers";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void btnListStudent_Click(object sender, EventArgs e)
        {
            connection.Open();
            String query = "Select student_no,name,surname from students";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void btnTeacherAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textFASicilNo.Text))
            {
                MessageBox.Show("Sicil no kısmı boş bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(textFAteacherName.Text))
            {
                MessageBox.Show("Ad kısmı boş bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(textFAteacherSurname.Text))
            {
                MessageBox.Show("Soyad kısmı boş bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(textFAteacherPassword.Text))
            {
                MessageBox.Show("Şifre kısmı boş bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("insert into teachers (sicil_no,name,surname,password) values(@p1,@p2,@p3,@p4)", connection);
                command.Parameters.AddWithValue("@p1", textFASicilNo.Text);
                command.Parameters.AddWithValue("@p2", textFAteacherName.Text);
                command.Parameters.AddWithValue("@p3", textFAteacherSurname.Text);
                command.Parameters.AddWithValue("@p4", textFAteacherPassword.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(textFAteacherName.Text + " " + textFAteacherSurname.Text + " sisteme başarılı bir şekilde kayıt edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textFAstudentNo.Text))
            {
                MessageBox.Show("Öğrenci no kısmı boş bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(textFAstudentName.Text))
            {
                MessageBox.Show("Öğrenci ad kısmı boş bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(textFAstudentSurname.Text))
            {
                MessageBox.Show("Öğrenci soyad kısmı boş bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(textFAstudentPassword.Text))
            {
                MessageBox.Show("Öğrenci şifre kısmı boş bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("insert into students (student_no,name,surname,password) values(@p1,@p2,@p3,@p4)", connection);
                command.Parameters.AddWithValue("@p1", textFAstudentNo.Text);
                command.Parameters.AddWithValue("@p2", textFAstudentName.Text);
                command.Parameters.AddWithValue("@p3", textFAstudentSurname.Text);
                command.Parameters.AddWithValue("@p4", textFAstudentPassword.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(textFAstudentName.Text + " " + textFAstudentSurname.Text + " sisteme başarılı bir şekilde kayıt edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("Delete from teachers where sicil_no = @p1", connection);
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show(textFASicilNo.Text + " sicil no lu öğretim üyesini sistemden silmek istediğinizden emin misiniz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                command.Parameters.AddWithValue("@p1", textFASicilNo.Text);
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi", "Mesaj", MessageBoxButtons.OK);
                connection.Close();
            }

        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("Delete from students where student_no = @p1", connection);
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show(textFAstudentNo.Text + " öğrenci no lu öğrenciyi sistemden silmek istediğinizden emin misiniz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                command.Parameters.AddWithValue("@p1", textFAstudentNo.Text);
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi", "Mesaj", MessageBoxButtons.OK);
                connection.Close();
            }
        }

        private void btnUpdateTeacher_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("Update teachers set name=@p2,surname=@p3,password=@p4 where sicil_no=@p1", connection);

                command.Parameters.AddWithValue("@p1", textFASicilNo.Text);

                command.Parameters.AddWithValue("@p2", textFAteacherName.Text);

                command.Parameters.AddWithValue("@p3", textFAteacherSurname.Text);

                command.Parameters.AddWithValue("@p4", textFAteacherPassword.Text);
            
            

            command.ExecuteNonQuery();
            MessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK);
            connection.Close();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("Update students set name=@p2,surname=@p3,password=@p4 where student_no=@p1", connection);
            
                command.Parameters.AddWithValue("@p1", textFAstudentNo.Text);

                command.Parameters.AddWithValue("@p2", textFAstudentName.Text);

                command.Parameters.AddWithValue("@p3", textFAstudentSurname.Text);

                command.Parameters.AddWithValue("@p4", textFAstudentPassword.Text);
            
            command.ExecuteNonQuery();
            MessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK);
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] names = { "Ahmet","Mehmet","Ramazan","Ayşe","Beyza","Elif","Ece","Efe","Miraç","Ömer","Furkan","Ali","Cumali"
            ,"Emre","Zeynep","Musatafa","Kemal","Melisa","Aybuke","Şevval","Fatma","Züleyha","Selin","Abuzer","Kerem","Kenan","Cabbar","Habil","Samet","Nisa","Neriman"};
            string[] surnames = { "Yıldırım","Fırat","Yılmaz","Bozdağ","Esen","Yuvakuran","Güneş","Alemdar","Çakır","Güleryüz","Kehriban"
            ,"Nal","Şeker","Doğan","Etige","Altun","Temel","Tosun","Şen","Ünlü","Düz","Solabakan","Bakan","SağaBakan","Yerebakan","Çavdur","Nimet","Turan","Demiral","Demirel"};

            Random randomName = new Random();
            Random randomSurname = new Random();
            int sayacInt = Convert.ToInt16(sayac.Text);
            for (int i = 0; i < 25; i++)
            {
                int randomNames = randomName.Next(names.Count());
                int randomSurnames = randomSurname.Next(surnames.Count());
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("insert into students (student_no,name,surname,password) values(@p1,@p2,@p3,@p4)", connection);
                command.Parameters.AddWithValue("@p1", sayacInt.ToString());
                sayacInt++;
                command.Parameters.AddWithValue("@p2", names[randomNames]);
                command.Parameters.AddWithValue("@p3", surnames[randomSurnames]);
                command.Parameters.AddWithValue("@p4", "123");
                command.ExecuteNonQuery();
                connection.Close();
            }
            
            MessageBox.Show(" 25 kişi sisteme başarılı bir şekilde kayıt edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sayac.Text = sayacInt.ToString();
        }

        private void btnFAback_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormLesson formLesson = new FormLesson();
            formLesson.Show();
            this.Hide();
        }
    }
}
