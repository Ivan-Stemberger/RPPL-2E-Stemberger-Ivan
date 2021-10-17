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
    public partial class frmBorrarCliente : Form
    {
        public frmBorrarCliente()
        {
            InitializeComponent();
        }

        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            List<Cliente> lista = Colecciones.getListaClientes();

            foreach(Cliente item in lista)
            {
                if(item == textBox1.Text)
                {
                    lista.Remove(item);
                    MessageBox.Show("El cliente ha sido eliminado.");
                    break;
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
