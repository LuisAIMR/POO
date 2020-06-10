using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEjercicio1
{
    class Centimetros:unidadesDeMedida
    {

        public override void ConvertirNuevoTipo()
        {
            if( ConvertirNuevo=="Metros")
            {
                ResConversion = Unidad / 100;
            }
            else if (ConvertirNuevo=="Milimetros")
            {
                ResConversion = Unidad*10;
            }
        }
    }
}
