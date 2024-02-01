using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlusBase
{
    public partial class Tools : Form
    {
        public Tools()
        {
            InitializeComponent();
        }
        public string connectionString = "Data Source=mybase.db;Version=3;";
        //public int ID;
        public string Login;
        public string Username;
        public string Password;
        public bool del = false;
        private void label_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Green;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.White;
        }
        Point lastpoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //хочу внести зміни в аккаунт
            if(textBox_password.Text==textBox_password2.Text&&textBox_name.Text!="Введіть ім'я"&& textBox_password.Text!="Введіть пароль")
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = $"UPDATE users SET name = @name, password = @password WHERE users.login = @Login;";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Login", Login);
                        command.Parameters.AddWithValue("@password", textBox_password.Text);
                        command.Parameters.AddWithValue("@name", textBox_name.Text);
                        //command.ExecuteNonQuery();
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Редагування аккаунту успішне", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Username = textBox_name.Text;
                            Password = textBox_password.Text;
                            connection.Close();
                            this.Close();

                        }
                        else MessageBox.Show("Аккаунт не був відредагований", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();

                    }

                }

               
            }
            else
            {
                MessageBox.Show("Введені некоректні дані","Помилка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //хочу видалити аккаунт
            DialogResult result = MessageBox.Show("Ви дійсно хочете видалити аккаунт разом із словником до нього?","Видалення",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result== DialogResult.OK)
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = $"DELETE FROM words WHERE EXISTS (SELECT 1 FROM users WHERE users.login = words.login AND users.login = @Login);";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Login", Login);

                        //command.ExecuteNonQuery();
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Видалення словника користувача успішне", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Username = textBox_name.Text;
                            Password = textBox_password.Text;
                            connection.Close();

                            

                        }
                       // else MessageBox.Show("Словник користувача не був видалений", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();

                    }

                }
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = $"DELETE FROM users WHERE users.login = @Login;";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Login", Login);
                        
                        //command.ExecuteNonQuery();
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Видалення аккаунту успішне", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Username = textBox_name.Text;
                            Password = textBox_password.Text;
                            connection.Close();
                            del = true;
                            this.Close();

                        }
                        else MessageBox.Show("Аккаунт не був видалений", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();

                    }

                }
                

            }

        }



        private void textBox_name_Leave(object sender, EventArgs e)
        {
            if (textBox_name.Text == "")
            {
                textBox_name.Text = "Введіть ім'я";
                textBox_name.ForeColor = Color.Gray;
            }

        }

        private void textBox_password_Enter(object sender, EventArgs e)
        {
            if (textBox_password.Text == "Введіть пароль")
            {
                textBox_password.Text = "";
                textBox_password.UseSystemPasswordChar = true;
                textBox_password.ForeColor = Color.Black;
            }

        }

        private void textBox_password_Leave(object sender, EventArgs e)
        {
            if (textBox_password.Text == "")
            {
                textBox_password.UseSystemPasswordChar = false;
                textBox_password.Text = "Введіть пароль";
                textBox_password.ForeColor = Color.Gray;
            }

        }

        private void textBox_password2_Enter(object sender, EventArgs e)
        {
            if (textBox_password2.Text == "Введіть пароль")
            {
                textBox_password2.Text = "";
                textBox_password2.UseSystemPasswordChar = true;
                textBox_password2.ForeColor = Color.Black;
            }
        }

        private void textBox_password2_Leave(object sender, EventArgs e)
        {
            if (textBox_password2.Text == "")
            {
                textBox_password2.UseSystemPasswordChar = false;
                textBox_password2.Text = "Введіть пароль";
                textBox_password2.ForeColor = Color.Gray;
            }
        }

        private void textBox_name_Enter(object sender, EventArgs e)
        {
            if (textBox_name.Text is "Введіть ім'я" or "")
            {
                textBox_name.Text = "";
                textBox_name.ForeColor = Color.Black;
            }
        }

        private void textBox_password2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonRegister_Click(sender, e);
            }
           
        }
    }
}
