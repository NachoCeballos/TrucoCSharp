using System;
using System.Collections.Generic;
using System.Text;

namespace Truco
{
    public class Mazo
    {
        public List<Carta> Cartas { get; private set; }
        public string myCarta1 { get; private set; }
        public string myCarta2 { get; private set; }
        public string myCarta3 { get; private set; }

        public int carta1 { get; private set; }
        public int carta2 { get; private set; }
        public int carta3 { get; private set; }
        public int cont { get; set; } = 0;

        int[,] matriz = new int[3, 3];

        public Mazo()
        {
            Cartas = new List<Carta>();


            Cartas.Add(new Carta()
            {
                Numero = 1,
                Palo = "Espada",
                Puntaje = 1
            });


            Cartas.Add(new Carta()
            {
                Numero = 1,
                Palo = "Basto",
                Puntaje = 2
            });


            Cartas.Add(new Carta()
            {
                Numero = 7,
                Palo = "Espada",
                Puntaje = 3
            });

            Cartas.Add(new Carta()
            {
                Numero = 7,
                Palo = "Oro",
                Puntaje = 4
            });

            Cartas.Add(new Carta()
            {
                Numero = 3,
                Palo = "Espada",
                Puntaje = 5
            });

            Cartas.Add(new Carta()
            {
                Numero = 3,
                Palo = "Oro",
                Puntaje = 5
            });

            Cartas.Add(new Carta()
            {
                Numero = 3,
                Palo = "Basto",
                Puntaje = 5
            });

            Cartas.Add(new Carta()
            {
                Numero = 3,
                Palo = "Copa",
                Puntaje = 5
            });

            Cartas.Add(new Carta()
            {
                Numero = 2,
                Palo = "Espada",
                Puntaje = 6
            });

            Cartas.Add(new Carta()
            {
                Numero = 2,
                Palo = "Oro",
                Puntaje = 6
            });

            Cartas.Add(new Carta()
            {
                Numero = 2,
                Palo = "Basto",
                Puntaje = 6
            });

            Cartas.Add(new Carta()
            {
                Numero = 2,
                Palo = "Copa",
                Puntaje = 6
            });


            Cartas.Add(new Carta()
            {
                Numero = 1,
                Palo = "Oro",
                Puntaje = 7
            });


            Cartas.Add(new Carta()
            {
                Numero = 1,
                Palo = "Copa",
                Puntaje = 7
            });


            Cartas.Add(new Carta()
            {
                Numero = 12,
                Palo = "Espada",
                Puntaje = 8
            });

            Cartas.Add(new Carta()
            {
                Numero = 12,
                Palo = "Oro",
                Puntaje = 8
            });

            Cartas.Add(new Carta()
            {
                Numero = 12,
                Palo = "Basto",
                Puntaje = 8
            });

            Cartas.Add(new Carta()
            {
                Numero = 12,
                Palo = "Copa",
                Puntaje = 8
            });


            Cartas.Add(new Carta()
            {
                Numero = 11,
                Palo = "Espada",
                Puntaje = 9
            });

            Cartas.Add(new Carta()
            {
                Numero = 11,
                Palo = "Oro",
                Puntaje = 9
            });

            Cartas.Add(new Carta()
            {
                Numero = 11,
                Palo = "Basto",
                Puntaje = 9
            });

            Cartas.Add(new Carta()
            {
                Numero = 11,
                Palo = "Copa",
                Puntaje = 9
            });


            Cartas.Add(new Carta()
            {
                Numero = 10,
                Palo = "Espada",
                Puntaje = 10
            });

            Cartas.Add(new Carta()
            {
                Numero = 10,
                Palo = "Oro",
                Puntaje = 10
            });

            Cartas.Add(new Carta()
            {
                Numero = 10,
                Palo = "Basto",
                Puntaje = 10
            });

            Cartas.Add(new Carta()
            {
                Numero = 10,
                Palo = "Copa",
                Puntaje = 10
            });


            Cartas.Add(new Carta()
            {
                Numero = 7,
                Palo = "Basto",
                Puntaje = 10
            });

            Cartas.Add(new Carta()
            {
                Numero = 7,
                Palo = "Copa",
                Puntaje = 10
            });


            Cartas.Add(new Carta()
            {
                Numero = 6,
                Palo = "Espada",
                Puntaje = 11
            });

            Cartas.Add(new Carta()
            {
                Numero = 6,
                Palo = "Oro",
                Puntaje = 11
            });

            Cartas.Add(new Carta()
            {
                Numero = 6,
                Palo = "Basto",
                Puntaje = 11
            });

            Cartas.Add(new Carta()
            {
                Numero = 6,
                Palo = "Copa",
                Puntaje = 11
            });


            Cartas.Add(new Carta()
            {
                Numero = 5,
                Palo = "Espada",
                Puntaje = 12
            });

            Cartas.Add(new Carta()
            {
                Numero = 5,
                Palo = "Oro",
                Puntaje = 12
            });

            Cartas.Add(new Carta()
            {
                Numero = 5,
                Palo = "Basto",
                Puntaje = 12
            });

            Cartas.Add(new Carta()
            {
                Numero = 5,
                Palo = "Copa",
                Puntaje = 12
            });



            Cartas.Add(new Carta()
            {
                Numero = 4,
                Palo = "Espada",
                Puntaje = 13
            });

            Cartas.Add(new Carta()
            {
                Numero = 4,
                Palo = "Oro",
                Puntaje = 13
            });

            Cartas.Add(new Carta()
            {
                Numero = 4,
                Palo = "Basto",
                Puntaje = 13
            });

            Cartas.Add(new Carta()
            {
                Numero = 4,
                Palo = "Copa",
                Puntaje = 13
            });

        }

        public List<Carta> Repartir()
        {
            Random numr = new Random();

            
            var carta1 = cartaAleatoria();
            var carta2 = cartaAleatoria();
            var carta3 = cartaAleatoria();
            

            List<Carta> cartasARepatir = new List<Carta>();

            
            cartasARepatir.Add(carta1);
            cartasARepatir.Add(carta2);
            cartasARepatir.Add(carta3);

            return cartasARepatir;
        }

        private Carta cartaAleatoria()
        {
            Random numr = new Random();

            int indice = numr.Next(0, this.Cartas.Count - 1);

            Carta cartaDevolver = this.Cartas[indice];
            this.Cartas.RemoveAt(indice);
            return cartaDevolver;
        }


        public void cartasAleatorios()
        {
            Random numr = new Random();

            var nombres = new List<string>();

            nombres.Add("pepe");

            carta1 = numr.Next(0, 40);
            carta2 = numr.Next(0, 40);
            carta3 = numr.Next(0, 40);

            carta1 = numerosA(carta1, carta2, carta3, 1);
            carta2 = numerosA(carta1, carta2, carta3, 2);
            carta3 = numerosA(carta1, carta2, carta3, 3);

            //matriz[cont, cont] = carta1;
            //matriz[cont, cont] = carta2;
            //matriz[cont, cont] = carta3;

            cont++;

            myCarta1 = cartas(carta1);
            myCarta2 = cartas(carta2);
            myCarta3 = cartas(carta3);
        
        
        }
        
        
        



        static int numerosA(int cart1, int cart2, int cart3, int i)
        {

            Random cartaR = new Random();

            int a = 0;

            while (cart1 == cart2)
            {
                cart2 = cartaR.Next(0, 3);
            }


            while (cart2 == cart3)
            {
                cart3 = cartaR.Next(0, 3);
            }



            while (a != 2)
            {
                if ((cart3 == cart1) | (cart3 == cart2))
                {
                    cart3 = cartaR.Next(0, 3);
                }
                else if ((cart3 != cart1) & (cart3 != cart2)) a = 2;

            }


            if (i == 1) return cart1;
            if (i == 2) return cart2;
            if (i == 3) return cart3;
            return 0;

        }


        static string cartas(int valor1)
        {

            string carta;

            switch (valor1)
            {
                case 39:
                    carta = "1 de Espada";
                    break;


                case 38:
                    carta = "1 de Basto";
                    break;


                case 37:
                    carta = "7 de Espada";
                    break;


                case 36:
                    carta = "7 de Oro";
                    break;


                case 35:
                    carta = "3 de Copa";
                    break;

                case 34:
                    carta = "3 de Espada";
                    break;


                case 33:
                    carta = "3 de Oro";
                    break;


                case 32:
                    carta = "3 de Basto";
                    break;


                case 31:
                    carta = "2 de Copa";
                    break;


                case 30:
                    carta = "2 de Espada";
                    break;


                case 29:
                    carta = "2 de Oro";
                    break;


                case 28:
                    carta = "2 de Basto";
                    break;


                case 27:
                    carta = "1 de Oro";
                    break;


                case 26:
                    carta = "1 de Copa";
                    break;


                case 25:
                    carta = "12 de Copa";
                    break;


                case 24:
                    carta = "12 de Espada";
                    break;


                case 23:
                    carta = "12 de Oro";
                    break;


                case 22:
                    carta = "12 de Basto";
                    break;


                case 21:
                    carta = "11 de Copa";
                    break;


                case 20:
                    carta = "11 de Espada";
                    break;


                case 19:
                    carta = "11 de Oro";
                    break;


                case 18:
                    carta = "11 de Basto";
                    break;


                case 17:
                    carta = "10 de Copa";
                    break;


                case 16:
                    carta = "10 de Espada";
                    break;


                case 15:
                    carta = "10 de Oro";
                    break;


                case 14:
                    carta = "10 de Basto";
                    break;


                case 13:
                    carta = "7 de Copa";
                    break;


                case 12:
                    carta = "7 de Basto";
                    break;


                case 11:
                    carta = "6 de Copa";
                    break;


                case 10:
                    carta = "6 de Espada";
                    break;


                case 9:
                    carta = "6 de Oro";
                    break;


                case 8:
                    carta = "6 de Basto";
                    break;


                case 7:
                    carta = "5 de Copa";
                    break;


                case 6:
                    carta = "5 de Espada";
                    break;


                case 5:
                    carta = "5 de Oro";
                    break;


                case 4:
                    carta = "5 de Basto";
                    break;


                case 3:
                    carta = "4 de Copa";
                    break;


                case 2:
                    carta = "4 de Espada";
                    break;


                case 1:
                    carta = "4 de Oro";
                    break;


                case 0:
                    carta = "4 de Basto";
                    break;


                default:
                    carta = "xd";
                    break;


            }
            return carta;
        }
    }
}
