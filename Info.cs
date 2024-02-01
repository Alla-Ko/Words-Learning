using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PlusBase
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            string rtfText = File.ReadAllText("info.rtf");
            // Вставте RTF-форматований текст у TextBox

            
            richTextBox1.Rtf = rtfText;
        }
        Point lastpoint;
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
    }
}
