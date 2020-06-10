using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
      class Triangulo : FiguraGeometrica
    {
        private double lado2, lado3, altura;
        private string tipoTri;

        public double Lado2
        {
            set
            {
                lado2 = value;
            }
            get
            {
                return lado2;
            }
        }
        public double Lado3
        {
            set
            {
                lado3 = value;
            }
            get
            {
                return lado3;
            }

        }
        public double Altura
        {
            set { altura = value; }
            get { return altura; }
        }

        public string TipoTri
        {
            set
            {
                tipoTri = value;
            }
            get
            {
                return tipoTri;
            }
        }
        public Triangulo()
        {
            
            lado2 = 0;
            lado3 = 0;
            altura = 0;
            tipoTri = "";
        }
        public override void CalcularArea()
        {

            if (TipoTri == "Equilatero")
            {

                Area =(Lado*Altura)/(2);
            }
            else if (TipoTri == "Escaleno" )
            {
                Area = (Lado * Lado2) /(2);
            }
            else if (TipoTri == "Isoceles")
            {
                Area = (Lado * altura) / (2);
            }
        }
        public override void CalcularPerimetro()
        {
            if (TipoTri == "Equilatero")
            {

                Perimetro = Lado*3;
            }
            else if (TipoTri == "Escaleno" )
            {
                Perimetro = Lado + Lado2 + Lado3;
            }
            else if (TipoTri == "Isoceles")
            {
                Perimetro = Lado + (Lado2 * 2);
            }

        }
    }
} 
