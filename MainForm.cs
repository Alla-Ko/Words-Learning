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
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace PlusBase
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            label_login.ForeColor = Color.White;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.MultiSelect= false;

            
            toolStripMenuItem2.Click += ToolStripMenuItem2_Click;
            toolStripMenuItem3.Click += ToolStripMenuItem3_Click;// Обробник події для другого елемента меню
            
            contextMenuStrip1.Items.Add(toolStripMenuItem2);
            contextMenuStrip1.Items.Add(toolStripMenuItem3);
            dataGridView.ContextMenuStrip = contextMenuStrip1;


        }
        ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();

        ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem("Редагувати слово");
        ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem("Видалити слово");
        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Переглянути слово
        }
        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Редагувати слово
            edit_word();
        }
        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // Видалити слово
            DeleteSelectedRow();
        }




        public string connectionString = "Data Source=mybase.db;Version=3;";
        public DataTable table = new DataTable();
        public string Login;
        public string Password;
        public string Username;
        //public int Id;
        public void table_fill(string Log)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                connection.Open();//////


                string query = "SELECT * FROM words  WHERE login=@login";
                DataTable table = new DataTable();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", Log);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    adapter.Fill(table);
                }


                connection.Close();//////
                dataGridView.Columns.Clear();
                dataGridView.DataSource = table;
                dataGridView.Columns["login"].Visible = false;
                dataGridView.Columns["id"].Visible = false;
                dataGridView.Columns["rate3"].Visible = false;
                dataGridView.Columns["rate1"].Visible = false;
                dataGridView.Columns["rate2"].Visible = false;
                dataGridView.Columns["en"].DisplayIndex = 0;
                dataGridView.Columns["transkr"].DisplayIndex = 1;
                dataGridView.Columns["ua"].DisplayIndex = 2;
                dataGridView.Columns["rate1"].DisplayIndex = 3;
                dataGridView.Columns["rate1"].DisplayIndex = 4;
                dataGridView.Columns["rate1"].DisplayIndex = 5;
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView.ReadOnly = true;
                dataGridView.AutoResizeColumns();
                dataGridView.Columns[1].HeaderCell.Value = "Англійською";
                dataGridView.Columns[7].HeaderCell.Value = "Транскрипція";
                dataGridView.Columns[2].HeaderCell.Value = "Українською";
                //dataGridView.Columns[4].HeaderCell.Value = "Рівень вивченості (1)";
                //dataGridView.Columns[5].HeaderCell.Value = "Рівень вивченості (2)";
                //dataGridView.Columns[6].HeaderCell.Value = "Рівень вивченості (3)";

                // Додайте стовпець з кнопкою до dataGridView
                var buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Width= 65;
                buttonColumn.HeaderCell.Value ="Вимова";
                dataGridView.Columns.Insert(dataGridView.ColumnCount-1, buttonColumn); // Додаємо колонку з кнопкою в кінець таблиці
                dataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("База даних слів не відкрилася", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Green;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
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

        private void label_title_MouseMove(object sender, MouseEventArgs e)
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

        private void label_title_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label_tools_MouseEnter(object sender, EventArgs e)
        {
            label_tools.Font = new Font(label_tools.Font, FontStyle.Underline);
        }

        private void label_tools_MouseDown(object sender, MouseEventArgs e)
        {
            label_tools.Font = new Font(label_tools.Font, FontStyle.Regular);
        }

        private void label_tools_Click(object sender, EventArgs e)
        {
            //налаштування аккаунта
            Tools tls = new Tools();
            tls.textBox_name.Text = Username;
            tls.textBox_password.Text = Password;
            tls.textBox_password2.Text = Password;
            tls.textBox_user.Text = Login;
            tls.Login = Login;
            Hide();
            tls.ShowDialog();
            if (tls.del)
            {
                Close();
            }
            Username = tls.Username;
            Password = tls.Password;

            Show();
        }

        private void label_tools_MouseLeave(object sender, EventArgs e)
        {
            label_tools.Font = new Font(label_tools.Font, FontStyle.Regular);
        }

        private void search_line()
        {
            string s_line = textBox_search.Text;

            try
            {
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                connection.Open();//////



                string query = "SELECT * FROM words WHERE login=@login AND (en LIKE '%' || @s_line || '%' OR ua LIKE '%' || @s_line || '%');";

                DataTable table = new DataTable();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", Login);
                    command.Parameters.AddWithValue("@s_line", s_line);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    adapter.Fill(table);
                }


                connection.Close();//////

                //dataGridView.DataSource = null;
                
                dataGridView.DataSource = table;
                dataGridView.Refresh();
                textBox_search.Text= string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("База даних слів не відкрилася", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void button_search_Click(object sender, EventArgs e)
        {
            search_line();
           
        }



        private void textBox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_line();
               
            }

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //додати нове слово
            Add_Edit form= new Add_Edit();
            form.Login = Login;
            form.ShowDialog();
            search_line();

        }


        private void DeleteSelectedRow()
        {
            


            // Перевірка, чи вибраний хоча б один рядок
            if (dataGridView.SelectedCells.Count > 0)
            {
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити слово?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Код для видалення слова

                    // Отримати індекс виділеного рядка
                    int selectedIndex = dataGridView.SelectedCells[0].RowIndex;

                    // Отримати значення ідентифікатора рядка (припустимо, що це перший стовпець)
                    int rowId = Convert.ToInt32(dataGridView.Rows[selectedIndex].Cells[1].Value);

                    // Видалити рядок з DataGridView
                    dataGridView.Rows.RemoveAt(selectedIndex);

                    // Видалити рядок з бази даних (припустимо, що у вас є об'єкт SQLiteConnection з ім'ям connection)
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();
                        string deleteQuery = $"DELETE FROM words WHERE id = @Id";
                        using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
                        {

                            command.Parameters.AddWithValue("@Id", rowId);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть слово для видалення.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow();
        }
        private void edit_word()
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                // Отримати індекс виділеного рядка
                int selectedIndex = dataGridView.SelectedCells[0].RowIndex;
                int wordId = Convert.ToInt32(dataGridView.Rows[selectedIndex].Cells[1].Value);

                //редагувати слово
                Add_Edit form = new Add_Edit();
                form.label_name.Text = "Редагувати слово";
                form.button_OK.Text = "Редагувати";
                
                form.Login = Login;
                form.textBox_eng.Text = dataGridView.Rows[selectedIndex].Cells[2].Value.ToString(); 
                form.textBox_ua.Text = dataGridView.Rows[selectedIndex].Cells[3].Value.ToString();
                form.textBox_transcription.Text = dataGridView.Rows[selectedIndex].Cells[8].Value.ToString();
                form.word_id = wordId;
                form.edit = true;
                form.word_en= dataGridView.Rows[selectedIndex].Cells[2].Value.ToString();
                form.ShowDialog();
                search_line();


            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть слово для редагування.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button_edit_Click(object sender, EventArgs e)
        {
            edit_word();
        }

        private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //при натисненні правою кнопкою виділятиме одразу ту ячейку
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView.ClearSelection(); // Очищаємо попередні виділення
                dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true; // Виділяємо натиснуту ячейку
            }

        }

        private void button_tren_Click(object sender, EventArgs e)
        {
            Trenings form = new Trenings();
            form.Login = Login;
            form.ShowDialog();
        }

        private void label_info_MouseDown(object sender, MouseEventArgs e)
        {
            label_info.Font = new Font(label_tools.Font, FontStyle.Regular);
        }

        private void label_info_MouseEnter(object sender, EventArgs e)
        {
            label_info.Font = new Font(label_tools.Font, FontStyle.Underline);
        }

        private void label_info_MouseLeave(object sender, EventArgs e)
        {
            label_info.Font = new Font(label_tools.Font, FontStyle.Regular);
        }

        private void label_info_Click(object sender, EventArgs e)
        {
            //відображення довідки
            Info form= new Info();
            form.ShowDialog();
        }
    }

    public class DataGridViewButtonColumn : DataGridViewColumn
    {
        public DataGridViewButtonColumn()
        {
            CellTemplate = new DataGridViewButtonCell();
        }
    }
    public class DataGridViewButtonCell : DataGridViewCell
    {

        public DataGridViewButtonCell()
        {
            // Встановлюємо тип даних для ячейки
            ValueType = typeof(object); // Встановлюємо тип як об'єкт, оскільки значення цієї ячейки фактично не має значення
            synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
        }
        public SpeechSynthesizer synth;
        // Перевизначаємо метод Clone для правильного клонування
        public override object Clone()
        {
            DataGridViewButtonCell cell = (DataGridViewButtonCell)base.Clone();
            return cell;
        }

        // Перевизначаємо метод Paint для відображення кнопки
        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

            // Отримання розмірів кнопки
            int buttonWidth = cellBounds.Width; // Ширина кнопки
            int buttonHeight = cellBounds.Height; // Висота кнопки

            // Розрахунок розміщення кнопки у центрі клітинки
            int x = cellBounds.X + (cellBounds.Width - buttonWidth) / 2;
            int y = cellBounds.Y + (cellBounds.Height - buttonHeight) / 2;


            // Встановлення кольорів для кнопки
            Color buttonBackColor = Color.FromArgb(13, 96, 58); // Колір для стану наведення миші
            Color buttonBorderColor = Color.White; // Колір рамки
            Color buttonTextBackColor = Color.White; // Колір тексту

            // Малювання кнопки
           



            using (var buttonBrush = new SolidBrush(buttonBackColor))
            using (var buttonBorderPen = new Pen(buttonBorderColor))
            using (var buttonTextBrush = new SolidBrush(buttonTextBackColor))
            {
                graphics.FillRectangle(buttonBrush, x, y, buttonWidth, buttonHeight);
                graphics.DrawRectangle(buttonBorderPen, x, y, buttonWidth, buttonHeight);
                graphics.DrawString("Послухати", cellStyle.Font, buttonTextBrush, x + 2, y);
                
            }

        }
         
        public void sound(string word)
        {
            
            
            synth.Speak(word);

        }

        protected override void OnClick(DataGridViewCellEventArgs e)
        {
            base.OnClick(e);
            // Фіксування рядка та виклик функції
            var dataGridView = DataGridView;
            if (dataGridView != null && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var selectedRow = dataGridView.Rows[e.RowIndex];
                string word= selectedRow.Cells[2].Value.ToString();
                sound(word);
                
            }
        }
    }
}
