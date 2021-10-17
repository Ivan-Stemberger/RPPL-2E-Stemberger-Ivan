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
        float precioFinal;
        public enum Eenvio { moto, miniflete};
        public Eenvio envio;

        public string DniCliente
        {
            get { return dniCliente; }
            set { this.dniCliente = value; }
        }
        public float PrecioFinal
        {
            get { return precioFinal; }
            set { this.precioFinal = value; }
        }

        public Venta(string descripcion, ETipo tipo, int cantidad, float precio, string dni):base(descripcion, tipo, cantidad, precio)
        {
            this.DniCliente = dni;
            this.PrecioFinal = calculoPrecio(cantidad, precio);
            this.envio = definirEnvio(this.Peso);
        }


        public Venta (string descripcion,int cantidad, float precio, string dni):base(descripcion, cantidad, precio)
        {
            this.DniCliente = dni;
            this.PrecioFinal = calculoPrecio(cantidad,precio);
            this.envio = definirEnvio(this.Peso);
        }

        /// <summary>
        /// Establece el precio final del carrito de compras.
        /// </summary>
        /// <param name="lista">listado de productos en el carrito</param>
        /// <returns>Devuelve el precio final de los productos del carrito.</returns>
        public static float precioFinalCarrito(List<Producto> lista)
        {
            float precio = 0;

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
        protected virtual float calculoPrecio (int cantidad, float precio)
        {
            return precio * cantidad;
            
        }

        protected override float buscarPeso(string descripcion)
        {
            float peso = 0;
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

        public float pesoFinal(string descripcion)
        {
            float peso = 0;

            peso = +buscarPeso(descripcion);

            return peso;
        }

        public Eenvio definirEnvio(float peso)
        {
            if(peso >30)
            {
                return Eenvio.miniflete;
            }
            else
            {
                return Eenvio.moto;
            }

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
