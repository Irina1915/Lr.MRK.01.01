namespace Lr_grafic
{
    partial class LiveCharts
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listBoxFilm = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.pieChart = new LiveCharts.WinForms.PieChart();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFilm
            // 
            this.listBoxFilm.FormattingEnabled = true;
            this.listBoxFilm.Location = new System.Drawing.Point(3, -1);
            this.listBoxFilm.Name = "listBoxFilm";
            this.listBoxFilm.Size = new System.Drawing.Size(120, 446);
            this.listBoxFilm.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cartesianChart
            // 
            this.cartesianChart.Location = new System.Drawing.Point(129, 232);
            this.cartesianChart.Name = "cartesianChart";
            this.cartesianChart.Size = new System.Drawing.Size(659, 206);
            this.cartesianChart.TabIndex = 2;
            this.cartesianChart.Text = "cartesianChart";
            // 
            // pieChart
            // 
            this.pieChart.Location = new System.Drawing.Point(301, 41);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(296, 138);
            this.pieChart.TabIndex = 3;
            this.pieChart.Text = "pieChart";
            // 
            // LiveCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pieChart);
            this.Controls.Add(this.cartesianChart);
            this.Controls.Add(this.listBoxFilm);
            this.Name = "LiveCharts";
            this.Text = "LiveCharts - диаграммы";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox listBoxFilm;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private LiveCharts.WinForms.CartesianChart cartesianChart;
        private LiveCharts.WinForms.PieChart pieChart;
    }
}

