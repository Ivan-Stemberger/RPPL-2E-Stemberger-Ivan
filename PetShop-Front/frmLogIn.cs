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

            try
            {
                if (!Usuario.confirmarcontraseña(listaUsuarios, password, usuario))
                {
                    UsuarioInvalidoException exception = new UsuarioInvalidoException();
                    throw exception;
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
            catch(UsuarioInvalidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void frmLogIn_Load(object sender, EventArgs e)
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
