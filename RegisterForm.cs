using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
using System.Xml.Linq;

namespace PlusBase
{
    public partial class RegisterForm : Form
    {
        
        public RegisterForm()
        {
            InitializeComponent();
            textBox_name.Text = "Введіть ім'я";
            textBox_user.Text = "Введіть логін";
            textBox_password.UseSystemPasswordChar = false;
            textBox_password2.UseSystemPasswordChar = false;
            textBox_password.Text = "Введіть пароль";
            textBox_password2.Text = "Введіть пароль";


            textBox_name.ForeColor = Color.Gray;
            textBox_user.ForeColor = Color.Gray;
            textBox_password.ForeColor = Color.Gray;
            textBox_password2.ForeColor = Color.Gray;
        }
        public string connectionString = "Data Source=mybase.db;Version=3;";

        //кнопка закрити на хрестик
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

        //бордова панель
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
        //назва 
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

        private void textBox_name_Enter(object sender, EventArgs e)
        {
            if (textBox_name.Text == "Введіть ім'я")
            {
                textBox_name.Text = "";
                textBox_name.ForeColor = Color.Black;
            }
                
        }

        private void textBox_user_Enter(object sender, EventArgs e)
        {
            if (textBox_user.Text == "Введіть логін")
            {
                textBox_user.Text = "";
                textBox_user.ForeColor = Color.Black;
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

        private void textBox_password2_Enter(object sender, EventArgs e)
        {
            if (textBox_password2.Text == "Введіть пароль")
            {
                textBox_password2.Text = "";
                textBox_password2.UseSystemPasswordChar = true;
                textBox_password2.ForeColor = Color.Black;
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

        private void textBox_user_Leave(object sender, EventArgs e)
        {
            if (textBox_user.Text == "")
            {
                textBox_user.Text = "Введіть логін";
                textBox_user.ForeColor = Color.Gray;
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

        private void textBox_password2_Leave(object sender, EventArgs e)
        {
            if (textBox_password2.Text == "")
            {
                textBox_password2.UseSystemPasswordChar = false;
                textBox_password2.Text = "Введіть пароль";
                textBox_password2.ForeColor = Color.Gray;
            }
                
            

        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if(textBox_name.Text== "Введіть ім'я")
            {
                MessageBox.Show("Введіть ім'я", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox_user.Text == "Введіть логін")
            {
                MessageBox.Show("Введіть логін", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox_password.Text != textBox_password2.Text)
            {
                MessageBox.Show("Паролі не співпадають", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox_password.Text == "Введіть пароль")
            {
                MessageBox.Show("Введіть пароль","Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (isUserExist())
            {
                MessageBox.Show("Цей логін вже зареєстрваний", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO users (login, password, name) VALUES (@login, @password, @name)";
                    using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@login", textBox_user.Text);
                        command.Parameters.AddWithValue("@password", textBox_password.Text);
                        command.Parameters.AddWithValue("@name", textBox_name.Text);
                        //command.ExecuteNonQuery();
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Аккаунт був створений", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();

                        }
                        else MessageBox.Show("Аккаунт не був створений", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    connection.Close();

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Проблема з підключенням до бази даних", "Повідомлення про помилку", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean isUserExist()
        {
            
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "SELECT * FROM users WHERE login = @login";
                    using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@login", textBox_user.Text);
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    connection.Close();

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Проблема з підключенням до бази даних", "Повідомлення про помилку", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }









            
            
        }

        //авторизація
        private void label7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.Font = new Font(label3.Font, FontStyle.Underline);
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.Font = new Font(label3.Font, FontStyle.Regular);
        }

        private void textBox_password2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonRegister_Click(sender, e);
            }

        }
    }
}
