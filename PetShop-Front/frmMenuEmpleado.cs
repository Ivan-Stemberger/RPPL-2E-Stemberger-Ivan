using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PetShop_Front
{
    public partial class frmMenuEmpleado : Form
    {
        public frmMenuEmpleado()
        {
            InitializeComponent();
            
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            
            frmAltaCliente frmAltaCliente = new frmAltaCliente();
            frmAltaCliente.Show();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            
            frmVenta frmVenta = new frmVenta();
            frmVenta.Show();
        }

        private void frmMenuEmpleado_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Y <= 25 && e.X <=800)
            {
                menuStrip1.Visible = true;
            }
            else
            {
                menuStrip1.Visible = false;
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenuEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
           var result = MessageBox.Show("¿Está seguro de que desea salir?", "Log out", MessageBoxButtons.YesNo);

            if(result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmMenuEmpleado_Load(object sender, EventArgs e)
        {
           
        }

        
    }
}
