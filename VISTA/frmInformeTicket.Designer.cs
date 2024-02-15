namespace VISTA
{
    partial class frmInformeTicket
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            btnMinimizar = new Button();
            btnCerrar = new Button();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            SuspendLayout();
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = SystemColors.GradientInactiveCaption;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Location = new Point(736, 1);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(27, 22);
            btnMinimizar.TabIndex = 7;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.GradientInactiveCaption;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(769, 1);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(27, 22);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // chart2
            // 
            chart2.BackColor = SystemColors.GradientActiveCaption;
            chart2.BorderlineColor = Color.Violet;
            chartArea1.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart2.Legends.Add(legend1);
            chart2.Location = new Point(42, 82);
            chart2.Name = "chart2";
            chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            chart2.PaletteCustomColors = new Color[]
    {
    Color.Fuchsia
    };
            series1.BorderColor = Color.FromArgb(192, 255, 255);
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            chart2.Series.Add(series1);
            chart2.Size = new Size(708, 300);
            chart2.TabIndex = 9;
            chart2.Text = "chart2";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.GradientInactiveCaption;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Location = new Point(63, 29);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // frmInformeTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnActualizar);
            Controls.Add(chart2);
            Controls.Add(btnMinimizar);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInformeTicket";
            Text = "frmInformeTicket";
            Load += frmInformeTicket_Load;
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMinimizar;
        private Button btnCerrar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Button btnActualizar;
    }
}