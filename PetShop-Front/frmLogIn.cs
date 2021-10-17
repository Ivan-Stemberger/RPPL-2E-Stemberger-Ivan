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
    public partial class frmLogIn : Form
    {

        public frmLogIn()
        {
            InitializeComponent();
            Colecciones.cargarListas();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
            string usuario = txtUser.Text.ToUpper();
            string password = txtPassword.Text;


            List<Usuario> listaUsuarios = Colecciones.getListaUsuarios();
            
            if (!Usuario.confirmarcontraseña(listaUsuarios, password, usuario))
            {
                MessageBox.Show("El usuario o contraseña son incorrectos. Intente de nuevo.");
            }
            else 
            {
                if (!Usuario.confirmarRole(listaUsuarios, usuario))
                {
                    Form frmMenuEmpleado = new frmMenuEmpleado();
                    frmMenuEmpleado.Show();
                    txtUser.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                }
                else
                {
                    Form frmMenuAdmin = new FrmMenuAdmin();
                    frmMenuAdmin.ShowDialog();
                }
            }

        }
        
    }
}
