using System;
using System.Collections.Generic;
using System.Text;

namespace Truco
{
    class Cartas
    {

        public string myCarta1 { get; private set; }
        public string myCarta2 { get; private set; }
        public string myCarta3 { get; private set; }

        public int carta1 { get; private set; }
        public int carta2 { get; private set; }
        public int carta3 { get; private set; }
        public int cont { get; set; } = 0;

        int[,] matriz = new int[3, 3];


        public void cartasAleatorios()
        {
            Random numr = new Random();



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
