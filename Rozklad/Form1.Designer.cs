namespace Rozklad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startNewWeek_button = new System.Windows.Forms.Button();
            this.saveTimetable_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.weeklyGradesTextBox = new System.Windows.Forms.TextBox();
            this.monthlyGradesTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.finalMonthlyGradesLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.currentWeekNumberLabel = new System.Windows.Forms.Label();
            this.mondayTimetable = new System.Windows.Forms.RichTextBox();
            this.tuesdayTimetable = new System.Windows.Forms.RichTextBox();
            this.wednesdayTimetable = new System.Windows.Forms.RichTextBox();
            this.thursdayTimetable = new System.Windows.Forms.RichTextBox();
            this.fridayTimetable = new System.Windows.Forms.RichTextBox();
            this.saturdayTimetable = new System.Windows.Forms.RichTextBox();
            this.closeProgram_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startNewWeek_button
            // 
            this.startNewWeek_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startNewWeek_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startNewWeek_button.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startNewWeek_button.Location = new System.Drawing.Point(341, 177);
            this.startNewWeek_button.Name = "startNewWeek_button";
            this.startNewWeek_button.Size = new System.Drawing.Size(120, 23);
            this.startNewWeek_button.TabIndex = 0;
            this.startNewWeek_button.Text = "Done";
            this.startNewWeek_button.UseVisualStyleBackColor = true;
            this.startNewWeek_button.Click += new System.EventHandler(this.StartNewWeek_button_Click);
            // 
            // saveTimetable_button
            // 
            this.saveTimetable_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveTimetable_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveTimetable_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.saveTimetable_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.saveTimetable_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveTimetable_button.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveTimetable_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveTimetable_button.Location = new System.Drawing.Point(195, 458);
            this.saveTimetable_button.Name = "saveTimetable_button";
            this.saveTimetable_button.Size = new System.Drawing.Size(75, 23);
            this.saveTimetable_button.TabIndex = 1;
            this.saveTimetable_button.Text = "Зберегти";
            this.saveTimetable_button.UseVisualStyleBackColor = true;
            this.saveTimetable_button.Click += new System.EventHandler(this.SaveTimetable_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(24, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Понеділок:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(33, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Вівторок:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(37, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Середа:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Location = new System.Drawing.Point(44, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Четвер:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Location = new System.Drawing.Point(36, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "П\'ятниця:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label6.Location = new System.Drawing.Point(41, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Субота:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(29, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "РОЗКЛАД";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkedListBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox1.Items.AddRange(new object[] {
            "Понеділок",
            "Вівторок",
            "Середа",
            "Четвер",
            "П\'ятниця",
            "Субота"});
            this.checkedListBox1.Location = new System.Drawing.Point(341, 71);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 96);
            this.checkedListBox1.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, -7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(9, 520);
            this.label8.TabIndex = 20;
            this.label8.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n" +
    "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(336, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "КОНТРОЛЬ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(344, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Кількість балів";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.Info;
            this.label11.Location = new System.Drawing.Point(323, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Тиждень (мин.):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.Info;
            this.label12.Location = new System.Drawing.Point(370, 336);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Місяць:";
            // 
            // weeklyGradesTextBox
            // 
            this.weeklyGradesTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weeklyGradesTextBox.Location = new System.Drawing.Point(420, 312);
            this.weeklyGradesTextBox.Name = "weeklyGradesTextBox";
            this.weeklyGradesTextBox.ReadOnly = true;
            this.weeklyGradesTextBox.Size = new System.Drawing.Size(27, 21);
            this.weeklyGradesTextBox.TabIndex = 25;
            this.weeklyGradesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // monthlyGradesTextBox
            // 
            this.monthlyGradesTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthlyGradesTextBox.Location = new System.Drawing.Point(420, 334);
            this.monthlyGradesTextBox.Name = "monthlyGradesTextBox";
            this.monthlyGradesTextBox.ReadOnly = true;
            this.monthlyGradesTextBox.Size = new System.Drawing.Size(27, 21);
            this.monthlyGradesTextBox.TabIndex = 26;
            this.monthlyGradesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.Info;
            this.label13.Location = new System.Drawing.Point(452, 315);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "/6";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.SystemColors.Info;
            this.label14.Location = new System.Drawing.Point(452, 337);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "/24";
            // 
            // finalMonthlyGradesLabel
            // 
            this.finalMonthlyGradesLabel.AutoSize = true;
            this.finalMonthlyGradesLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finalMonthlyGradesLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.finalMonthlyGradesLabel.Location = new System.Drawing.Point(434, 367);
            this.finalMonthlyGradesLabel.Name = "finalMonthlyGradesLabel";
            this.finalMonthlyGradesLabel.Size = new System.Drawing.Size(14, 16);
            this.finalMonthlyGradesLabel.TabIndex = 29;
            this.finalMonthlyGradesLabel.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.SystemColors.Info;
            this.label16.Location = new System.Drawing.Point(362, 204);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 16);
            this.label16.TabIndex = 30;
            this.label16.Text = "Тиждень";
            // 
            // currentWeekNumberLabel
            // 
            this.currentWeekNumberLabel.AutoSize = true;
            this.currentWeekNumberLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.currentWeekNumberLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentWeekNumberLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.currentWeekNumberLabel.Location = new System.Drawing.Point(420, 204);
            this.currentWeekNumberLabel.Name = "currentWeekNumberLabel";
            this.currentWeekNumberLabel.Size = new System.Drawing.Size(15, 16);
            this.currentWeekNumberLabel.TabIndex = 31;
            this.currentWeekNumberLabel.Text = "1";
            // 
            // mondayTimetable
            // 
            this.mondayTimetable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mondayTimetable.Location = new System.Drawing.Point(95, 73);
            this.mondayTimetable.Name = "mondayTimetable";
            this.mondayTimetable.Size = new System.Drawing.Size(175, 43);
            this.mondayTimetable.TabIndex = 32;
            this.mondayTimetable.Text = "Нічого\nнічого\n";
            // 
            // tuesdayTimetable
            // 
            this.tuesdayTimetable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tuesdayTimetable.Location = new System.Drawing.Point(95, 136);
            this.tuesdayTimetable.Name = "tuesdayTimetable";
            this.tuesdayTimetable.Size = new System.Drawing.Size(175, 43);
            this.tuesdayTimetable.TabIndex = 33;
            this.tuesdayTimetable.Text = "Нічого\nнічого\n";
            // 
            // wednesdayTimetable
            // 
            this.wednesdayTimetable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wednesdayTimetable.Location = new System.Drawing.Point(95, 200);
            this.wednesdayTimetable.Name = "wednesdayTimetable";
            this.wednesdayTimetable.Size = new System.Drawing.Size(175, 43);
            this.wednesdayTimetable.TabIndex = 34;
            this.wednesdayTimetable.Text = "Нічого\nнічого\n";
            // 
            // thursdayTimetable
            // 
            this.thursdayTimetable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.thursdayTimetable.Location = new System.Drawing.Point(95, 264);
            this.thursdayTimetable.Name = "thursdayTimetable";
            this.thursdayTimetable.Size = new System.Drawing.Size(175, 43);
            this.thursdayTimetable.TabIndex = 35;
            this.thursdayTimetable.Text = "Нічого\nнічого\n";
            // 
            // fridayTimetable
            // 
            this.fridayTimetable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fridayTimetable.Location = new System.Drawing.Point(95, 328);
            this.fridayTimetable.Name = "fridayTimetable";
            this.fridayTimetable.Size = new System.Drawing.Size(175, 43);
            this.fridayTimetable.TabIndex = 36;
            this.fridayTimetable.Text = "Нічого\nнічого\n";
            // 
            // saturdayTimetable
            // 
            this.saturdayTimetable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.saturdayTimetable.Location = new System.Drawing.Point(95, 390);
            this.saturdayTimetable.Name = "saturdayTimetable";
            this.saturdayTimetable.Size = new System.Drawing.Size(175, 43);
            this.saturdayTimetable.TabIndex = 37;
            this.saturdayTimetable.Text = "Нічого\nнічого\n";
            // 
            // closeProgram_button
            // 
            this.closeProgram_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeProgram_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeProgram_button.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeProgram_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeProgram_button.Location = new System.Drawing.Point(397, 458);
            this.closeProgram_button.Name = "closeProgram_button";
            this.closeProgram_button.Size = new System.Drawing.Size(75, 23);
            this.closeProgram_button.TabIndex = 38;
            this.closeProgram_button.Text = "ВИЙТИ";
            this.closeProgram_button.UseVisualStyleBackColor = true;
            this.closeProgram_button.Click += new System.EventHandler(this.CloseProgram_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(501, 509);
            this.Controls.Add(this.closeProgram_button);
            this.Controls.Add(this.saturdayTimetable);
            this.Controls.Add(this.fridayTimetable);
            this.Controls.Add(this.thursdayTimetable);
            this.Controls.Add(this.wednesdayTimetable);
            this.Controls.Add(this.tuesdayTimetable);
            this.Controls.Add(this.mondayTimetable);
            this.Controls.Add(this.currentWeekNumberLabel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.finalMonthlyGradesLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.monthlyGradesTextBox);
            this.Controls.Add(this.weeklyGradesTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveTimetable_button);
            this.Controls.Add(this.startNewWeek_button);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StudContra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startNewWeek_button;
        private System.Windows.Forms.Button saveTimetable_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox weeklyGradesTextBox;
        public System.Windows.Forms.TextBox monthlyGradesTextBox;
        public System.Windows.Forms.Label finalMonthlyGradesLabel;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label currentWeekNumberLabel;
        public System.Windows.Forms.RichTextBox mondayTimetable;
        public System.Windows.Forms.RichTextBox tuesdayTimetable;
        public System.Windows.Forms.RichTextBox wednesdayTimetable;
        public System.Windows.Forms.RichTextBox thursdayTimetable;
        public System.Windows.Forms.RichTextBox fridayTimetable;
        public System.Windows.Forms.RichTextBox saturdayTimetable;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button closeProgram_button;
        public System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

