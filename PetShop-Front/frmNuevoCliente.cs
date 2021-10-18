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


            try
            {
                if (cliente.Nombre != null && cliente.Apellido != null && cliente.Dni != null)
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
                    CannotCreateClientException exception = new CannotCreateClientException();
                    throw exception;
                }
            }
            catch(CannotCreateClientException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNuevoCliente_Load(object sender, EventArgs e)
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
