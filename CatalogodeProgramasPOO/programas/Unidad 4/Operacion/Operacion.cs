using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacion
{
    class Operacion
    {
        //Atributos de la clase
        private double valor1, valor2, resultado;

        public double Valor1
        {
            set
            {
                valor1 = value;
            }
            get
            {
                return valor1;
            }
        }
        public double Valor2
        {
            set
            {
                valor2 = value;
            }
            get
            {
                return valor2;
            }
        }
        public double Resultado
        {
            set
            {
                resultado = value;
            }
            get
            {
                return resultado;
            }
        }
        public Operacion()
        {
            valor1 = 0;
            valor2 = 0;
            resultado = 0;
        }
        public void imprimirValores()
        { 

           
        }    
        
    }
    
}
