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
    public partial class frmEditarEmpleado : Form
    {
        public frmEditarEmpleado()
        {
            InitializeComponent();
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            List<Usuario> empleados = Colecciones.getListaUsuarios();

            foreach(Usuario item in empleados)
            {
                if(item.UserName.Equals(txtUserName.Text))
                {
                    txtNombre.Text = item.Nombre;
                    txtApellido.Text = item.Apellido;
                }
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            List<Usuario> listaEmpleados = Colecciones.getListaUsuarios();
            

            foreach (Usuario item in listaEmpleados)
            {
                if(item.UserName.Equals(txtUserName.Text))
                {
                    item.Nombre = txtNombre.Text;
                    item.Apellido = txtApellido.Text;
                    item.UserName = txtUserName.Text;

                    MessageBox.Show("El usuario fue modificado correctamente.");
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtUserName.Text = "";
                    break;
                }
                

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
