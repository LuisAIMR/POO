using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    class Aereo:Vehiculo
    {
       public int numTurbina,numAlas,numHelices;
       public string tiAereo, estado;
       public int  a=0;

        public Aereo()
        {
            numAlas = 0;
            numTurbina = 0;
            numHelices = 0;
            tiAereo = "";
            estado = "";
        }
        
        public string enVuelo()
        {
            return "El "+ tiAereo+" esta "+ estado;
        }
        
    }

    
}
