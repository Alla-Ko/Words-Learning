namespace PlusBase
{
    partial class Add_Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_close = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_eng = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.textBox_transcription = new System.Windows.Forms.TextBox();
            this.textBox_ua = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_close
            // 
            this.label_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_close.AutoSize = true;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_close.ForeColor = System.Drawing.Color.White;
            this.label_close.Location = new System.Drawing.Point(1046, 0);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(29, 35);
            this.label_close.TabIndex = 1;
            this.label_close.Text = "x";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_name
            // 
            this.label_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_name.Font = new System.Drawing.Font("Comic Sans MS", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.label_name.Location = new System.Drawing.Point(0, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(724, 80);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Додати слово";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_name_MouseDown);
            this.label_name.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_name_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(8)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.button_Cancel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_eng);
            this.panel1.Controls.Add(this.button_OK);
            this.panel1.Controls.Add(this.textBox_transcription);
            this.panel1.Controls.Add(this.textBox_ua);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 436);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(37)))));
            this.button_Cancel.FlatAppearance.BorderSize = 0;
            this.button_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(20)))));
            this.button_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(96)))), ((int)(((byte)(58)))));
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Cancel.ForeColor = System.Drawing.Color.White;
            this.button_Cancel.Location = new System.Drawing.Point(444, 343);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(250, 68);
            this.button_Cancel.TabIndex = 12;
            this.button_Cancel.Text = "Відмінити";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(150, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Авторизуватися";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Transcription";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "UA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "ENG";
            // 
            // textBox_eng
            // 
            this.textBox_eng.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_eng.Location = new System.Drawing.Point(178, 97);
            this.textBox_eng.Multiline = true;
            this.textBox_eng.Name = "textBox_eng";
            this.textBox_eng.Size = new System.Drawing.Size(516, 64);
            this.textBox_eng.TabIndex = 0;
            this.textBox_eng.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_eng_KeyDown);
            this.textBox_eng.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_eng_KeyPress);
            this.textBox_eng.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_eng_KeyUp);
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(37)))));
            this.button_OK.FlatAppearance.BorderSize = 0;
            this.button_OK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(20)))));
            this.button_OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(96)))), ((int)(((byte)(58)))));
            this.button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OK.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_OK.ForeColor = System.Drawing.Color.White;
            this.button_OK.Location = new System.Drawing.Point(178, 343);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(250, 68);
            this.button_OK.TabIndex = 5;
            this.button_OK.Text = "Додати";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // textBox_transcription
            // 
            this.textBox_transcription.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_transcription.Location = new System.Drawing.Point(178, 251);
            this.textBox_transcription.Name = "textBox_transcription";
            this.textBox_transcription.Size = new System.Drawing.Size(516, 56);
            this.textBox_transcription.TabIndex = 3;
            // 
            // textBox_ua
            // 
            this.textBox_ua.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_ua.Location = new System.Drawing.Point(178, 174);
            this.textBox_ua.Multiline = true;
            this.textBox_ua.Name = "textBox_ua";
            this.textBox_ua.Size = new System.Drawing.Size(516, 64);
            this.textBox_ua.TabIndex = 2;
            this.textBox_ua.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_ua_KeyDown);
            this.textBox_ua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ua_KeyPress);
            this.textBox_ua.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_ua_KeyUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(79)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label_close);
            this.panel2.Controls.Add(this.label_name);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 80);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(695, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "x";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // Add_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 436);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Edit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label_close;
        public Label label_name;
        private Panel panel1;
        private Button button_Cancel;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label2;
        public TextBox textBox_eng;
        public Button button_OK;
        public TextBox textBox_transcription;
        public TextBox textBox_ua;
        private Panel panel2;
        private Label label1;
    }
}