using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas2
{
    class Escaleno:Triangulo
    {
        private double lado2;
        private double lado3;

        public double Lado2
        {
            set { lado2 = value; }
            get { return lado2; }
        }

        public double Lado3
        {
            set { lado3 = value; }
            get { return lado3; }
        }

        public Escaleno()
        {
            lado2 = 0;
            lado3 = 0;
        }

        public override void CalcularPerimetro()
        {
            Perimetro = Lado + Lado2 + Lado3;
        }
        public override void CalcularArea()
        {
            Area = (Lado * Lado2) / (2);
        }
    }
}
