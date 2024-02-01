namespace PlusBase
{
    partial class Info
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
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
            this.label_close.Location = new System.Drawing.Point(1004, 0);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(29, 35);
            this.label_close.TabIndex = 1;
            this.label_close.Text = "x";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            this.label_close.MouseEnter += new System.EventHandler(this.label_close_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
            // 
            // label_name
            // 
            this.label_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_name.Font = new System.Drawing.Font("Comic Sans MS", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.label_name.Location = new System.Drawing.Point(0, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(1033, 80);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Інформаційна довідка";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_name_MouseDown);
            this.label_name.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_name_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(8)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 684);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
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
            this.panel2.Size = new System.Drawing.Size(1033, 80);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1528, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "x";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 95);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1009, 577);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 684);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label_close;
        public Label label_name;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private RichTextBox richTextBox1;
    }
}