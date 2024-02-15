namespace VISTA
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCerrar = new Button();
            btnLaboratorios = new Button();
            btnComputadoras = new Button();
            btnTickets = new Button();
            gbTicketMenu = new GroupBox();
            btnInformeTickets = new Button();
            btnHistorialTicket = new Button();
            btnCrearTicket = new Button();
            btnMinimizar = new Button();
            label1 = new Label();
            gbTicketMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.GradientInactiveCaption;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(404, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(27, 22);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnLaboratorios
            // 
            btnLaboratorios.BackColor = SystemColors.GradientInactiveCaption;
            btnLaboratorios.FlatStyle = FlatStyle.Flat;
            btnLaboratorios.ForeColor = SystemColors.ActiveCaptionText;
            btnLaboratorios.Location = new Point(124, 75);
            btnLaboratorios.Name = "btnLaboratorios";
            btnLaboratorios.Size = new Size(119, 48);
            btnLaboratorios.TabIndex = 1;
            btnLaboratorios.Text = "Gestionar Laboratorios";
            btnLaboratorios.UseVisualStyleBackColor = false;
            btnLaboratorios.Click += btnLaboratorios_Click;
            // 
            // btnComputadoras
            // 
            btnComputadoras.BackColor = SystemColors.GradientInactiveCaption;
            btnComputadoras.FlatStyle = FlatStyle.Flat;
            btnComputadoras.ForeColor = SystemColors.ActiveCaptionText;
            btnComputadoras.Location = new Point(124, 155);
            btnComputadoras.Name = "btnComputadoras";
            btnComputadoras.Size = new Size(119, 48);
            btnComputadoras.TabIndex = 1;
            btnComputadoras.Text = "Gestionar Computadoras";
            btnComputadoras.UseVisualStyleBackColor = false;
            btnComputadoras.Click += btnComputadoras_Click;
            // 
            // btnTickets
            // 
            btnTickets.BackColor = SystemColors.GradientInactiveCaption;
            btnTickets.FlatStyle = FlatStyle.Flat;
            btnTickets.ForeColor = SystemColors.ActiveCaptionText;
            btnTickets.Location = new Point(124, 238);
            btnTickets.Name = "btnTickets";
            btnTickets.Size = new Size(119, 48);
            btnTickets.TabIndex = 1;
            btnTickets.Text = "Gestionar Tickets";
            btnTickets.UseVisualStyleBackColor = false;
            btnTickets.Click += btnTickets_Click;
            // 
            // gbTicketMenu
            // 
            gbTicketMenu.BackColor = SystemColors.GradientInactiveCaption;
            gbTicketMenu.Controls.Add(btnInformeTickets);
            gbTicketMenu.Controls.Add(btnHistorialTicket);
            gbTicketMenu.Controls.Add(btnCrearTicket);
            gbTicketMenu.Location = new Point(249, 238);
            gbTicketMenu.Name = "gbTicketMenu";
            gbTicketMenu.Size = new Size(162, 129);
            gbTicketMenu.TabIndex = 2;
            gbTicketMenu.TabStop = false;
            // 
            // btnInformeTickets
            // 
            btnInformeTickets.BackColor = SystemColors.InactiveCaption;
            btnInformeTickets.FlatStyle = FlatStyle.Flat;
            btnInformeTickets.Location = new Point(49, 89);
            btnInformeTickets.Name = "btnInformeTickets";
            btnInformeTickets.Size = new Size(75, 25);
            btnInformeTickets.TabIndex = 1;
            btnInformeTickets.Text = "Informes";
            btnInformeTickets.UseVisualStyleBackColor = false;
            // 
            // btnHistorialTicket
            // 
            btnHistorialTicket.BackColor = SystemColors.InactiveCaption;
            btnHistorialTicket.FlatStyle = FlatStyle.Flat;
            btnHistorialTicket.Location = new Point(49, 48);
            btnHistorialTicket.Name = "btnHistorialTicket";
            btnHistorialTicket.Size = new Size(75, 25);
            btnHistorialTicket.TabIndex = 1;
            btnHistorialTicket.Text = "Historial";
            btnHistorialTicket.UseVisualStyleBackColor = false;
            // 
            // btnCrearTicket
            // 
            btnCrearTicket.BackColor = SystemColors.InactiveCaption;
            btnCrearTicket.FlatStyle = FlatStyle.Flat;
            btnCrearTicket.Location = new Point(49, 9);
            btnCrearTicket.Name = "btnCrearTicket";
            btnCrearTicket.Size = new Size(75, 25);
            btnCrearTicket.TabIndex = 0;
            btnCrearTicket.Text = "Crear";
            btnCrearTicket.UseVisualStyleBackColor = false;
            btnCrearTicket.Click += btnCrearTicket_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = SystemColors.GradientInactiveCaption;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Location = new Point(371, 2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(27, 22);
            btnMinimizar.TabIndex = 3;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(157, 19);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 4;
            label1.Text = "Menú";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(434, 450);
            Controls.Add(label1);
            Controls.Add(btnMinimizar);
            Controls.Add(gbTicketMenu);
            Controls.Add(btnTickets);
            Controls.Add(btnComputadoras);
            Controls.Add(btnLaboratorios);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú";
            Load += Menu_Load;
            gbTicketMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private Button btnLaboratorios;
        private Button btnComputadoras;
        private Button btnTickets;
        private GroupBox gbTicketMenu;
        private Button btnInformeTickets;
        private Button btnHistorialTicket;
        private Button btnCrearTicket;
        private Button btnMinimizar;
        private Label label1;
    }
}
