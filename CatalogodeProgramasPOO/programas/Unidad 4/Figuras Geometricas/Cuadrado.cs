using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    class Cuadrado:FiguraGeometrica
    {
        public override void CalcularArea()
        {
            Area = Lado * Lado;
        }
        public override void CalcularPerimetro()
        {
            Perimetro = Lado * 4;
        }

    }
}
