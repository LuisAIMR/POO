using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas2
{
    class Circulo:FiguraGeometrica
    {
        public override void CalcularArea()
        {
            Area = (3.1416 * Lado) * (3.1416 * Lado);
        }
        public override void CalcularPerimetro()
        {
            Perimetro = (Lado + Lado) * 3.1416;
        }
    }
}
