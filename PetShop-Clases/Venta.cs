using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_Clases
{
    public class Venta : Producto
    {

        string dniCliente;
        double precioFinal;
        
        
        public string DniCliente
        {
            get { return dniCliente; }
            set { this.dniCliente = value; }
        }
        public double PrecioFinal
        {
            get { return precioFinal; }
            set { this.precioFinal = value; }
        }

        public Venta(string descripcion, int cantidad, double peso, double precio, string dni) : base(descripcion, cantidad, precio)
        {
            bool check = true;

            this.DniCliente = dni;
            this.Peso = peso;
            this.PrecioFinal = calculoPrecio(cantidad, precio);
        }

        public Venta (string descripcion,int cantidad, double precio, string dni):base(descripcion, cantidad, precio)
        {
            bool check = true;
            
            this.DniCliente = dni;
            this.Peso = buscarPeso(descripcion);
            this.PrecioFinal = calculoPrecio(cantidad, precio);
        }

        /// <summary>
        /// Establece el precio final del carrito de compras.
        /// </summary>
        /// <param name="lista">listado de productos en el carrito</param>
        /// <returns>Devuelve el precio final de los productos del carrito.</returns>
        public static double precioFinalCarrito(List<Producto> lista)
        {
            double precio = 0;

            foreach(Producto item in lista)
            {
                precio += item.Precio;
            }

            return precio;
        }

        /// <summary>
        /// Calcula el precio del producto en funcion del precio unitario y la cantidad de unidades.
        /// </summary>
        /// <param name="producto">Producto.</param>
        /// <returns>devuelve el precio.</returns>
        protected virtual double calculoPrecio (int cantidad, double precio)
        {

            return precio * cantidad;
            
        }

        private double calcularPeso(string descripcion, int cantidad)
        {
            List<Producto> lista = Colecciones.getListaProductos();

            foreach (Producto item in lista)
            {
                if (item.Descripcion.Equals(descripcion))
                {
                    item.Peso *= Cantidad;
                    return item.Peso;
                }
            }
            return 0;
        }
        
        protected override double buscarPeso(string descripcion)
        {
            
            List<Producto> lista = Colecciones.getCarrito();
            
            foreach (Producto item in lista)
            {
                if (item.Descripcion.Equals(descripcion))
                {
                    item.Peso *= item.Cantidad;
                    return item.Peso;
                }
            }
            return 0;
        }


        /// <summary>
        /// Crea un ticket con la última venta realizada.
        /// </summary>
        /// <param name="ventas">listado de venta.</param>
        public static void crearTicket(List<Venta> ventas)
        {
            string fileName = @"C:\Users\Usuario\source\repos\PetShop-Front\Ticket.txt";
            StringBuilder sb = new StringBuilder();

            
            
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            using (FileStream fs = File.Create(fileName))
            {
                sb.Append("Producto       ");
                sb.Append("Cantidad   ");
                sb.AppendLine("Precio");

                foreach (Venta item in ventas)
                {
                    sb.Append(item.Descripcion + "       ");
                    sb.Append(item.Cantidad.ToString() + "      ");
                    sb.AppendLine(item.precioFinal.ToString());
                }
                
                Byte[] ticket = new UTF8Encoding(true).GetBytes(sb.ToString());
                fs.Write(ticket);
            }

        }
    }
}
