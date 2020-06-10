
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosMayorMenor
{
    class numeros
    {
       public int Mayor { get; set; }
       public int Menor { get; set; }
       public  int [] ArregloNumeros { get; set; }


        public string CalcularMayorMenor()
        {
            string resultado = "";
            Mayor = -10000;
            Menor = 10000;

            for (int f = 0; f < ArregloNumeros.Length; f++)
            {
                if (ArregloNumeros[f] > Mayor)
                {
                    Mayor = ArregloNumeros[f];
                }               
            }
            for (int f = 0; f < ArregloNumeros.Length; f++)
            {
                if (ArregloNumeros[f] <Menor)
                {
                    Menor = ArregloNumeros[f];
                }
            }
            resultado = "El numero mayor es " + Mayor + " y el numero menor es " + Menor;
            return resultado;
        }
    }
}
