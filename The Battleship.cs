using System;

namespace P._Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("**************************************************Welcome to the Battleship**************************************************");

            /*Registro de cada jugador */
            Console.WriteLine("Jugador uno, Cual es tu nombre?!!");
            String jugador1 = Console.ReadLine();
            Console.WriteLine("Jugador dos, Cual es tu nombre?!!");
            String jugador2 = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("");

            /*Se muestra las instrucciones del juego asi como los controles*/
            Console.WriteLine("***************Instrucciones***************");
            Console.WriteLine("Los jugadores manejan un tablero de océano y un tablero de tiro; cada uno divididos en casillas. Cada tablero representa una zona diferente del mar abierto: la propia y la contraria");
            Console.WriteLine("");
            Console.WriteLine("Cada jugador posisionara la misma cantidad de barcos en el tablero Una vez todas las naves han sido posicionadas, se inicia una serie de rondas. En cada ronda, cada jugador en su turno «dispara» hacia la flota de su oponente indicando una posición (las coordenadas de una casilla), la que registra en el segundo tablero. Si esa posición es ocupada por parte de un barco contrario, cantara !Hundido!");
            Console.WriteLine("");
            Console.WriteLine("El jugador que ha tocado un barco en su anterior jugada, volverá a disparar hasta que falle. Si la posición indicada no corresponde a una parte de barco alguno, cantará ¡Agua!.");
            Console.WriteLine("");
            Console.WriteLine("Se referenciará los disparos que han caido en una nave oponente  y los que han caido al mar, los tiros errados se señalan con una 'X' y los acertados con un 'O'");
            Console.WriteLine("");
            Console.WriteLine("quien destruya primero todas las naves de su oponente será el vencedor (como en tantos otros juegos en los que se participa por turnos, en caso de que el participante que comenzó la partida hunda en su última jugada el último barco de su oponente que quedaba a flote, el otro participante tiene derecho a una última posibilidad para alcanzar el empate, a un último disparo que también le permita terminar de hundir la flota contraria, lo que supondría un empate)");
            Console.WriteLine("");

            // Tablero jugador 1
            String[,] tablero1 = new String[8, 8];

            for (int f = 0; f <= 7; f++)
            {

                for (int c = 0; c <= 7; c++)
                {
                    tablero1[f, c] = " . ";
                }
            }

            Console.WriteLine("Este es tu tablero " + jugador1);

            // Mostrar matriz
            for (int f = 0; f <= 7; f++)
            {

                for (int c = 0; c <= 7; c++)
                {


                    Console.Write(tablero1[f, c] + " ");
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            // Tablero jugador 2
            String[,] tablero2 = new String[8, 8];

            for (int f = 0; f <= 7; f++)
            {

                for (int c = 0; c <= 7; c++)
                {
                    tablero2[f, c] = " . ";
                }
            }

            Console.WriteLine("Este es tu tablero " + jugador2);

            // Mostrar matriz
            for (int f = 0; f <= 7; f++)
            {

                for (int c = 0; c <= 7; c++)
                {


                    Console.Write(tablero2[f, c] + " ");
                }
                Console.WriteLine(" ");
            }

            // Jugador 1 colocan sus naves
            int[] filasJugador1 = new int[3];
            int[] columnasJugador1 = new int[3];
            Console.WriteLine("");
            Console.WriteLine("Bien, que comiense el juego!");
            Console.WriteLine("Coloca las cordenadas donde estaran tus barcos " + jugador1 + "Recuerda usar cordenadas del 0 al 8");
            Console.WriteLine("Comiensa con la fila del barco 1");
            filasJugador1[0] = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Ahora la columna del barco 1");
            columnasJugador1[0] = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Comiensa con la fila del barco 2");
            filasJugador1[1] = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Ahora la columna del barco 2");
            columnasJugador1[1] = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Comiensa con la fila del barco 3");
            filasJugador1[2] = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Ahora la columna del barco 3");
            columnasJugador1[2] = Int16.Parse(Console.ReadLine());

            // Jugador 2 colocan sus naves
            int[] filasJugador2 = new int[3];
            int[] columnasJugador2 = new int[3];
            Console.WriteLine("");
            Console.WriteLine("Coloca las cordenadas donde estaran tus barcos " + jugador1 + "Recuerda usar cordenadas del 0 al 8");
            Console.WriteLine("Comiensa con la fila del barco 1");
            filasJugador2[0] = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Ahora la columna del barco 1");
            columnasJugador2[0] = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Comiensa con la fila del barco 2");
            filasJugador2[1] = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Ahora la columna del barco 2");
            columnasJugador2[1] = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Comiensa con la fila del barco 3");
            filasJugador2[2] = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Ahora la columna del barco 3");
            columnasJugador2[2] = Int16.Parse(Console.ReadLine());


            // Los jugadores tiran
            int contador1 = 0;
            int contador2 = 0;

            Console.WriteLine("Es tu turno de jugar " + jugador1);
            Console.WriteLine("Donde ceres que este el barco del contrincante?. Recuerda usar cordenadas del 0 al 8");
            Console.WriteLine("Comensemos con las filas");
            int filas = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Comensemos con las columnas");
            int columnas = Int32.Parse(Console.ReadLine());


            for (int k = 0; k < tablero1.Length; k++)
            {
                for (int h = 0; h <= 3;)
                {


                    for (int g = 0; g <= 3;)
                    {

                        if (filas == filasJugador2[0] && columnas == columnasJugador2[0])
                        {
                            Console.WriteLine("Hundido!");
                            Console.WriteLine("Felicidades ganaste otro tiro");
                            for (int f = 0; f <= 7; f++)
                            {
                                for (int c = 0; c <= 7; c++)
                                {
                                    Console.Write(tablero2[f, c] + " ");
                                    tablero2[filas, columnas] = " o ";
                                }
                                Console.WriteLine(" ");
                            }
                            Console.WriteLine("");
                            Console.WriteLine("Comensemos con las filas");
                            filas = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Comensemos con las columnas");
                            columnas = Int32.Parse(Console.ReadLine());
                            g = 4;
                            h++;
                            contador1++;
                        }
                        else
                        {
                            if (filas == filasJugador2[1] && columnas == columnasJugador2[1])
                            {
                                Console.WriteLine("Hundido!");
                                Console.WriteLine("Felicidades ganaste otro tiro");
                                for (int f = 0; f <= 7; f++)
                                {
                                    for (int c = 0; c <= 7; c++)
                                    {
                                        Console.Write(tablero2[f, c] + " ");
                                        tablero2[filas, columnas] = " o ";
                                    }
                                    Console.WriteLine(" ");
                                }
                                Console.WriteLine("");
                                Console.WriteLine("Comensemos con las filas");
                                filas = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Comensemos con las columnas");
                                columnas = Int32.Parse(Console.ReadLine());
                                g = 4;
                                h++;
                                contador1++;
                            }
                            else
                            {
                                if (filas == filasJugador2[2] && columnas == columnasJugador2[2])
                                {
                                    Console.WriteLine("Hundido!");
                                    Console.WriteLine("Felicidades ganaste otro tiro");
                                    for (int f = 0; f <= 7; f++)
                                    {
                                        for (int c = 0; c <= 7; c++)
                                        {
                                            Console.Write(tablero2[f, c] + " ");
                                            tablero2[filas, columnas] = " o ";
                                        }
                                        Console.WriteLine(" ");
                                    }
                                    Console.WriteLine("");
                                    Console.WriteLine("Comensemos con las filas");
                                    filas = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Comensemos con las columnas");
                                    columnas = Int32.Parse(Console.ReadLine());
                                    g = 4;
                                    h++;
                                    contador1++;
                                }
                                else
                                {
                                    Console.WriteLine("No es, sigue intentando");
                                    g = 4;
                                    h = 4;
                                }
                            }

                        }
                    }

                }


                Console.WriteLine("Es tu turno de jugar " + jugador2);
                Console.WriteLine("");
                Console.WriteLine("Comensemos con las filas");
                filas = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Comensemos con las columnas");
                columnas = Int32.Parse(Console.ReadLine());




                for (int h = 0; h <= 3;)
                {
                    // g = 0;

                    for (int g = 0; g <= 3;)
                    {

                        if (filas == filasJugador1[0] && columnas == columnasJugador1[0])
                        {
                            Console.WriteLine("Hundido!");
                            Console.WriteLine("Felicidades ganaste otro tiro");
                            for (int f = 0; f <= 7; f++)
                            {
                                for (int c = 0; c <= 7; c++)
                                {
                                    Console.Write(tablero2[f, c] + " ");
                                    tablero2[filas, columnas] = " o ";
                                }
                                Console.WriteLine(" ");
                            }
                            Console.WriteLine("");
                            Console.WriteLine("Comensemos con las filas");
                            filas = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Comensemos con las columnas");
                            columnas = Int32.Parse(Console.ReadLine());
                            g = 4;
                            h++;
                            contador2++;


                        }
                        else
                        {
                            if (filas == filasJugador1[1] && columnas == columnasJugador1[1])
                            {
                                Console.WriteLine("Hundido!");
                                Console.WriteLine("Felicidades ganaste otro tiro");
                                for (int f = 0; f <= 7; f++)
                                {
                                    for (int c = 0; c <= 7; c++)
                                    {
                                        Console.Write(tablero2[f, c] + " ");
                                        tablero2[filas, columnas] = " o ";
                                    }
                                    Console.WriteLine(" ");
                                }
                                Console.WriteLine("");
                                Console.WriteLine("Comensemos con las filas");
                                filas = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Comensemos con las columnas");
                                columnas = Int32.Parse(Console.ReadLine());
                                g = 4;
                                h++;
                                contador2++;
                            }
                            else
                            {
                                if (filas == filasJugador1[2] && columnas == columnasJugador1[2])
                                {
                                    Console.WriteLine("Hundido!");
                                    Console.WriteLine("Felicidades ganaste otro tiro");
                                    for (int f = 0; f <= 7; f++)
                                    {
                                        for (int c = 0; c <= 7; c++)
                                        {
                                            Console.Write(tablero2[f, c] + " ");
                                            tablero2[filas, columnas] = " o ";
                                        }
                                        Console.WriteLine(" ");
                                    }
                                    Console.WriteLine("");
                                    Console.WriteLine("Comensemos con las filas");
                                    filas = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Comensemos con las columnas");
                                    columnas = Int32.Parse(Console.ReadLine());
                                    g = 4;
                                    h++;
                                    contador2++;
                                }
                                else
                                {
                                    Console.WriteLine("No es, sigue intentando");
                                    g = 4;
                                    h = 4;
                                }
                            }

                        }
                    }

                }


                if (contador1 <= 3)
                {
                    k = 100;
                    Console.WriteLine("Eres el ganador");
                }
                if (contador2 <= 3)
                {
                    k = 100;
                    Console.WriteLine("Eres el ganador");
                }
            }


        }



    }
}

