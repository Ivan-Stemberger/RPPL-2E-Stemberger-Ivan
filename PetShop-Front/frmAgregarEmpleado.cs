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
    public partial class frmAgregarEmpleado : Form
    {
        public frmAgregarEmpleado()
        {
            InitializeComponent();
        }
        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            List<Usuario> listaEmpleados = Colecciones.getListaUsuarios();
            bool flag = false;

            foreach(Usuario item in listaEmpleados)
            {
                if(item.UserName.Equals(txtUsername.Text))
                {
                    MessageBox.Show("El usuario existe.");
                    flag = true;
                    break;
                }
                
            }
            
            if(!flag)
            {
                listaEmpleados.Add(new Usuario(txtNombre.Text, txtApellido.Text, txtUsername.Text, txtContraseña.Text));
                MessageBox.Show("El usuario fue creado correctamente.");
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtUsername.Text = "";
                txtContraseña.Text = "";
            }
            
        }

        private void frmAgregarEmpleado_Load(object sender, EventArgs e)
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
