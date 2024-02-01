using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PlusBase
{
    public partial class Add_Edit : Form
    {
        public Add_Edit()
        {
            InitializeComponent();
        }
        public string Login;
        public bool edit = false;
        public int word_id;
        public string word_en;
        public string connectionString = "Data Source=mybase.db;Version=3;";
        private void textBox_eng_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == ' ' && textBox_eng.SelectionStart == 0)
            {
                e.Handled = true; // Відміна введення пробіла на початку тексту
            }
            else
           // if (textBox_ua.SelectionStart == 1 && e.KeyChar == ' ') e.Handled = true;
            if (!(char.IsLetter(e.KeyChar) && e.KeyChar >= 'a' && e.KeyChar <= 'z') && // Перевірка на латинську літеру (мала)
                !(char.IsLetter(e.KeyChar) && e.KeyChar >= 'A' && e.KeyChar <= 'Z') && // Перевірка на латинську літеру (велика)
                e.KeyChar != ' ' && e.KeyChar != '\'' && e.KeyChar != '\b' && e.KeyChar != '-' && // Перевірка на пробіл, апостроф та дефіс
                e.KeyChar != '(' && e.KeyChar != ')') // Перевірка на круглі дужки
            {
                e.Handled = true; // Відміна введення неприпустимого символу
            }
            if (e.KeyChar == ' ' && textBox_eng.Text.Length > 0 && textBox_eng.SelectionStart > 0 && textBox_eng.Text[textBox_eng.SelectionStart - 1] == ' ')
            {
                e.Handled = true;
                return;
            }
        }
        private void textBox_ua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' && textBox_ua.SelectionStart == 0)
            {
                e.Handled = true; // Відміна введення пробіла на початку тексту
            }
            else
           // if (textBox_ua.SelectionStart == 1 && e.KeyChar == ' ') e.Handled = true; // Відміна введення неприпустимого символу
            // Перевірка, чи натиснута клавіша є допустимою (кирилична літера, пробіл, апостроф, дефіс, круглі дужки, Backspace)
            if (!(char.IsLetter(e.KeyChar) && ((e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || e.KeyChar == 'І' || e.KeyChar == 'і' || e.KeyChar == 'Є' || e.KeyChar == 'є' || e.KeyChar == 'ї' || e.KeyChar == 'Ї')) && // Перевірка на кириличну літеру та символи "ї" та "Ї"
                e.KeyChar != ' ' && e.KeyChar != '\'' && e.KeyChar != '\b' && e.KeyChar != '-' && // Перевірка на пробіл, апостроф та дефіс
                e.KeyChar != '(' && e.KeyChar != ')' && // Перевірка на круглі дужки
                e.KeyChar != (char)Keys.Back) // Блокування введення латинських літер
            {
                e.Handled = true; // Відміна введення неприпустимого символу
            }
            if (e.KeyChar == ' ' && textBox_ua.Text.Length > 0 && textBox_ua.SelectionStart > 0 && textBox_ua.Text[textBox_ua.SelectionStart - 1] == ' ')
            {
                e.Handled = true;
                return;
            }
        }

        private bool is_word(string en)
        {     
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM words WHERE login = @login AND en = @en;";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", Login);
                        command.Parameters.AddWithValue("@en", en);
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        connection.Close();
                        if (table.Rows.Count > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Проблема з підключенням до бази даних, {ex.Message}", "Повідомлення про помилку", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }
        private void button_OK_Click(object sender, EventArgs e)
        {
            string en = textBox_eng.Text;
            string ua = textBox_ua.Text;
            string tr = textBox_transcription.Text;


            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                if (!edit)
                {
                    if (en.Length < 2 || ua.Length < 2)
                    {
                        MessageBox.Show("Заповніть поля", "Повідомлення про помилку", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (is_word(en))
                    {
                        MessageBox.Show("Таке слово вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    try
                    {
                        //Додаємо слово
                        connection.Open();

                        string insertQuery = "INSERT INTO words (en,ua,login, transkr) VALUES (@en, @ua, @login, @tr);";
                        using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@login", Login);
                            command.Parameters.AddWithValue("@en", en);
                            command.Parameters.AddWithValue("@ua", ua);
                            command.Parameters.AddWithValue("@tr", tr);
                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Слово додане успішно", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                connection.Close();
                                Close();
                            }
                            else MessageBox.Show("Слово не було додане", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        connection.Close();
                        return;
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show($"Проблема з підключенням до бази даних, {ex.Message}", "Повідомлення про помилку", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (edit)
                {
                    if (en.Length < 2 || ua.Length < 2)
                    {
                        MessageBox.Show("Заповніть поля", "Повідомлення про помилку", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (is_word(en) && en != word_en)
                    {
                        MessageBox.Show("Таке слово вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    try
                    {
                        //Редагуємо слово
                        //MessageBox.Show(word_id.ToString());
                        connection.Open();
                        
                        string updateQuery = "UPDATE words SET en = @en, ua = @ua, login = @login, transkr = @tr WHERE id = @id;";
                        using (SQLiteCommand command1 = new SQLiteCommand(updateQuery, connection))
                        {
                            command1.Parameters.AddWithValue("@login", Login);
                            command1.Parameters.AddWithValue("@en", en);
                            command1.Parameters.AddWithValue("@ua", ua);
                            command1.Parameters.AddWithValue("@tr", tr);
                            command1.Parameters.AddWithValue("@id", word_id);

                           // MessageBox.Show(word_id.ToString());
                            if (command1.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Слово було відредаговане", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                connection.Close();
                                Close();

                            }
                            else MessageBox.Show("Слово не було відредаговане", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           // MessageBox.Show("ok");
                        }
                        connection.Close();
                        return;
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show($"Проблема з підключенням до бази даних, {ex.Message}", "Повідомлення про помилку", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                Close();
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label_name_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
    

        private void label_name_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
        //кнопка закрити на хрестик
        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Green;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
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

        private void textBox_eng_KeyDown(object sender, KeyEventArgs e)
        {
            // Копіювання тексту за допомогою Ctrl+C
            if (e.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetText(textBox_eng.SelectedText); // Копіювати вміст виділеного тексту в буфер обміну
            }

            // Вирізання тексту за допомогою Ctrl+X
            if (e.Control && e.KeyCode == Keys.X)
            {
                Clipboard.SetText(textBox_eng.SelectedText); // Копіювати вміст виділеного тексту в буфер обміну
                textBox_eng.SelectedText = ""; // Видалити виділений текст
            }
        }

        private void textBox_eng_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                string textToPaste = Clipboard.GetText(); // Отримати текст з буфера обміну
                textBox_eng.SelectedText = ""; // Видалити поточне виділення
                int startIndex = textBox_eng.SelectionStart; // Зберегти позицію курсору
                textBox_eng.Text = textBox_eng.Text.Insert(startIndex, textToPaste); // Вставити текст в позицію курсору
                                                                                     // Видалити всі символи, які не задовольняють вашій умові
                textBox_eng.Text = new string(textBox_eng.Text.Where((c, index) =>
                {
                    if (index == 0 && c == ' ') // Перевірка, чи символ є першим і є пробілом
                        return false; // Пропустити пробіли на початку тексту
                    return (char.IsLetter(c) && (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')) || // Літери
                           c == ' ' || c == '\'' || c == '-' || c == '(' || c == ')'; // Дозволені символи
                }).ToArray());
                textBox_eng.Text = textBox_eng.Text.TrimStart();
                // Встановити курсор на оновлену позицію
                textBox_eng.SelectionStart = startIndex + textToPaste.Length;
            }
        }

        private void textBox_ua_KeyDown(object sender, KeyEventArgs e)
        {
            // Копіювання тексту за допомогою Ctrl+C
            if (e.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetText(textBox_ua.SelectedText); // Копіювати вміст виділеного тексту в буфер обміну
            }

            // Вирізання тексту за допомогою Ctrl+X
            if (e.Control && e.KeyCode == Keys.X)
            {
                Clipboard.SetText(textBox_ua.SelectedText); // Копіювати вміст виділеного тексту в буфер обміну
                textBox_ua.SelectedText = ""; // Видалити виділений текст
            }
        }

        private void textBox_ua_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                string textToPaste = Clipboard.GetText(); // Отримати текст з буфера обміну
                textBox_ua.SelectedText = ""; // Видалити поточне виділення
                int startIndex = textBox_ua.SelectionStart; // Зберегти позицію курсору
                textBox_ua.Text = textBox_ua.Text.Insert(startIndex, textToPaste); // Вставити текст в позицію курсору
                                                                                   // Видалити всі символи, які не задовольняють вашій умові
                textBox_ua.Text = new string(textBox_ua.Text.Where((c, index) =>
                {
                    if (index == 0 && c == ' ') // Перевірка, чи символ є першим і є пробілом
                        return false; // Пропустити пробіли на початку тексту
                    return (char.IsLetter(c) && ((c >= 'а' && c <= 'я') || (c >= 'А' && c <= 'Я') || c == 'І' || c == 'і' || c == 'Є' || c == 'є' || c == 'ї' || c == 'Ї')) || // Кириличні літери
                           c == ' ' || c == '\'' || c == '-' || c == '(' || c == ')'; // Дозволені символи
                }).ToArray());
                textBox_ua.Text = textBox_ua.Text.TrimStart();
                // Встановити курсор на оновлену позицію
                textBox_ua.SelectionStart = startIndex + textToPaste.Length;
            }
        }
    }
}

