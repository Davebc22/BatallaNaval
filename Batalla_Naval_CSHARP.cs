using System;

namespace BatallaNaval
{
    class Program
    {
        static string[,] tablero = new string[11, 11];
        static int posicion, longitud, coordenadaX, coordenadaY, coordenadaXA, coordenadaYA;

        static void Main(string[] args)
        {
            Tablero();
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("\nTienes 10 oportunidades para adivinar la posición del barco. El barco va a estar ubicado en posición horizontal o vertical (0=Horizontal , 1=vertical)");
            SeleccionPosicion();
            Console.WriteLine("Cuál será la longitud del barco: de 3 ó 4 posiciones");
            SeleccionLongitud();
            Console.WriteLine("\nDónde empezará el barco, ingrese la coordenada de la forma (x,y)");
            SeleccionCoordenadaInicial();
            Console.WriteLine("Dónde puede estar el barco, ingrese la coordenada de la forma (x,y)");
            SeleccionCoordenadaAtaque();
            Menu2();
        }

        static void Menu2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\nDónde puede estar el barco, ingrese la coordenada de la forma (x,y)");
                SeleccionCoordenadaAtaque();
            }
        }

        static void Tablero()
        {
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    tablero[0, j] = "Y" + j;
                    tablero[i, 0] = "X" + i;
                    tablero[i, j] = "~";
                }
            }

            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Console.Write($"{tablero[i, j],-7}");
                }
                Console.WriteLine();
            }
        }

        static void TableroActualizacion()
        {
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    tablero[0, j] = "Y" + j;
                    tablero[i, 0] = "X" + i;

                    if (i == coordenadaXA && j == coordenadaYA)
                    {
                        tablero[coordenadaXA, coordenadaYA] = "x";
                    }
                    else if (tablero[i, j] == "x")
                    {
                    
                    }
                    else if (posicion == 0 && longitud == 3)
                    {
                        if (i == coordenadaX && j >= coordenadaY && j < coordenadaY + 3)
                        {
                            tablero[i, j] = "0";
                        }
                    }
                    else if (posicion == 1 && longitud == 3)
                    {
                        if (j == coordenadaY && i >= coordenadaX && i < coordenadaX + 3)
                        {
                            tablero[i, j] = "0";
                        }
                    }
                    else if (posicion == 0 && longitud == 4)
                    {
                        if (i == coordenadaX && j >= coordenadaY && j < coordenadaY + 4)
                        {
                            tablero[i, j] = "0";
                        }
                    }
                    else if (posicion == 1 && longitud == 4)
                    {
                        if (j == coordenadaY && i >= coordenadaX && i < coordenadaX + 4)
                        {
                            tablero[i, j] = "0";
                        }
                    }
                    else
                    {
                        tablero[i, j] = "~";
                    }
                }
            }

            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Console.Write($"{tablero[i, j],-7}");
                }
                Console.WriteLine();
            }
        }

        static void SeleccionPosicion()
        {
            posicion = Convert.ToInt32(Console.ReadLine());
            while (posicion < 0 || posicion > 1)
            {
                Console.WriteLine("Seleccione la opción correcta");
                posicion = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void SeleccionLongitud()
        {
            longitud = Convert.ToInt32(Console.ReadLine());
            while (longitud < 3 || longitud >= 5)
            {
                Console.WriteLine("Seleccione la opción correcta");
                longitud = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void SeleccionCoordenadaInicial()
        {
            Console.WriteLine("Coordenada x");
            coordenadaX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Coordenada y");
            coordenadaY = Convert.ToInt32(Console.ReadLine());

            while (coordenadaX < 1 || coordenadaX > 10 || coordenadaY < 1 || coordenadaY > 10)
            {
                Console.WriteLine("Seleccionó una opción incorrecta o para x o para y \ningrese la coordenada de la forma (x,y)");
                Console.WriteLine("\nCoordenada x");
                coordenadaX = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Coordenada y");
                coordenadaY = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void SeleccionCoordenadaAtaque()
        {
            Console.WriteLine("Coordenada x");
            coordenadaXA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Coordenada y");
            coordenadaYA = Convert.ToInt32(Console.ReadLine());

            while (coordenadaXA < 1 || coordenadaXA > 10 || coordenadaYA < 1 || coordenadaYA > 10)
            {
                Console.WriteLine("Seleccionó una opción incorrecta o para x o para y \ningrese la coordenada de la forma (x,y)");
                Console.WriteLine("\nCoordenada x");
                coordenadaXA = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Coordenada y");
                coordenadaYA = Convert.ToInt32(Console.ReadLine());
            }

            if (tablero[coordenadaXA, coordenadaYA] == "0")
            {
                Console.WriteLine("¡Acierto! Ha atacado un barco.\n");
                
            }
            else
            {
                Console.WriteLine("¡Desacierto! No ha atacado un barco.\n");
                
            }

            TableroActualizacion();
        }
    }
}
