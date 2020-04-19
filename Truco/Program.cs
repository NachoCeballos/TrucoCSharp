using System;

namespace Truco
{
    class Program
    {
        static void Main(string[] args)
        {

            Jugador player1 = new Jugador();

            Jugador player2 = new Jugador();


            int puntosJ1 = 0, puntosJ2 = 0, contJ1 = 0, contJ2 = 0, cont = 0;
            int a = 0, z = 1;
           

            Console.Write("Nombre del primer jugador: ");
            player1.nombre = Console.ReadLine();

            Console.WriteLine("");

            Console.Write("Nombre del segundo jugador: ");
            player2.nombre = Console.ReadLine();

            Console.Clear();

            do
            {
                player1.cartasAleatorios();
                player2.cartasAleatorios();

                int rP1 = 0, rP2 = 0;


                Console.Write($"Cartas de {player1.nombre}\t\t Cartas de {player2.nombre}");
                Console.Write("\t\t");
                Console.WriteLine($"Puntos de {player1.nombre} {puntosJ1}\t\t Puntos de {player2.nombre} {puntosJ2}");

                Console.WriteLine($"a) { player1.myCarta1} \t\t a) { player2.myCarta1} ");
                Console.WriteLine($"b) { player1.myCarta2} \t\t b) { player2.myCarta2} ");
                Console.WriteLine($"c) { player1.myCarta3} \t\t c) { player2.myCarta3} ");

                
                if (cont == 0)
                {
                    Console.WriteLine("\n" + player1.nombre + " es mano\n");
                    a = 0;
                    z = 1;
                }
                
                if(cont == 1)
                {
                    Console.WriteLine("\n" + player2.nombre + " es mano\n");
                    cont = -1;
                    a = 1;
                    z = 0;
                    
                }
                
                

                while ((contJ1 != 2) & (contJ2 != 2))
                {
                    if (a == 0)
                    {
                        Console.WriteLine("\nTurno de " + player1.nombre);

                        switch (Console.ReadLine())
                        {
                            case "a":
                                rP1 = player1.carta1;
                                break;

                            case "b":
                                rP1 = player1.carta2;
                                break;

                            case "c":
                                rP1 = player1.carta3;
                                break;
                        }


                        Console.WriteLine("Turno " + player2.nombre);

                        switch (Console.ReadLine())
                        {
                            case "a":
                                rP2 = player2.carta1;
                                break;

                            case "b":
                                rP2 = player2.carta2;
                                break;

                            case "c":
                                rP2 = player2.carta3;
                                break;
                        }

                        if (Logica(rP1, rP2) == 1)
                        {
                            Console.WriteLine("Gana la carta de " + player1.nombre);
                            contJ1++;
                        }

                        if (Logica(rP1, rP2) == 2)
                        {
                            Console.WriteLine("Gana la carta de " + player2.nombre);
                            a++;
                            z = 0;
                            contJ2++;
                        }
                    }

                    if (z == 0)
                    {
                        Console.WriteLine("\nTurno de " + player2.nombre);

                        switch (Console.ReadLine())
                        {
                            case "a":
                                rP2 = player2.carta1;
                                break;

                            case "b":
                                rP2 = player2.carta2;
                                break;

                            case "c":
                                rP2 = player2.carta3;
                                break;
                        }


                        Console.WriteLine("\nTurno de " + player1.nombre);

                        switch (Console.ReadLine())
                        {
                            case "a":
                                rP1 = player1.carta1;
                                break;

                            case "b":
                                rP1 = player1.carta2;
                                break;

                            case "c":
                                rP1 = player1.carta3;
                                break;
                        }

                        if (Logica(rP1, rP2) == 1)
                        {
                            Console.WriteLine("Gana la carta de " + player1.nombre);
                            a = 0;
                            z++;
                            contJ1++;
                        }

                        if (Logica(rP1, rP2) == 2)
                        {
                            Console.WriteLine("Gana la carta de " + player2.nombre);
                            a++;
                            contJ2++;
                        }
                    }

                    if(contJ1 == 2)
                    {
                        Console.WriteLine(player1.nombre + " gano está mano");
                        puntosJ1++;
                    }
                    else if(contJ2 == 2)
                    {
                        Console.WriteLine(player2.nombre + " gano está mano");
                        puntosJ2++;
                    }
                }
                contJ1 = 0;
                contJ2 = 0;
                cont++;
                Console.ReadLine();
                Console.Clear();


            } while ((puntosJ1 <= 30) | (puntosJ2 <= 30));


            static int Logica(int cartaJ1, int cartaJ2)
            {

                int contJ1 = 0, contJ2 = 0;

                if (cartaJ1 > cartaJ2)
                {
                    contJ2++;
                    return 1;
                }
                else if (cartaJ1 < cartaJ2)
                {
                    contJ1++;
                    return 2;
                }
                return 0;
            }
        }
    }
}
