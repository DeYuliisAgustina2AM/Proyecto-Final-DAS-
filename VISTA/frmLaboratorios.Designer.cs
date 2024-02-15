namespace VISTA
{
    partial class frmLaboratorios
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
            dgvLaboratorios = new DataGridView();
            btnAgregar = new Button();
            btnMinimizar = new Button();
            btnCerrar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLaboratorios).BeginInit();
            SuspendLayout();
            // 
            // dgvLaboratorios
            // 
            dgvLaboratorios.BackgroundColor = SystemColors.Info;
            dgvLaboratorios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaboratorios.Location = new Point(14, 124);
            dgvLaboratorios.Name = "dgvLaboratorios";
            dgvLaboratorios.Size = new Size(749, 314);
            dgvLaboratorios.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.GradientInactiveCaption;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(20, 88);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(89, 30);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = SystemColors.GradientInactiveCaption;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Location = new Point(736, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(27, 22);
            btnMinimizar.TabIndex = 5;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.GradientInactiveCaption;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(769, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(27, 22);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.GradientInactiveCaption;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Location = new Point(126, 88);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(89, 30);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.GradientInactiveCaption;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(238, 88);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(89, 30);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(289, 21);
            label1.Name = "label1";
            label1.Size = new Size(204, 25);
            label1.TabIndex = 6;
            label1.Text = "Gestionar Laboratorios";
            // 
            // frmLaboratorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnMinimizar);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvLaboratorios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLaboratorios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestionar Laboratorios";
            ((System.ComponentModel.ISupportInitialize)dgvLaboratorios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLaboratorios;
        private Button btnAgregar;
        private Button btnMinimizar;
        private Button btnCerrar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label label1;
    }
}