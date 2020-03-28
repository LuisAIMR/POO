using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPiedraPapelyTijeras
{
    class JuegoPPT:PiedraPapelYTijeras
    {
        
        //utiliza el metodo Calcular resultado para decidir que mensaje enviar al usuario
        public override void CalcularResultado()
        {
            //Evalua todas las formas de ganar
            if (Jugador > Computadora & Computadora == 2)
            {
                Mensaje = "¡FELICIDADES USTED GANO! :)";
            }
            else if ((Jugador == 2) & (Jugador > Computadora))
            {
                Mensaje = "¡FELICIDADES USTED GANO! :)";
            }
            else if (Computadora == 3 & Jugador == 1)
            {
                Mensaje = "¡FELICIDADES USTED GANO! :)";
            }
            //Evalua todas todas las formas de perder
            else if ((Computadora == 2) & (Computadora > Jugador))
            {
                Mensaje = "LO SENTIMOS USTED PERDIO :C";
            }
            else if (Jugador < Computadora & Computadora == 2)
            {
                Mensaje = "LO SENTIMOS USTED PERDIO :C";
            }

            else if (Computadora == 1 & Jugador == 3)
            {
                Mensaje = "LO SENTIMOS USTED PERDIO :C";
            }
            //Evalua cuanto es un empate
            else if (Jugador == Computadora)
            {
                Mensaje = "¡VALLA FUE UN EMPATE! :|";
            }
        }
    }
}
