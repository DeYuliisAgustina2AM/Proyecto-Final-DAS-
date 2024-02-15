namespace VISTA
{
    partial class frmCrearTicket
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
            btnCrear = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbUrgencia = new ComboBox();
            cbUbicacion = new ComboBox();
            txtCondicion = new TextBox();
            cbCodigoPC = new ComboBox();
            btnMinimizar = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(117, 397);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 5;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(271, 397);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(147, 28);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 2;
            label1.Text = "Crear Ticket";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 132);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Codigo PC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 274);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 4;
            label3.Text = "Condición";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 203);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 5;
            label4.Text = "Urgencia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 63);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 6;
            label5.Text = "Ubicación";
            // 
            // cbUrgencia
            // 
            cbUrgencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUrgencia.FormattingEnabled = true;
            cbUrgencia.Location = new Point(37, 221);
            cbUrgencia.Name = "cbUrgencia";
            cbUrgencia.Size = new Size(121, 23);
            cbUrgencia.TabIndex = 3;
            // 
            // cbUbicacion
            // 
            cbUbicacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUbicacion.FormattingEnabled = true;
            cbUbicacion.Location = new Point(37, 81);
            cbUbicacion.Name = "cbUbicacion";
            cbUbicacion.Size = new Size(121, 23);
            cbUbicacion.TabIndex = 1;
            // 
            // txtCondicion
            // 
            txtCondicion.Location = new Point(37, 293);
            txtCondicion.Multiline = true;
            txtCondicion.Name = "txtCondicion";
            txtCondicion.Size = new Size(293, 66);
            txtCondicion.TabIndex = 4;
            // 
            // cbCodigoPC
            // 
            cbCodigoPC.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCodigoPC.FormattingEnabled = true;
            cbCodigoPC.Location = new Point(37, 150);
            cbCodigoPC.Name = "cbCodigoPC";
            cbCodigoPC.Size = new Size(121, 23);
            cbCodigoPC.TabIndex = 2;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = SystemColors.GradientInactiveCaption;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Location = new Point(371, 2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(27, 22);
            btnMinimizar.TabIndex = 8;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.GradientInactiveCaption;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(404, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(27, 22);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmCrearTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(433, 432);
            Controls.Add(btnMinimizar);
            Controls.Add(btnCerrar);
            Controls.Add(cbCodigoPC);
            Controls.Add(txtCondicion);
            Controls.Add(cbUbicacion);
            Controls.Add(cbUrgencia);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnCrear);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCrearTicket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCrearTicket";
            Load += frmCrearTicket_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrear;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbUrgencia;
        private ComboBox cbUbicacion;
        private TextBox txtCondicion;
        private ComboBox cbCodigoPC;
        private Button btnMinimizar;
        private Button btnCerrar;
    }
}