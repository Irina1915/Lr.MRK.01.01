namespace TextUsing
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
            this.components = new System.ComponentModel.Container();
            this.Ugaday_chislo = new System.Windows.Forms.Label();
            this.statistic = new System.Windows.Forms.RichTextBox();
            this.vvod = new System.Windows.Forms.TextBox();
            this.chislo = new System.Windows.Forms.Label();
            this.otschet = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Ugaday_chislo
            // 
            this.Ugaday_chislo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ugaday_chislo.AutoSize = true;
            this.Ugaday_chislo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ugaday_chislo.Location = new System.Drawing.Point(28, 25);
            this.Ugaday_chislo.Name = "Ugaday_chislo";
            this.Ugaday_chislo.Size = new System.Drawing.Size(145, 25);
            this.Ugaday_chislo.TabIndex = 0;
            this.Ugaday_chislo.Text = "Угадай число";
            // 
            // statistic
            // 
            this.statistic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statistic.Location = new System.Drawing.Point(33, 249);
            this.statistic.Name = "statistic";
            this.statistic.Size = new System.Drawing.Size(658, 74);
            this.statistic.TabIndex = 1;
            this.statistic.Text = "Ввывод статистики";
            // 
            // vvod
            // 
            this.vvod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vvod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.vvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vvod.Location = new System.Drawing.Point(409, 185);
            this.vvod.Name = "vvod";
            this.vvod.Size = new System.Drawing.Size(155, 26);
            this.vvod.TabIndex = 2;
            // 
            // chislo
            // 
            this.chislo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chislo.AutoSize = true;
            this.chislo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chislo.Location = new System.Drawing.Point(108, 186);
            this.chislo.Name = "chislo";
            this.chislo.Size = new System.Drawing.Size(283, 25);
            this.chislo.TabIndex = 3;
            this.chislo.Text = "Введите число от 1 до 100:";
            // 
            // otschet
            // 
            this.otschet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.otschet.AutoSize = true;
            this.otschet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otschet.Location = new System.Drawing.Point(333, 136);
            this.otschet.Name = "otschet";
            this.otschet.Size = new System.Drawing.Size(194, 25);
            this.otschet.TabIndex = 4;
            this.otschet.Text = "- обратный отсчет";
            // 
            // check
            // 
            this.check.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check.Location = new System.Drawing.Point(581, 12);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(110, 60);
            this.check.TabIndex = 5;
            this.check.Text = "Проверить";
            this.check.UseVisualStyleBackColor = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // time
            // 
            this.time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time.Location = new System.Drawing.Point(233, 135);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(94, 26);
            this.time.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(720, 346);
            this.Controls.Add(this.time);
            this.Controls.Add(this.check);
            this.Controls.Add(this.otschet);
            this.Controls.Add(this.chislo);
            this.Controls.Add(this.vvod);
            this.Controls.Add(this.statistic);
            this.Controls.Add(this.Ugaday_chislo);
            this.Name = "Form1";
            this.Text = "Проверка числа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ugaday_chislo;
        private System.Windows.Forms.RichTextBox statistic;
        private System.Windows.Forms.TextBox vvod;
        private System.Windows.Forms.Label chislo;
        private System.Windows.Forms.Label otschet;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.Timer timer1;
    }
}

