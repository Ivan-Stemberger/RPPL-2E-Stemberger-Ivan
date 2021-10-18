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
    public partial class frmVerClientes : Form
    {
        public frmVerClientes()
        {
            InitializeComponent();
            dtgvListaClientes.DataSource = Colecciones.getListaClientes();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVerClientes_Load(object sender, EventArgs e)
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
