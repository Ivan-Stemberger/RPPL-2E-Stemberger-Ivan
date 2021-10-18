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
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int cantidad;

            if(Producto.validarProducto(txtDescripcion.Text) && int.TryParse(txtCantidad.Text, out cantidad))
            {
                Colecciones.cargarCarrito(new Producto(txtDescripcion.Text, cantidad));
                
                txtDescripcion.Text = "";
                txtCantidad.Text = "";
            }
            else
            {
                MessageBox.Show("Error en la entrada de datos.");
            }


        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            
            frmFinalizarVenta frmFinalizarVenta = new frmFinalizarVenta();
            frmFinalizarVenta.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVenta_Load(object sender, EventArgs e)
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
