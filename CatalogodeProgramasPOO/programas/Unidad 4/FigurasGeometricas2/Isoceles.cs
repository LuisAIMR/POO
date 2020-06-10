using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas2
{
    class Isoceles:Triangulo
    {
        private double lado2;
      

        public double Lado2
        {
            set { lado2 = value; }
            get { return lado2; }
        }

       

        public Isoceles()
        {
            lado2 = 0;
           
        }

        public override void CalcularPerimetro()
        {
            Perimetro = Lado + (Lado2 * 2);
        }
        public override void CalcularArea()
        {
            Area = (Lado * Altura) / (2);
        }
    }
}
