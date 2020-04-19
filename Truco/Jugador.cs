using System;
using System.Collections.Generic;
using System.Text;

namespace Truco
{
    class Jugador
    {
        public string nombre { get; set; }

        public List<Carta> Cartas { get; set; }

        public int suNumAleatoris1 { get; private set; }
        public int suNumAleatoris2 { get; private set; }
        public int suNumAleatoris3 { get; private set; }

        public override string ToString()
        {
            string pepe = $"Jugador {this.nombre}\n";
            pepe += $"Carta 1 {this.Cartas[0].Nombre()}";
            pepe += $"Carta 2 {this.Cartas[1].Nombre()}";
            pepe += $"Carta 3 {this.Cartas[2].Nombre()}";
            return pepe;
        }
    }
}
