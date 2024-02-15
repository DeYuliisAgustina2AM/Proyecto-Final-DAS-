namespace VISTA
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            gbTicketMenu.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLaboratorios_Click(object sender, EventArgs e)
        {

        }

        private void btnComputadoras_Click(object sender, EventArgs e)
        {

        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            if (gbTicketMenu.Visible)
            {
                gbTicketMenu.Hide();
            }
            else
            {
                gbTicketMenu.Show();
            }
        }

        private void btnCrearTicket_Click(object sender, EventArgs e)
        {
            frmCrearTicket crearTicket = new frmCrearTicket();
            crearTicket.Show();
            this.Hide();
        }
    }
}
