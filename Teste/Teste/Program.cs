using System;
using System.Threading;

namespace Teste
{
    class Program
    {
        static ConsoleKeyInfo cki;
        //Enviroment variables
        static int MapSizeX = 10;
        static int MapSizeY = 20;
        static int MilisecondsToRespawn = 5000;

        //Player positions
        static int x = 0;
        static int y = 0;

        //Points positions
        static int xo = 0, yo = 0;

        static int Pontos = 0;
        static bool game = true;
        static uint timer = 0;

        public static void Main(string[] args)
        {

            while (game)
            {
                if (Pontos == 10)
                {
                    game = false;
                    Win();
                }
                Inputs();
                Gotcha();
                Draw();
                Thread.Sleep(17);
                timer += 17;
            }
        }
        static void Win()
        {
            Console.Clear();
            Console.WriteLine("Parabens vc ganhou!");
        }
        static bool Gotcha()
        {
            if (x == xo && y == yo)
            {
                Pontos++;
                RandomizePos();
                timer = 0;
                return true;
            }
            else if (timer > MilisecondsToRespawn)
            {
                RandomizePos();
                timer = 0;
                Draw();
                return false;
            }
            else
                return false;
        }

        static void RandomizePos()
        {
            Random rnd = new Random(System.DateTime.Now.Millisecond);
            xo = rnd.Next(0, MapSizeX);
            yo = rnd.Next(0, MapSizeY);
        }

        static void Draw()
        {
            Console.Clear();
            Console.WriteLine("Points: ");
            if (Pontos > 0)
            {
                for (int i = 0; i < Pontos; i++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("o ");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }
            Console.WriteLine("\n");
            for (int i = -1; i <= MapSizeX; i++)
            {
                for (int j = -1; j <= MapSizeY; j++)
                {

                    if (i == x && j == y)
                    {
                        Console.Write("A");
                    }

                    if (i == xo && j == yo)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("o");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i == -1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("X ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i == MapSizeX)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("X ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (j == -1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("X ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (j == MapSizeY)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("X");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {

                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("X: {0}\nY:{1}", x, y);
        }

        static bool Inputs()
        {
            if (Console.KeyAvailable)
            {
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.DownArrow)
                {
                    if (x < MapSizeX - 1)
                    {
                        x++;
                        return true;
                    }
                }
                else if (cki.Key == ConsoleKey.UpArrow)
                {
                    if (x > 0)
                    {
                        x--;
                        return true;
                    }
                }

                if (cki.Key == ConsoleKey.RightArrow)
                {
                    if (y < MapSizeY - 1)
                    {
                        y++;
                        return true;
                    }
                }
                else if (cki.Key == ConsoleKey.LeftArrow)
                {
                    if (y > 0)
                    {
                        y--;
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
