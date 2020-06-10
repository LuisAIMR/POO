using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPiedraPapelyTijeras
{
     abstract class PiedraPapelYTijeras:IJuegoPPT
    {
        //se crean variables privadas para ser usadas posteriormente
        private int computadora;
        private int jugador;
        private string mensaje;
        private string nombreJugador;
        //se crea el constructor para inicializar los atributos privados
        public PiedraPapelYTijeras()
        {
            jugador = 0;
            computadora = 0;
            mensaje = "";
            nombreJugador = "";
        }
        //Se utilizan las propiedades heredadas de la interface IJuegoPPT para acceder a las variables privadas de la clase
        public string NombreJugador { set { nombreJugador=value; } get {return nombreJugador; } }
        public int Computadora { set { computadora = value; } get { return computadora; } }
        public string Mensaje { set {mensaje=value; } get {return mensaje; } }
        public int Jugador { set { jugador = value; } get { return jugador; } }

        public abstract void CalcularResultado();
    }
}
