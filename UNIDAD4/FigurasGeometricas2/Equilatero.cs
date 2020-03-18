using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas2
{
    class Equilatero:Triangulo
    {
        public override void CalcularPerimetro()
        {

            Perimetro = Lado * 3;
        }
        public override void CalcularArea()
        {
            Area = (Lado * Altura) / (2);
        }
    }
}
