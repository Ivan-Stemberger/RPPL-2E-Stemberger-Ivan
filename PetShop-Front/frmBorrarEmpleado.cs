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
    public partial class frmBorrarEmpleado : Form
    {
        public frmBorrarEmpleado()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string datos;
            
            if(Usuario.buscarEmpleado(txtUserName.Text))
            {
                datos = Usuario.datosEmpleado(txtUserName.Text);
                var result = MessageBox.Show(datos,"Confirmar accion",MessageBoxButtons.OKCancel);

                if(result == DialogResult.OK)
                {
                    Usuario.eliminarUsuario(txtUserName.Text);
                }
            }
        }

        private void frmBorrarEmpleado_Load(object sender, EventArgs e)
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
