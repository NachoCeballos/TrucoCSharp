using System;
using System.Collections.Generic;
using System.Text;

namespace Truco
{
    public class Carta
    {
        public string Palo { get; set; }

        public int Numero { get; set; }

        public int Puntaje { get; set; }

        public string Nombre()
        {
            return $"{this.Numero} de {this.Palo}";
        }
    }
}
