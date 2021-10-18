using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop_Front
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void btnVerEmpleados_Click(object sender, EventArgs e)
        {
            frmVerEmpleados frmVerEmpleados = new frmVerEmpleados();
            frmVerEmpleados.Show();
        }

        private void btnAgregarEmpleados_Click(object sender, EventArgs e)
        {
            frmAgregarEmpleado frmAgregarEmpleado = new frmAgregarEmpleado();
            frmAgregarEmpleado.Show();
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            frmEditarEmpleado frmEditarEmpleado = new frmEditarEmpleado();
            frmEditarEmpleado.Show();
        }

        private void btnBorrarEmpleado_Click(object sender, EventArgs e)
        {
            frmBorrarEmpleado frmBorrarEmpleado = new frmBorrarEmpleado();
            frmBorrarEmpleado.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
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
