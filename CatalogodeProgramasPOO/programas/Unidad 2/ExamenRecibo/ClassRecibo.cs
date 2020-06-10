using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRecibo
{
    class ClassRecibo
    {
        //Atributos de la clase
        public string tipoContrato;
        public double CantidadPagar = 0;
        public double CaWatts = 0;
        //metodos de la clase
        public void CaPagar()
        {
            switch (tipoContrato)
            {
                case "Hogar":
                    {
                        if (CaWatts > 0 & CaWatts <= 250)
                        {
                            CantidadPagar = CaWatts * 0.65;
                        }
                        else if (CaWatts >= 251 & CaWatts <= 500)
                        {
                            CantidadPagar = CaWatts * 0.85;
                        }
                        else if (CaWatts >= 501 & CaWatts <= 1200)
                        {
                            CantidadPagar = CaWatts * 1.5;
                        }

                        else if (CaWatts >= 1201 & CaWatts <= 2100)
                        {
                            CantidadPagar = CaWatts * 2.5;
                        }
                        else if (CaWatts >= 2101)
                        {
                            CantidadPagar = CaWatts * 3;
                        }
                        break;
                    }
                case "Negocio":
                    {
                        CantidadPagar = CaWatts * 5;
                        break;
                    }
            }

        }
    }
}
