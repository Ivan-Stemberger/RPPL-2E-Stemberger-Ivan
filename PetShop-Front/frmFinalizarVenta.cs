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
            
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {

            List<Producto> carrito = Colecciones.getCarrito();
            List<Venta> listaVenta = Colecciones.getListaVentas();
            List<Venta> current = new List<Venta>();
            Venta venta;
            double pago;

            try
            {
                if (Cliente.validarDni(txtDniCliente.Text))
                {
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

                        if (double.TryParse(txtPago.Text, out pago) && pago > Venta.precioFinalCarrito(Colecciones.getCarrito()))
                        {
                            double vuelto = pago - Venta.precioFinalCarrito(Colecciones.getCarrito());

                            StringBuilder sb = new StringBuilder();
                            sb.Append("La venta ha sido confirmada. Su vuelto es ");
                            sb.Append(vuelto.ToString());
                            MessageBox.Show(sb.ToString());
                            Venta.crearTicket(current);

                            this.Close();

                        }
                        else
                        {
                            ClienteSinDineroException exception = new ClienteSinDineroException();
                            throw exception;
                        }


                    }
                    else
                    {
                        ClientNotFoundException exception = new ClientNotFoundException();
                        throw exception;
                    }
                }
                else
                {
                    InvalidDniException exception = new InvalidDniException();
                    throw exception;
                }
            }
                
            catch(ClienteSinDineroException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ClientNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(InvalidDniException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFinalizarVenta_Load(object sender, EventArgs e)
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

            Envio envio = new Envio();

            lblTipoEnvio.Text = "Envio: " + envio.tipoEnvio.ToString();
            lblDistancia.Text = "Distancia: " + envio.Distancia.ToString();
            lblMonto.Text = "Monto del envio: " + envio.Precio.ToString();
            lblPrecioFinal.Text = (Venta.precioFinalCarrito(Colecciones.getCarrito()) + envio.Precio).ToString();

        }
    }
}
