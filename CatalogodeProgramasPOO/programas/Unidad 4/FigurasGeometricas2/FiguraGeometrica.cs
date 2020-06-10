using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas2
{
    abstract class FiguraGeometrica
    {
        private double lado, area, perimetro;

        public double Lado
        {
            set
            {
                lado = value;
            }
            get
            {
                return lado;
            }
        }

        public double Area
        {
            set
            {
                area = value;
            }
            get
            {
                return area;
            }
        }

        public double Perimetro
        {
            set
            {
                perimetro = value;
            }
            get
            {
                return perimetro;
            }
        }
        public FiguraGeometrica()
        {
            lado = 0;
            perimetro = 0;
            area = 0;
        }

        public abstract void CalcularPerimetro();



        public abstract void CalcularArea();

    }
}
