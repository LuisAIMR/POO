using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEjercicio1
{
    class Milimetros:unidadesDeMedida
    {
        public override void ConvertirNuevoTipo()
        {
            if (ConvertirNuevo == "Centimetros")
            {
                ResConversion = Unidad/10;
            }
            else if (ConvertirNuevo == "Metros")
            {
                ResConversion = Unidad/1000;
            }
        }
    }
}
