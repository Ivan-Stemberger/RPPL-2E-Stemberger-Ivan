using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShop_Clases;

namespace PetShop_Front
{
    public partial class frmFinalizarVenta : Form
    {
        public frmFinalizarVenta()
        {
            InitializeComponent();
            dtgvVentas.DataSource = Colecciones.getCarrito();
            lblPrecioFinal.Text = Venta.precioFinalCarrito(Colecciones.getCarrito()).ToString();
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            
            List<Producto> carrito = Colecciones.getCarrito();
            List<Venta> listaVenta = Colecciones.getListaVentas();
            List<Venta> current = new List<Venta>();
            Venta venta;

            if (Cliente.buscarCliente(txtDniCliente.Text))
            {
                foreach (Producto item in carrito)
                {
                    if (!Producto.confirmarStock(item, Colecciones.getListaProductos()))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append("No hay stock suficiente de ");
                        sb.Append(item.Descripcion);

                        MessageBox.Show(sb.ToString());
                    }
                    else
                    {
                        
                        venta = new Venta(item.Descripcion, item.Cantidad, item.Precio, txtDniCliente.Text);
                        listaVenta.Add(venta);
                        current.Add(venta);
                        
                    }
                }
                    Venta.crearTicket(current);
                    MessageBox.Show("La venta ha sido confirmada.");
                    this.Close();
               
            }
            else
            {
                frmNuevoCliente frmNuevoCliente = new frmNuevoCliente();
                frmNuevoCliente.Show();
            }

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
