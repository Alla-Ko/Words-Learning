using Microsoft.VisualBasic.Logging;
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
    public partial class Trenings : Form
    {
        public Trenings()
        {
            InitializeComponent();
        }
        Point lastpoint;
        public string Login;
        public string connectionString = "Data Source=mybase.db;Version=3;";
        private void label_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.White;
        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Green;
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
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
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string updateQuery = "UPDATE words SET rate1 = 0, rate2 = 0, rate3 = 0 WHERE login = @Login;";
                    using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Login", Login);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Всі слова позначені, як не вивчені", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Рівень вивченості слів не змінено", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка під час оновлення записів: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //перше завдання переклад на українську

            //сформувати список слів для тренування
            List<Word> words = GetWords1(Login);
            if(words.Count < 5) {
                MessageBox.Show("Недостатньо слів для тренування, збийте показник вивченості або додайте нові слова у словник", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Train1 form= new Train1(words);
            form.ShowDialog();
            UpdateRates1(form.words);


        }

        public List<Word> GetWords1(string login)
        {
            List<Word> words = new List<Word>();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT id, en, ua, rate1 FROM words WHERE login = @login AND rate1 < 3";
                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@login", login);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Word word = new Word();
                                word.id = reader.GetInt32(0);
                                word.en = reader.GetString(1);
                                word.ua = reader.GetString(2);
                                word.rate = reader.GetInt32(3);
                                word.used = false;

                                words.Add(word);
                            }
                        }
                    }

                    connection.Close();
                }

                return words;
            }
            catch(Exception ex) {
                MessageBox.Show($"Помилка {ex.Message}", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
        public List<Word> GetWords2(string login)
        {
            List<Word> words = new List<Word>();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT id, en, ua, rate2 FROM words WHERE login = @login AND rate2 < 3";
                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@login", login);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Word word = new Word();
                                word.id = reader.GetInt32(0);
                                word.en = reader.GetString(1);
                                word.ua = reader.GetString(2);
                                word.rate = reader.GetInt32(3);
                                word.used = false;

                                words.Add(word);
                            }
                        }
                    }

                    connection.Close();
                }

                return words;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка {ex.Message}", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
        public List<Word> GetWords3(string login)
        {
            List<Word> words = new List<Word>();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT id, en, ua, rate3 FROM words WHERE login = @login AND rate3 < 3";
                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@login", login);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Word word = new Word();
                                word.id = reader.GetInt32(0);
                                word.en = reader.GetString(1);
                                word.ua = reader.GetString(2);
                                word.rate = reader.GetInt32(3);
                                word.used = false;

                                words.Add(word);
                            }
                        }
                    }

                    connection.Close();
                }

                return words;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка {ex.Message}", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
        public void UpdateRates1(List<Word> words)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string updateQuery = "UPDATE words SET rate1 = @rate WHERE id = @id";
                    using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                    {
                        foreach (Word word in words)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@rate", word.rate);
                            command.Parameters.AddWithValue("@id", word.id);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error updating rates: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void UpdateRates2(List<Word> words)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string updateQuery = "UPDATE words SET rate2 = @rate WHERE id = @id";
                    using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                    {
                        foreach (Word word in words)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@rate", word.rate);
                            command.Parameters.AddWithValue("@id", word.id);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error updating rates: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void UpdateRates3(List<Word> words)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string updateQuery = "UPDATE words SET rate3 = @rate WHERE id = @id";
                    using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                    {
                        foreach (Word word in words)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@rate", word.rate);
                            command.Parameters.AddWithValue("@id", word.id);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error updating rates: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //друге тренування

            //сформувати список слів для тренування
            List<Word> words = GetWords2(Login);
            if (words.Count < 5)
            {
                MessageBox.Show("Недостатньо слів для тренування, збийте показник вивченості або додайте нові слова у словник", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Train2 form = new Train2(words);
            form.ShowDialog();
            UpdateRates2(form.words);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //аудіювання
            List<Word> words = GetWords3(Login);
            if (words.Count < 5)
            {
                MessageBox.Show("Недостатньо слів для тренування, збийте показник вивченості або додайте нові слова у словник", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Train3 form = new Train3(words);
            form.ShowDialog();
            UpdateRates3(form.words);

        }
    }
    public class Word
    {
        public int id;
        public string en;
        public string ua;
        public int rate;
        public bool used;

    }
}
