using System.Data;

namespace PlusBase
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.button_tren = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_tools = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.label_login = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label_close = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(8)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.button_edit);
            this.panel1.Controls.Add(this.button_del);
            this.panel1.Controls.Add(this.button_tren);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.textBox_search);
            this.panel1.Controls.Add(this.button_search);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 691);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView.Location = new System.Drawing.Point(14, 182);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.Size = new System.Drawing.Size(861, 388);
            this.dataGridView.TabIndex = 20;
            this.dataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDown);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(37)))));
            this.button_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_edit.FlatAppearance.BorderSize = 0;
            this.button_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(20)))));
            this.button_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(96)))), ((int)(((byte)(58)))));
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_edit.ForeColor = System.Drawing.Color.White;
            this.button_edit.Location = new System.Drawing.Point(592, 580);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(283, 47);
            this.button_edit.TabIndex = 18;
            this.button_edit.Text = "Редагувати слово";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_del
            // 
            this.button_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(37)))));
            this.button_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_del.FlatAppearance.BorderSize = 0;
            this.button_del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(20)))));
            this.button_del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(96)))), ((int)(((byte)(58)))));
            this.button_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_del.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_del.ForeColor = System.Drawing.Color.White;
            this.button_del.Location = new System.Drawing.Point(303, 580);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(283, 47);
            this.button_del.TabIndex = 17;
            this.button_del.Text = "Видалити слово";
            this.button_del.UseVisualStyleBackColor = false;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_tren
            // 
            this.button_tren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(37)))));
            this.button_tren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_tren.FlatAppearance.BorderSize = 0;
            this.button_tren.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(20)))));
            this.button_tren.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(96)))), ((int)(((byte)(58)))));
            this.button_tren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tren.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_tren.ForeColor = System.Drawing.Color.White;
            this.button_tren.Location = new System.Drawing.Point(14, 633);
            this.button_tren.Name = "button_tren";
            this.button_tren.Size = new System.Drawing.Size(861, 47);
            this.button_tren.TabIndex = 16;
            this.button_tren.Text = "Перейти до тренувань";
            this.button_tren.UseVisualStyleBackColor = false;
            this.button_tren.Click += new System.EventHandler(this.button_tren_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(37)))));
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(20)))));
            this.button_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(96)))), ((int)(((byte)(58)))));
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(14, 580);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(283, 47);
            this.button_add.TabIndex = 15;
            this.button_add.Text = "Додати нове слово";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_search.Location = new System.Drawing.Point(14, 116);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(729, 56);
            this.textBox_search.TabIndex = 0;
            this.textBox_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_search_KeyDown);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(37)))));
            this.button_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(20)))));
            this.button_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(96)))), ((int)(((byte)(58)))));
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(749, 116);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(126, 56);
            this.button_search.TabIndex = 4;
            this.button_search.Text = "Пошук";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(79)))));
            this.panel2.Controls.Add(this.label_info);
            this.panel2.Controls.Add(this.label_tools);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button_exit);
            this.panel2.Controls.Add(this.label_login);
            this.panel2.Controls.Add(this.label_title);
            this.panel2.Controls.Add(this.label_close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(890, 104);
            this.panel2.TabIndex = 0;
            // 
            // label_tools
            // 
            this.label_tools.AutoSize = true;
            this.label_tools.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_tools.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_tools.ForeColor = System.Drawing.Color.White;
            this.label_tools.Location = new System.Drawing.Point(104, 61);
            this.label_tools.Name = "label_tools";
            this.label_tools.Size = new System.Drawing.Size(159, 29);
            this.label_tools.TabIndex = 16;
            this.label_tools.Text = "Налаштування";
            this.label_tools.Click += new System.EventHandler(this.label_tools_Click);
            this.label_tools.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_tools_MouseDown);
            this.label_tools.MouseEnter += new System.EventHandler(this.label_tools_MouseEnter);
            this.label_tools.MouseLeave += new System.EventHandler(this.label_tools_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlusBase.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(858, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 35);
            this.label1.TabIndex = 21;
            this.label1.Text = "x";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(61)))), ((int)(((byte)(37)))));
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(34)))), ((int)(((byte)(20)))));
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(96)))), ((int)(((byte)(58)))));
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(14, 58);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(84, 37);
            this.button_exit.TabIndex = 20;
            this.button_exit.Text = "Вийти";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_login.ForeColor = System.Drawing.Color.White;
            this.label_login.Location = new System.Drawing.Point(65, 19);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(69, 29);
            this.label_login.TabIndex = 10;
            this.label_login.Text = "Логін";
            // 
            // label_title
            // 
            this.label_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_title.Font = new System.Drawing.Font("Comic Sans MS", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.label_title.Location = new System.Drawing.Point(0, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(890, 104);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Словник";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_title_MouseDown);
            this.label_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_title_MouseMove);
            // 
            // label_close
            // 
            this.label_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_close.AutoSize = true;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_close.ForeColor = System.Drawing.Color.White;
            this.label_close.Location = new System.Drawing.Point(1212, 0);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(29, 35);
            this.label_close.TabIndex = 1;
            this.label_close.Text = "x";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_info.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_info.ForeColor = System.Drawing.Color.White;
            this.label_info.Location = new System.Drawing.Point(641, 61);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(237, 29);
            this.label_info.TabIndex = 23;
            this.label_info.Text = "Інформаційна довідка";
            this.label_info.Click += new System.EventHandler(this.label_info_Click);
            this.label_info.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_info_MouseDown);
            this.label_info.MouseEnter += new System.EventHandler(this.label_info_MouseEnter);
            this.label_info.MouseLeave += new System.EventHandler(this.label_info_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 691);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private Panel panel1;
        public Label label_login;
        private TextBox textBox_search;
        private Button button_search;
        private Panel panel2;
        private Label label_close;
        private Label label_title;
        private DataGridView dataGridView;
        private Button button_edit;
        private Button button_del;
        private Button button_tren;
        private Button button_add;
        private Button button_exit;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label_tools;
        private Label label_info;
    }
}