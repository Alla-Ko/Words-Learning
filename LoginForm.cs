//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PlusBase
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
            textBox_user.Size = new Size(textBox_user.Size.Width, 64);
            textBox_password.Size = new Size(textBox_password.Size.Width, 64);
            textBox_password.AutoSize = false;
            //this.Size = new Size(498, 350);
            this.StartPosition= FormStartPosition.CenterScreen;
            
            
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor= Color.Green;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.White;
        }
        Point lastpoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top+= e.Y - lastpoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint=new Point(e.X, e.Y);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
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
       
        
        
        
       public string connectionString = "Data Source=mybase.db;Version=3;";
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                String userLogin = textBox_user.Text;
                String userPassword = textBox_password.Text;
                

                SQLiteConnection connection = new SQLiteConnection(connectionString);
                connection.Open();


                string query = "SELECT * FROM users  WHERE login=@ul AND password = @up";
                DataTable table = new DataTable();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ul", userLogin);
                    command.Parameters.AddWithValue("@up", userPassword);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    adapter.Fill(table);
                    
                }
                connection.Close();

                if (table.Rows.Count > 0)
                {
                   
                    Hide();
                    MainForm mainForm = new MainForm();


                    mainForm.Login = userLogin;
                    mainForm.Password = userPassword;
                    
                    mainForm.table_fill(userLogin);
                    
                    mainForm.label_login.Text = userLogin;
                    //MessageBox.Show("ок");
                    mainForm.ShowDialog();
                    
                    try
                    {
                        textBox_user.Text = "";
                        textBox_password.Text = "";
                        Show();
                    }
                    catch
                    {
                        Application.Exit();
                    }

                }
                else
                {
                    MessageBox.Show("Неправильна комбінація логін та пароль", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"База даних не відкрилася {ex.ToString()}", "Помилка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, FontStyle.Underline);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, FontStyle.Regular);
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterForm reg_f= new RegisterForm();
          
            reg_f.ShowDialog();
            Show();
            
        }

        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(sender, e);
            }
            
        }
    }
}
