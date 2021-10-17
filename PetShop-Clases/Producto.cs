using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_Clases
{
    public class Producto
    {
        string descripcion;
        public enum ETipo
        {
            Alimentos,
            Juguetes,
            Camas,
            Limpieza,
            Farmacia
        }
        int cantidad;
        float peso;
        float precio;
       

        public ETipo tipo;
        public string Descripcion 
        {
            get { return descripcion; }
            set { this.descripcion = value; } 
        }
        
        public int Cantidad
        {
            get { return cantidad; }
            set { this.cantidad = value; }
        }

        public float Peso
        {
            get { return peso; }
            set { this.peso = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { this.precio = value; }
        }

        public Producto (string descripcion, int cantidad)
        {
            this.Descripcion = descripcion;
            this.tipo = buscarTipo(descripcion);
            this.Cantidad = cantidad;
            this.Peso = buscarPeso(descripcion);
            this.Precio = buscarPrecio(descripcion);
        }
        public Producto(string descripcion, int cantidad, float precio)
        {

            this.Descripcion = descripcion;
            this.tipo = buscarTipo(descripcion);
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.Precio = buscarPrecio(descripcion);
        }

        public Producto (string descripcion, ETipo tipo, int cantidad, float precio)
        {
            
            this.Descripcion = descripcion;
            this.tipo = tipo;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }

        /// <summary>
        /// Busca el precio del producto en la lista de productos en función de la descripcion pasada por parámetro y lo devuelve.
        /// </summary>
        /// <param name="descripcion">string descripción del producto</param>
        /// <returns>Devuelve el precio si encuentra el producto, sino devuelve 0</returns>
        private static float buscarPrecio(string descripcion)
        {
            List<Producto> lista = Colecciones.getListaProductos();

            foreach (Producto item in lista)
            {
                if (item.descripcion.Equals(descripcion))
                {
                    return item.precio;
                }
            }
            return 0;
        }

        /// <summary>
        /// Busca el tipo del producto en la lista de productos en función de la descripcion pasada por parámetro y lo devuelve.
        /// </summary>
        /// <param name="descripcion">string descripción del producto</param>
        /// <returns>Devuelve el tipo si encuentra el producto, sino devuelve "Alimentos" como default.</returns>
        private static ETipo buscarTipo(string descripcion)
        {
            List<Producto> lista = Colecciones.getListaProductos();

            foreach (Producto item in lista)
            {
                if (item.descripcion.Equals(descripcion))
                {
                    return item.tipo;
                }
            }
            return ETipo.Alimentos;
        }

        protected virtual float buscarPeso(string descripcion)
        {
            List<Producto> lista = Colecciones.getListaProductos();

            foreach (Producto item in lista)
            {
                if (item.descripcion.Equals(descripcion))
                {
                    return item.peso;
                }
            }
            return 0;
        }

        /// <summary>
        /// Valida que el producto exista.
        /// </summary>
        /// <param name="descripcion">string descripcion del producto.</param>
        /// <returns>Devuelve true si el producto existe, false si no.</returns>
        public static bool validarProducto(string descripcion)
        {
            List<Producto> lista = Colecciones.getListaProductos();
            foreach(Producto item in lista)
            {
                if(item.descripcion.Equals(descripcion))
                {
                    return true;
                }
                
            }
            return false;
        }

        /// <summary>
        /// Verifica que el producto se encuentre en stock y reduce la cantidad del stock en función de la cantidad del producto que se quiere vender.
        /// </summary>
        /// <param name="carrito">Producto que cuyo stock se quiere verificar.</param>
        /// <param name="stock">Lista de productos en existencia.</param>
        /// <returns>Devuelve true si hay stock, false si no.</returns>
        public static bool confirmarStock(Producto carrito, List<Producto> stock)
        {
            foreach(Producto item in stock)
            {
                if(carrito.descripcion.Equals(item.descripcion) && item.cantidad > carrito.cantidad)
                {
                    item.cantidad -=  carrito.cantidad;
                    return true;
                }
                
            }
            return false;

        }
    }
}
