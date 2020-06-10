using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPiedraPapelyTijeras
{
    interface IJuegoPPT
    {
       
        int Computadora { set; get; }       
        int Jugador { set; get; }
        string Mensaje { set; get; }
        string NombreJugador { set; get; }

        void CalcularResultado();
    }
}
