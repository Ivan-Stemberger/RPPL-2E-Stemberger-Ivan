using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_Clases
{
    public class Usuario : Persona
    {
        string userName;
        string password;

        public enum ERole
        {
            Empleado,
            Administrador
        }

        public ERole role;
        public string UserName
        {
            get { return userName; }
            set { this.userName = value; }
        }
        public string Password
        {
            get { return password; }
            set { this.password = value; }
        }

        public Usuario(string nombre, string apellido, string userName, string password, ERole role):base(nombre,apellido)
        {
            
            this.UserName = userName.ToUpper();
            this.Password = password;
            this.role = role;
        }

        
        public Usuario(string nombre, string apellido, string userName, string password) : base(nombre, apellido)
        {
            
            this.UserName = userName.ToUpper();
            this.Password = password;
            this.role = ERole.Empleado;
        }
        
        /// <summary>
        /// Confirma que el usuario y contraseña coincidan con los registros de la lista de usuarios.
        /// </summary>
        /// <param name="lista">Listado de usuarios.</param>
        /// <param name="contraseña">string contrseña del usuario.</param>
        /// <param name="usuario">string username.</param>
        /// <returns></returns>
        public static bool confirmarcontraseña(List<Usuario> lista, string contraseña, string usuario)
        {

            foreach (Usuario item in lista)
            {
                if (item.password.Equals(contraseña) && item.userName == usuario)
                {
                    return true;
                }
            }
            return false;

        }

        /// <summary>
        /// Verifica si el usuario tiene el rol de Administrador
        /// </summary>
        /// <param name="lista">listado de usuarios.</param>
        /// <param name="usuario">string username.</param>
        /// <returns></returns>
        public static bool confirmarRole(List<Usuario> lista, string usuario)
        {
            foreach (Usuario item in lista)
            {
                if (item.userName.Equals(usuario) && item.role.Equals(ERole.Administrador))
                {
                    return true;

                }
            }
            return false;
        }

        /// <summary>
        /// Verifica si el usuario existe.
        /// </summary>
        /// <param name="userName">string username.</param>
        /// <returns>Devuelve true si existe, false si no.</returns>
        public static bool buscarEmpleado(string userName)
        {
            List<Usuario> lista = Colecciones.getListaUsuarios();

            foreach(Usuario item in lista)
            {
                if(item.UserName.Equals(userName))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Conforma un string con los datos del empleado pasado por parámetro.
        /// </summary>
        /// <param name="userName">string username</param>
        /// <returns>Devuelve un string con los datos del usuario</returns>
        public static string datosEmpleado(string userName)
        {
            List<Usuario> lista = Colecciones.getListaUsuarios();
            StringBuilder sb = new StringBuilder();

            foreach (Usuario item in lista)
            {
                if (item.userName.Equals(userName))
                {
                    sb.AppendLine("Nombre: " + item.Nombre);
                    sb.AppendLine("Apellido: " + item.Apellido);
                    sb.AppendLine("UserName: " + item.userName);
                    break;
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Elimina un empleado del listado.
        /// </summary>
        /// <param name="userName">string usuario a eliminar.</param>
        public static void eliminarUsuario(string userName)
        {
            List<Usuario> lista = Colecciones.getListaUsuarios();
            Usuario usuarioABorrar = null;

            foreach (Usuario item in lista)
            {
                if (item.userName.Equals(userName))
                {
                    usuarioABorrar = item;
                    break;
                }
            }

            lista.Remove(usuarioABorrar);

        }
    }

    
}
