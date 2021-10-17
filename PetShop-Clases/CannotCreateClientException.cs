using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_Clases
{
    public class CannotCreateClientException:Exception
    {
        public override string Message
        {
            get
            {
                return "No se puede cargar el nuevo cliente porque alguno de los datos es incorrecto.";
            }
        }
    }
}
