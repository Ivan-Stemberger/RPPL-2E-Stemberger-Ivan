using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShop_Clases;

namespace PetShop_Front
{
    public partial class frmAltaCliente : Form
    {
        public frmAltaCliente()
        {
            InitializeComponent();
        }

        

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            frmNuevoCliente frmNuevoCliente = new frmNuevoCliente();
            frmNuevoCliente.Show();
        }

        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            frmBorrarCliente frmBorrarCliente = new frmBorrarCliente();
            frmBorrarCliente.Show();    
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            frmVerClientes verClientes = new frmVerClientes();
            verClientes.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAltaCliente_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = Color.LightSeaGreen;
                }
                else if (control is MenuStrip)
                {
                    control.BackColor = Color.Cyan;
                }
                else if (control is CheckBox)
                {
                    control.BackColor = Color.LightBlue;
                }
            }
        }
    }
}
