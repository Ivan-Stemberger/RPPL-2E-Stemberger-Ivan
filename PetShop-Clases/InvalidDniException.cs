using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_Clases
{
    public class InvalidDniException:Exception
    {
        public override string Message
        {
            get
            {
                return "El DNI ingresado es inválido.";
            }
        }
    }
}
