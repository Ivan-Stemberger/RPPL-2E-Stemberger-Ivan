using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_Clases
{
    public class ClientNotFoundException:Exception
    {
        public override string Message
        {
            get 
            {
                return "El cliente no existe en la base de datos. Por favor pedir a un administrador que lo agregue.";
            }
        }

    }
}
