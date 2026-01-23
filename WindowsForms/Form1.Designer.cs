namespace WindowsForms
{
    partial class MainForm
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
            this.st1Lable = new System.Windows.Forms.Label();
            this.st2Lable = new System.Windows.Forms.Label();
            this.st_list = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_avg = new System.Windows.Forms.Label();
            this.label_num = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.fotoSt = new System.Windows.Forms.PictureBox();
            this.label_name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoSt)).BeginInit();
            this.SuspendLayout();
            // 
            // st1Lable
            // 
            this.st1Lable.AutoSize = true;
            this.st1Lable.Location = new System.Drawing.Point(337, 85);
            this.st1Lable.Name = "st1Lable";
            this.st1Lable.Size = new System.Drawing.Size(35, 13);
            this.st1Lable.TabIndex = 0;
            this.st1Lable.Text = "label1";
            // 
            // st2Lable
            // 
            this.st2Lable.AutoSize = true;
            this.st2Lable.Location = new System.Drawing.Point(451, 85);
            this.st2Lable.Name = "st2Lable";
            this.st2Lable.Size = new System.Drawing.Size(35, 13);
            this.st2Lable.TabIndex = 1;
            this.st2Lable.Text = "label2";
            // 
            // st_list
            // 
            this.st_list.Dock = System.Windows.Forms.DockStyle.Left;
            this.st_list.FormattingEnabled = true;
            this.st_list.Location = new System.Drawing.Point(0, 0);
            this.st_list.Name = "st_list";
            this.st_list.Size = new System.Drawing.Size(120, 450);
            this.st_list.TabIndex = 2;
            this.st_list.SelectedIndexChanged += new System.EventHandler(this.st_list_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Controls.Add(this.label_avg);
            this.panel1.Controls.Add(this.label_num);
            this.panel1.Controls.Add(this.label_age);
            this.panel1.Controls.Add(this.fotoSt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(120, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 450);
            this.panel1.TabIndex = 3;
            // 
            // label_avg
            // 
            this.label_avg.AutoSize = true;
            this.label_avg.Location = new System.Drawing.Point(217, 173);
            this.label_avg.Name = "label_avg";
            this.label_avg.Size = new System.Drawing.Size(35, 13);
            this.label_avg.TabIndex = 7;
            this.label_avg.Text = "label3";
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Location = new System.Drawing.Point(217, 131);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(35, 13);
            this.label_num.TabIndex = 6;
            this.label_num.Text = "label2";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Location = new System.Drawing.Point(217, 85);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(35, 13);
            this.label_age.TabIndex = 5;
            this.label_age.Text = "label1";
            // 
            // fotoSt
            // 
            this.fotoSt.Location = new System.Drawing.Point(33, 24);
            this.fotoSt.Name = "fotoSt";
            this.fotoSt.Size = new System.Drawing.Size(139, 197);
            this.fotoSt.TabIndex = 4;
            this.fotoSt.TabStop = false;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(220, 42);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 8;
            this.label_name.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.st_list);
            this.Controls.Add(this.st2Lable);
            this.Controls.Add(this.st1Lable);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoSt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label st1Lable;
        private System.Windows.Forms.Label st2Lable;
        private System.Windows.Forms.ListBox st_list;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox fotoSt;
        private System.Windows.Forms.Label label_avg;
        private System.Windows.Forms.Label label_num;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label_name;
    }
}

