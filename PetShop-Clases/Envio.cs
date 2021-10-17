using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_Clases
{
    public class Envio
    {

        int peso;
        int distancia;
        int precio;
        public enum Eenvio { Moto = 210, Miniflete = 500};
        public Eenvio tipoEnvio;

        public int Peso
        {
            get { return peso; }
            set { this.peso = value; }

        }

        public int Distancia
        {
            get { return distancia; }
            set { this.distancia = value; }

        }

        public int Precio
        {
            get { return precio; }
            set { this.precio = value; }

        }

        public Envio ()
        {
            this.peso = calcularPeso();
            this.tipoEnvio = definirEnvio(peso);
            this.distancia = calcularDistancia();
            this.precio = precioFinal(distancia, tipoEnvio);

        }

        public int calcularPeso()
        {
            int peso = 0;
            List<Producto> lista = Colecciones.getCarrito();
            
            foreach(Producto item in lista)
            {
                peso += (int)item.Peso * item.Cantidad;
            }

            return peso;
        }

        private int calcularDistancia()
        {
            Random random = new Random();
            int distancia = random.Next(1, 30);

            return distancia;
        }

        public Eenvio definirEnvio(float peso)
        {

            if (peso > 30)
            {
                return Eenvio.Miniflete;
            }
            else
            {
                return Eenvio.Moto;
            }

        }


        private int calcularPrecioPorDistancia(int distancia, Eenvio envio)
        {
            if (((int)envio) == 210)
            {
                return distancia *= 50;
            }
            else
            {
                return distancia *= 100;
            }

        }

        private int precioFinal(int distancia, Eenvio envio)
        {
            int precio = 0;

            precio += calcularPrecioPorDistancia(distancia, envio) + (int)envio;

            return precio;

        }
    }
}
