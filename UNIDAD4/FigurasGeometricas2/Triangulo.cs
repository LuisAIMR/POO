using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas2
{
     abstract class Triangulo:FiguraGeometrica
    {
        private double  altura;
        private string tipoTri;

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

            
            altura = 0;
            tipoTri = "";
        }
        public abstract override void CalcularArea();
        
        public  abstract override void CalcularPerimetro();
        
    }
}
