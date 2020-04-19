using System;
using System.Collections.Generic;
using System.Text;

namespace Truco
{
    class Jugador : Cartas
    {
        public string nombre { get; set; }

        public int suNumAleatoris1 { get; private set; }
        public int suNumAleatoris2 { get; private set; }
        public int suNumAleatoris3 { get; private set; }
    }
}
