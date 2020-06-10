using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    class ClassVehiculo
    {
        //Atributos de la clase
        public string tipo;
        public int cantidadCO = 0;

        //Metodos de la clase
        public void cantidadCobro()
        {
            switch(tipo)
            {
                case"Motociclista":
                {
                        cantidadCO = 50;
                        break;

                }
                case "Automóvil":
                    {
                        cantidadCO =112;
                        break;

                    }
                case "Autobús":
                    {
                        cantidadCO =170;
                        break;

                    }
                case "Tráiler":
                    {
                        cantidadCO =250;
                        break;

                    }
            }
        }
    }
}
