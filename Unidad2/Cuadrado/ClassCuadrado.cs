using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrado
{
    class ClassCuadrado
    {
        //Atributos para la clase cuadrado
        public double lado =0;
        //Atributos para perimetro
        public Double perimetro = 0;
        //Atributos para el area
        public Double area = 0;

        //Metodos de la clase
        public void CalPerimetro()
        {
            perimetro = lado * 4;
            
        }
        public void CalArea()
        {
            area = lado * lado;
            
        }
    }
}
