using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class frmCrearTicket : Form
    {
        public frmCrearTicket()
        {
            InitializeComponent();
        }

        private void frmCrearTicket_Load(object sender, EventArgs e)
        {
            cbUrgencia.Items.Add("Muy Alta");
            cbUrgencia.Items.Add("Alta");
            cbUrgencia.Items.Add("Media");
            cbUrgencia.Items.Add("Baja");
            cbUrgencia.Items.Add("Muy Baja");

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
