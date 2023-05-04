using System;
using System.Threading;

namespace JogoDino
{
    class Program
    {
        public static char[,] Mapa = new char[15, 15];
        public static Dino A;
        public static Obstaculo O;
        public static Moedas M;
        public static int pontos = 0;
        public static int timer = 0;
        public static bool derrota;
        public static bool vitoria;
        public static int replay = 0;




        static void Main(string[] args)
        {
            A = new Dino();
            O = new Obstaculo();
            M = new Moedas();

            for (int i = 0; i < Mapa.GetLength(0); i++)
            {
                Mapa[14, i] = 'x';
            }
            for (int i = 0; i < Mapa.GetLength(0); i++)
            {
                Mapa[2, 2] = 'y';

            }

            TelaInicial();
            Console.ReadKey();
            Console.Clear();

            while (derrota == false || vitoria == true)
            {

                A.Gravidade(Mapa);
                A.Input(Mapa);
                O.move(Mapa);
                M.move();
                ponto(ref pontos);
                Draw();
                if (A.x == O.x && A.y == O.y)
                {
                    derrota = true;
                }
                else
                    derrota = false;

                if (pontos == 2)
                {
                    vitoria = true;

                }
                else
                    vitoria = false;

                if (timer % 1000 <= 10)
                {
                    M = new Moedas();
                }
                if (timer % 700 <= 10)
                {
                    O = new Obstaculo();
                }
                Thread.Sleep(10);
                timer += 10;
            }

        }
        static void Draw()
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" Pontos: " + pontos);
            Console.Write(" Tempo: " + timer);
            Console.WriteLine(A.y);
            Console.BackgroundColor = ConsoleColor.Blue;

            for (int i = 0; i < Mapa.GetLength(0); i++)
            {
                Console.WriteLine();

                for (int j = 0; j < Mapa.GetLength(1); j++)
                {

                    if (A.x == j && A.y == i)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(" ");
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else if (Mapa[i, j] == 'x')
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(" ");
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else if (Mapa[i, j] == 'y')
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("     \n         \n            ");
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }

                    else if (O.x == j && O.y == i)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.Write(" ");
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }

                    else if (M.x == j && M.y == i)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write(" ");
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }

                    else
                        Console.Write(Mapa[i, j]);



                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
        static void TelaInicial()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@" 
  **FUJA DOS OBSTÁCULOS E COLETE 5 MOEDAS**

         ─▄▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▄
         █░░░█░░░░░░░░░░▄▄░██░█
         █░▀▀█▀▀░▄▀░▄▀░░▀▀░▄▄░█
         █░░░▀░░░▄▄▄▄▄░░██░▀▀░█
         ─▀▄▄▄▄▄▀─────▀▄▄▄▄▄▄▀

   **Aperte qualquer tecla para continuar**");
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public static void ponto(ref int qponto)
        {

            if (M.x == A.x && M.y == A.y)
            {
                M = new Moedas();
                qponto++;
            }

        }
    }

    class Dino
    {
        public int x = 0, y = 0;
        public int vida = 0;
        public float Yvel = 0;
        public float Ypos = 0;

        public Dino(int X = 2, int Y = 0)
        {
            x = X;
            y = Y;
            Ypos = 0;
            Yvel = 0;

        }
        public void Gravidade(char[,] mapa)
        {
            Yvel += 0.2f;
            Ypos += Yvel;
            y = (int)Ypos;

            if (y >= 14)
            {
                y = 13;
            }
            if (y < 0)
            {
                y = 0;
            }
            if (mapa[y + 1, x] == 'x')
            {
                Yvel = 0;
                Ypos = y;
            }
        }
        public void Input(char[,] mapa)
        {
            ConsoleKeyInfo cki;

            if (Console.KeyAvailable)
            {
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.UpArrow)
                {
                    Yvel = -1.5f;
                }
                if (cki.Key == ConsoleKey.RightArrow)
                {

                    if (x < 14 && mapa[y, x + 1] != 'x')
                        x++;

                }

                if (cki.Key == ConsoleKey.LeftArrow)
                {
                    if (x > 0 && mapa[y, x - 1] != 'x')
                        x--;
                }
            }

        }
    }
    class Obstaculo
    {
        public int x = 0, y = 0;
        public float Xpos = 0;


        public Obstaculo()
        {
            x = 15;
            y = 13;
            Xpos = 15;

        }
        public void move(char[,] mapa)
        {
            x = (int)Xpos;
            Xpos -= 0.2f;


        }
    }
    class Moedas
    {
        public int x = 0, y = 0;
        public float Xpos = 0;

        public Moedas()
        {
            x = 15;
            y = 10;
            Xpos = 15;
        }
        public void move()
        {
            x = (int)Xpos;
            Xpos -= 0.3f;
            if (x == 0)
            {

            }

        }
    }


}



