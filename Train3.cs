using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlusBase
{
    public partial class Train3 : Form
    {
        public Train3(List<Word> w)
        {
            InitializeComponent();
            words = new List<Word>(w);
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            Image resizedImage = new Bitmap(Resource1.bullhorn_png, new Size(110, 110));
            label_word.Image = resizedImage;
            synth = new SpeechSynthesizer();
            PopulateButtonWithRandomWord();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(label_word, "Натисніть, щоб послухати");

        }
        Point lastpoint;
        public SpeechSynthesizer synth;
        List<Button> buttons = new List<Button>();
        public int index_button = -1;
        public int index_word = -1;
        bool first_attempt = true;

        public string connectionString = "Data Source=mybase.db;Version=3;";
        public List<Word> words;

        public void sound(string word)
        {


            synth.Speak(word);

        }



        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
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

        private void label_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //перехід до наступного завдання

            PopulateButtonWithRandomWord();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Green;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Green;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.White;
        }

        private void label_word_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void label_word_MouseMove(object sender, MouseEventArgs e)
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

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        //важливі
        public void PopulateButtonWithRandomWord()
        {
            this.Focus();
            first_attempt = true;
            foreach (Button btn in buttons)
            {
                btn.Enabled = true;
                btn.BackColor = Color.FromArgb(8, 61, 37);
            }
            label3.Visible = false;
            label_res.Visible = false;

            // Вибрати слова, які не були використані
            var unusedWords = words.Where(w => !w.used).ToList();

            // Вибрати випадкове слово зі списку невикористаних слів
            Random random = new Random();
            int randomWordIndex = random.Next(0, unusedWords.Count);
            Word randomWord = unusedWords[randomWordIndex];


            // Зберегти індекс обраного слова
            index_word = words.IndexOf(randomWord);

            // Змінити використання слова на true
            randomWord.used = true;

            // Змінити текст label_word на значення поля en вибраного слова
            label_word.Text = "";


            // Зберегти індекс кнопки з обраним словом
            index_button = random.Next(0, buttons.Count);

            // Створити новий список слів без обраного слова
            var otherWords = words.Where(w => w != randomWord).ToList();

            // Змінити текст інших кнопок на значення поля ua випадкових слів
            for (int i = 0; i < buttons.Count; i++)
            {
                if (i == index_button)
                {
                    // Змінити текст обраної кнопки на значення поля ua вибраного слова
                    buttons[i].Text = randomWord.ua;
                }
                else
                {
                    // Вибрати випадкове слово зі списку слів, яке не дорівнює обраному слову
                    int randomIndex = random.Next(0, otherWords.Count);
                    Word randomOtherWord = otherWords[randomIndex];

                    // Змінити текст кнопки на значення поля ua випадкового слова
                    buttons[i].Text = randomOtherWord.ua;

                    // Видалити обране слово зі списку інших слів, щоб уникнути дублювання
                    otherWords.RemoveAt(randomIndex);
                }
            }
        }
        private void buttons_Click(object sender, EventArgs e)
        {
            int index = buttons.IndexOf((Button)sender);
            if (index != index_button)
            {

                label_res.Text = "Не вірно";
                label_res.Visible = true;
                first_attempt = false;
                this.Focus();
            }
            else
            {
                label_res.Text = "Вірно";
                this.Focus();
                label_res.Visible = true;
                foreach (Button btn in buttons)
                {
                    btn.Enabled = false;
                }
                ((Button)sender).BackColor = Color.Yellow;
                if (first_attempt)
                {
                    words[index_word].rate++;
                    words[index_word].used = true;
                }
                bool anyUnusedWordsLeft = words.Any(w => !w.used);
                if (!anyUnusedWordsLeft)
                {
                    MessageBox.Show("Тренування завершене", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    label3.Visible = true;
                    label3.Focus();
                }

            }
        }


        //
        private void button1_Click(object sender, EventArgs e)
        {
            buttons_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttons_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttons_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttons_Click(sender, e);
        }

        private void label_word_Click(object sender, EventArgs e)
        {
            sound(words[index_word].en);
        }
    }
}

