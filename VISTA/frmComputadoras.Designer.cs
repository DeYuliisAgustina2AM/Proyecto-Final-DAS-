namespace VISTA
{
    partial class frmComputadoras
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
            dgvComputadoras = new DataGridView();
            btnMinimizar = new Button();
            btnCerrar = new Button();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvComputadoras).BeginInit();
            SuspendLayout();
            // 
            // dgvComputadoras
            // 
            dgvComputadoras.BackgroundColor = SystemColors.Info;
            dgvComputadoras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComputadoras.Location = new Point(12, 137);
            dgvComputadoras.Name = "dgvComputadoras";
            dgvComputadoras.Size = new Size(788, 301);
            dgvComputadoras.TabIndex = 0;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = SystemColors.GradientInactiveCaption;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Location = new Point(740, 1);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(27, 22);
            btnMinimizar.TabIndex = 7;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.GradientInactiveCaption;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(773, 1);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(27, 22);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.GradientInactiveCaption;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(13, 88);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(84, 34);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.GradientInactiveCaption;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Location = new Point(122, 88);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(73, 34);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.GradientInactiveCaption;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(220, 88);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(77, 34);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(284, 18);
            label1.Name = "label1";
            label1.Size = new Size(222, 25);
            label1.TabIndex = 11;
            label1.Text = "Gestionar Computadoras";
            // 
            // frmComputadoras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(815, 450);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(btnMinimizar);
            Controls.Add(btnCerrar);
            Controls.Add(dgvComputadoras);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmComputadoras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmComputadoras";
            ((System.ComponentModel.ISupportInitialize)dgvComputadoras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvComputadoras;
        private Button btnMinimizar;
        private Button btnCerrar;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label label1;
    }
}