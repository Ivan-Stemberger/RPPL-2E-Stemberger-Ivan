using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_Clases
{
    public static class Colecciones
    {

        public static List<Producto> listaProductos = new List<Producto>();
        public static List<Producto> carrito = new List<Producto>();
        public static List<Cliente> listaClientes = new List<Cliente>();
        public static List<Venta> listaVentas = new List<Venta>();
        public static List<Usuario> listaUsuarios = new List<Usuario>();
        public static List<Usuario> listaEmpleados = new List<Usuario>();


        public static List<Cliente> getListaClientes()
        {
            return listaClientes;
        }

        public static List<Usuario> getListaUsuarios()
        {
            return listaUsuarios;
        }

        public static List<Usuario> getListaEmpleados()
        {
            cargarEmpleados();
            return listaEmpleados;
        }

        public static List<Producto> getListaProductos()
        {
            return listaProductos;
        }

        public static List<Producto> getCarrito()
        {
            return carrito;
        }

        public static List<Venta> getListaVentas()
        {
            return listaVentas;
        }
        public static void cargarListas()
        {
            listaProductos = cargarListaProductos(listaProductos);
            listaClientes = cargarListaClientes(listaClientes);
            listaVentas = cargarListaVentas(listaVentas);
            listaUsuarios = cargarListaUsuarios(listaUsuarios);
        }

        private static List<Usuario> cargarListaUsuarios(List<Usuario> lista)
        {
            lista.Add(new Usuario("Pepe", "Perez", "Admin", "Admin", Usuario.ERole.Administrador));
            lista.Add(new Usuario("Jose", "Jimenez", "JoseJimenez", "Contraseña", Usuario.ERole.Empleado));
            lista.Add(new Usuario("Natalia", "Gonazalez", "NataGonza", "NotSecure", Usuario.ERole.Empleado));
            lista.Add(new Usuario("Pepe", "Perez", "PepePerez", "Prueba", Usuario.ERole.Empleado));

            return lista;
        }

        private static List<Producto> cargarListaProductos(List<Producto> lista)
        {
            lista.Add(new Producto("Royal Cannin", Producto.ETipo.Alimentos, 30, 750));
            lista.Add(new Producto("Sogas", Producto.ETipo.Juguetes, 15, 250));
            lista.Add(new Producto("Cucha", Producto.ETipo.Camas, 5, 1200));
            lista.Add(new Producto("Pipeta", Producto.ETipo.Farmacia, 40, 1500));

            return lista;
        }

        private static List<Cliente> cargarListaClientes(List<Cliente> lista)
        {

            lista.Add(new Cliente("Jose", "Hernandez", "30658978"));
            lista.Add(new Cliente("Andrea", "Smith", "34512682"));
            lista.Add(new Cliente("Mauricio", "Mendez", "25943542"));
            lista.Add(new Cliente("Enrique", "Romero", "39827693"));

            return lista;
        }

        private static List<Venta> cargarListaVentas(List<Venta> lista)
        {

            lista.Add(new Venta("RoyalCannin", Producto.ETipo.Alimentos, 1, 750, "30658978"));
            lista.Add(new Venta("Sogas", Producto.ETipo.Juguetes, 2, 250, "25943542"));
            lista.Add(new Venta("Cucha", Producto.ETipo.Camas, 1, 1200, "34512682"));
            lista.Add(new Venta("Pipeta", Producto.ETipo.Farmacia, 2, 1500, "25943542"));

            return lista;
        }

        public static void cargarEmpleados()
        {
            foreach(Usuario item in listaUsuarios)
            {
                if(item.role == Usuario.ERole.Empleado && !listaEmpleados.Contains(item))
                {
                    listaEmpleados.Add(item);
                }    
            }
        }
        public static void cargarCarrito(Producto producto)
        {
            producto.Precio *= producto.Cantidad;
            carrito.Add(producto);
        }

        public static void vaciarCarrito()
        {
            carrito.Clear();
        }
    }
}
