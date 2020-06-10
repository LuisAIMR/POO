using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recibo
{
    class ClassRecibo
    {
        //Atributos de la clase
        public double kilowatts = 0;
        public string tipoContrato;
        public double CanPagar = 0;
        //Metodos de la clase
        public void CantidadPagar()
        {
            if(tipoContrato=="Hogar")
            {
              
              if (kilowatts>0 & kilowatts<250)
                {
                    CanPagar = kilowatts * 0.65;
                }
                else if (kilowatts>251 & kilowatts<500)
                {
                    CanPagar = kilowatts * 0.85;
                }
                else if (kilowatts> 501 & kilowatts<1200)
                {
                    CanPagar = kilowatts * 1.5;
                }
                else if (kilowatts>1201 & kilowatts<2100)
                {
                    CanPagar = kilowatts * 2.5;
                }
                else if (kilowatts >= 2101)
                {
                    CanPagar = kilowatts * 3.5;
                }

            }
            else if (tipoContrato=="Negocio")
            {
                CanPagar = kilowatts * 5;
            }
            
                

        }
    }
}
