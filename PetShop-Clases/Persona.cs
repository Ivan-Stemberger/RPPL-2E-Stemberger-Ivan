using System;

namespace PetShop_Clases
{
    public abstract class Persona
    {
        string nombre;
        string apellido;

        public string Nombre
        {
            get { return nombre; }
            set 
            {
                if(validarString(value))
                {
                    this.nombre = value;
                }
            }
        }
        public string Apellido 
        {
            get { return apellido; }
            set 
            {
                if (validarString(value))
                {
                    this.apellido = value;
                }
            }
        }

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre.ToUpper();
            this.Apellido = apellido.ToUpper();
        }

        /// <summary>
        /// Valida que el dato introducido no contenga números.
        /// </summary>
        /// <param name="stringAValidar">string que será validado</param>
        /// <returns>devuelve true si no contiene números y false si los contiene.</returns>
        public bool validarString(string stringAValidar)
        {
            foreach(char item in stringAValidar)
            {
                if(item >= '0' && item <= '9')
                {
                    return false;
                }
            }
            return true;
        }

    }
}
