using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_Clases
{
    public class Cliente:Persona
    {
        string dni;

        public string Dni
        {
            get { return dni; }
            set 
            {
                if (validarDni(value))
                {
                    this.dni = value;
                }
            }
        }

        public Cliente (string nombre, string apellido, string dni):base(nombre,apellido)
        {
            this.Dni = dni;
        }

        /// <summary>
        /// Sobrecarga el operador == para que permita comparar la propiedad DNI con un string.
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="dni"></param>
        /// <returns>Devuelve true si el string es igual a la propiedad, sino false.</returns>
        public static bool operator == (Cliente cliente, string dni)
        {
            if(cliente.dni.Equals(dni))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga el operador != para que permita comparar la propiedad DNI con un string.
        /// </summary>
        /// <param name="cliente">Objeto cliente</param>
        /// <param name="dni">string</param>
        /// <returns>Devuelve false si el string es igual a la propiedad, sino true.</returns>
        public static bool operator !=(Cliente cliente, string dni)
        {
            if (cliente.dni.Equals(dni))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Busca al cliente cuyo dni fue pasado por parámetro.
        /// </summary>
        /// <param name="dni">string dni del cliente</param>
        /// <returns>Devuelve true si encontró al cliente. False si no.</returns>
        public static bool buscarCliente(string dni)
        {
            List<Cliente> lista = Colecciones.getListaClientes();
            foreach(Cliente item in lista)
            {
                if(item == dni)
                {
                    return true;
                }
                
            }
            return false;
        }

        /// <summary>
        /// Valida que el DNI introducido sea válido.
        /// </summary>
        /// <param name="dni">string dni del cliente</param>
        /// <returns>Devuelve true si el string es válido y false si no.</returns>
        public static bool validarDni(string dni)
        {
            foreach (char item in dni)
            {
                if ((item >= '0' && item <= '9') && dni.Length == 8)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
