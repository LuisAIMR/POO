using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class ClassPersona
    {
        //Atributos de la clase
        public int diaNac = 0,mesNac=0,anioNac=0;
        //Atributos para el metodo
        public int diaAc = 0, mesAc = 0, anioAc=0;
        public string mayorEdad ;
        //metodos de la clase
        public void MayorEdad()
        {
            if (anioAc - anioNac > 18)
            {
                mayorEdad = "Es mayor de edad";
            }
          
            else if (anioAc - anioNac == 18)
            {
                if (mesAc > mesNac)
                {
                    mayorEdad = "Es mayor de edad";
                }
              
                else if (mesAc == mesNac)
                {
                    if (diaAc > diaNac )
                    {
                        mayorEdad = "Es mayor de edad";
                    }
                   
                    else if (diaAc == diaNac)
                    {
                        mayorEdad = "Es mayor de edad";
                    }
                }
            }
        }    
    }
}
