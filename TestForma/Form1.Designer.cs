namespace TestForma
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
            this.labelParol = new System.Windows.Forms.Label();
            this.Vhod = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxParol = new System.Windows.Forms.TextBox();
            this.comboBoxLogin = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelParol
            // 
            this.labelParol.AutoSize = true;
            this.labelParol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelParol.Location = new System.Drawing.Point(23, 86);
            this.labelParol.Name = "labelParol";
            this.labelParol.Size = new System.Drawing.Size(139, 20);
            this.labelParol.TabIndex = 0;
            this.labelParol.Text = "Введите пароль:";
            // 
            // Vhod
            // 
            this.Vhod.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Vhod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vhod.Location = new System.Drawing.Point(333, 154);
            this.Vhod.Name = "Vhod";
            this.Vhod.Size = new System.Drawing.Size(101, 49);
            this.Vhod.TabIndex = 1;
            this.Vhod.Text = "Войти";
            this.Vhod.UseVisualStyleBackColor = false;
            this.Vhod.Click += new System.EventHandler(this.Vhod_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(24, 42);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(128, 20);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Введите логин:";
            // 
            // textBoxParol
            // 
            this.textBoxParol.Location = new System.Drawing.Point(200, 85);
            this.textBoxParol.Name = "textBoxParol";
            this.textBoxParol.Size = new System.Drawing.Size(234, 20);
            this.textBoxParol.TabIndex = 4;
            // 
            // comboBoxLogin
            // 
            this.comboBoxLogin.FormattingEnabled = true;
            this.comboBoxLogin.Location = new System.Drawing.Point(200, 42);
            this.comboBoxLogin.Name = "comboBoxLogin";
            this.comboBoxLogin.Size = new System.Drawing.Size(234, 21);
            this.comboBoxLogin.TabIndex = 5;
            this.comboBoxLogin.SelectedIndexChanged += new System.EventHandler(this.comboBoxLogin_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(480, 228);
            this.Controls.Add(this.comboBoxLogin);
            this.Controls.Add(this.textBoxParol);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.Vhod);
            this.Controls.Add(this.labelParol);
            this.Name = "Form1";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelParol;
        private System.Windows.Forms.Button Vhod;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxParol;
        private System.Windows.Forms.ComboBox comboBoxLogin;
    }
}

