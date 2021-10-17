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
    public partial class frmNuevoCliente : Form
    {
        public frmNuevoCliente()
        {
            InitializeComponent();
            
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            
            Cliente cliente = new Cliente(txtName.Text, txtApellido.Text, txtDni.Text);

            if(cliente.Nombre != null && cliente.Apellido != null && cliente.Dni != null)
            {
                List<Cliente> lista = Colecciones.getListaClientes();
                lista.Add(cliente);
                MessageBox.Show("El cliente ha sido correctamente creado");
                txtName.Text = string.Empty;
                txtApellido.Text = string.Empty;
                txtDni.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Los datos introducidos no son válido.");
            }


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
