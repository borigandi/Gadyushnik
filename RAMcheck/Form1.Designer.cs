namespace RAMdetect
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CheckSelectedProcessRAM_Button = new System.Windows.Forms.Button();
            this.CheckAllProcessesRAM_Button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RefreshProcessesList_Button = new System.Windows.Forms.Button();
            this.KillSelectedProcess_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.getInfoLoop_CheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckSelectedProcessRAM_Button
            // 
            this.CheckSelectedProcessRAM_Button.BackColor = System.Drawing.Color.OldLace;
            this.CheckSelectedProcessRAM_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CheckSelectedProcessRAM_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckSelectedProcessRAM_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckSelectedProcessRAM_Button.Font = new System.Drawing.Font("Kievit Offc Pro", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckSelectedProcessRAM_Button.Location = new System.Drawing.Point(19, 74);
            this.CheckSelectedProcessRAM_Button.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CheckSelectedProcessRAM_Button.Name = "CheckSelectedProcessRAM_Button";
            this.CheckSelectedProcessRAM_Button.Size = new System.Drawing.Size(106, 23);
            this.CheckSelectedProcessRAM_Button.TabIndex = 0;
            this.CheckSelectedProcessRAM_Button.Text = "Check";
            this.CheckSelectedProcessRAM_Button.UseVisualStyleBackColor = false;
            this.CheckSelectedProcessRAM_Button.Click += new System.EventHandler(this.CheckSelectedProcessRAM_Button_Click);
            // 
            // CheckAllProcessesRAM_Button
            // 
            this.CheckAllProcessesRAM_Button.BackColor = System.Drawing.Color.Gold;
            this.CheckAllProcessesRAM_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckAllProcessesRAM_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckAllProcessesRAM_Button.Font = new System.Drawing.Font("Kievit Offc Pro", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckAllProcessesRAM_Button.Location = new System.Drawing.Point(124, 74);
            this.CheckAllProcessesRAM_Button.Name = "CheckAllProcessesRAM_Button";
            this.CheckAllProcessesRAM_Button.Size = new System.Drawing.Size(60, 23);
            this.CheckAllProcessesRAM_Button.TabIndex = 2;
            this.CheckAllProcessesRAM_Button.Text = "All";
            this.CheckAllProcessesRAM_Button.UseVisualStyleBackColor = false;
            this.CheckAllProcessesRAM_Button.Click += new System.EventHandler(this.CheckAllProcessesRAM_Button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Goldenrod;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Kievit Offc Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(48, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 23);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.OldLace;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Kievit Offc Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(19, 103);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(184, 59);
            this.listBox1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RAMdetect.Properties.Resources.kisspng_cookie_monster_biscuits_clip_art_big_bird_frankens_5cc70722c029e11;
            this.pictureBox1.Location = new System.Drawing.Point(209, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // RefreshProcessesList_Button
            // 
            this.RefreshProcessesList_Button.BackColor = System.Drawing.Color.White;
            this.RefreshProcessesList_Button.BackgroundImage = global::RAMdetect.Properties.Resources._46520;
            this.RefreshProcessesList_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshProcessesList_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshProcessesList_Button.FlatAppearance.BorderSize = 0;
            this.RefreshProcessesList_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshProcessesList_Button.Location = new System.Drawing.Point(19, 43);
            this.RefreshProcessesList_Button.Name = "RefreshProcessesList_Button";
            this.RefreshProcessesList_Button.Size = new System.Drawing.Size(23, 23);
            this.RefreshProcessesList_Button.TabIndex = 5;
            this.RefreshProcessesList_Button.UseVisualStyleBackColor = false;
            this.RefreshProcessesList_Button.Click += new System.EventHandler(this.RefreshProcessesList_Button_Click);
            // 
            // KillSelectedProcess_Button
            // 
            this.KillSelectedProcess_Button.BackgroundImage = global::RAMdetect.Properties.Resources.skull_crossbones_i7800;
            this.KillSelectedProcess_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KillSelectedProcess_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KillSelectedProcess_Button.FlatAppearance.BorderSize = 0;
            this.KillSelectedProcess_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.KillSelectedProcess_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KillSelectedProcess_Button.Font = new System.Drawing.Font("Kievit Offc Pro", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KillSelectedProcess_Button.ForeColor = System.Drawing.Color.Red;
            this.KillSelectedProcess_Button.Location = new System.Drawing.Point(180, 43);
            this.KillSelectedProcess_Button.Name = "KillSelectedProcess_Button";
            this.KillSelectedProcess_Button.Size = new System.Drawing.Size(23, 23);
            this.KillSelectedProcess_Button.TabIndex = 4;
            this.KillSelectedProcess_Button.UseVisualStyleBackColor = false;
            this.KillSelectedProcess_Button.Click += new System.EventHandler(this.KillSelectedProcess_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kievit Offc Pro", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Processes: 0";
            // 
            // getInfoLoop_CheckBox
            // 
            this.getInfoLoop_CheckBox.AutoSize = true;
            this.getInfoLoop_CheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getInfoLoop_CheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.getInfoLoop_CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getInfoLoop_CheckBox.Font = new System.Drawing.Font("Kievit Offc Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getInfoLoop_CheckBox.Location = new System.Drawing.Point(190, 77);
            this.getInfoLoop_CheckBox.Name = "getInfoLoop_CheckBox";
            this.getInfoLoop_CheckBox.Size = new System.Drawing.Size(13, 12);
            this.getInfoLoop_CheckBox.TabIndex = 9;
            this.getInfoLoop_CheckBox.UseVisualStyleBackColor = true;
            this.getInfoLoop_CheckBox.CheckedChanged += new System.EventHandler(this.GetInfoLoop_CheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(331, 179);
            this.Controls.Add(this.getInfoLoop_CheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.RefreshProcessesList_Button);
            this.Controls.Add(this.KillSelectedProcess_Button);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CheckAllProcessesRAM_Button);
            this.Controls.Add(this.CheckSelectedProcessRAM_Button);
            this.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RAMcheck";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckSelectedProcessRAM_Button;
        public System.Windows.Forms.Button CheckAllProcessesRAM_Button;
        public System.Windows.Forms.Button KillSelectedProcess_Button;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button RefreshProcessesList_Button;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox getInfoLoop_CheckBox;
    }
}

