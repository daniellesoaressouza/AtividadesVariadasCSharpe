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
        public static bool voltar;


        static void Main(string[] args)
        {
            A = new Dino();
            O = new Obstaculo();
            M = new Moedas();

            for (int i = 0; i < Mapa.GetLength(0); i++)
            {
                Mapa[14, i] = 'x';
            }

            Mapa[2, 2] = 'y';
            Mapa[3, 2] = 'y';
            Mapa[3, 1] = 'y';
            Mapa[3, 3] = 'y';



            TelaInicial();
            Console.Clear();
            derrota = false;
            vitoria = false;
            voltar = true;

            while (derrota == false && vitoria == false && voltar == true)
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
                    Console.Beep(280, 500);
                    Console.Beep(250, 600);
                    Console.Beep(200, 800);
                }
                else
                    derrota = false;

                if (pontos == 2)
                {
                    vitoria = true;
                    Console.Beep(1400, 150);
                    Console.Beep(1500, 250);
                    Console.Beep(1600, 270);
                    Console.Beep(1700, 600);
                    Console.Beep(1400, 150);
                    Console.Beep(1500, 250);
                    Console.Beep(1600, 270);
                    Console.Beep(1700, 600);
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
                if (derrota == true || vitoria == true)
                {
                    TelaFinal();
                }

            }

        }
        static void Draw()
        {
            Console.Clear();
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
                        Console.Write(" ");
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
  **FUJA DOS OBSTÁCULOS E COLETE 2 MOEDAS**

         ─▄▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▄
         █░░░█░░░░░░░░░░▄▄░██░█
         █░▀▀█▀▀░▄▀░▄▀░░▀▀░▄▄░█
         █░░░▀░░░▄▄▄▄▄░░██░▀▀░█
         ─▀▄▄▄▄▄▀─────▀▄▄▄▄▄▄▀

   ");
            Console.Beep(1900, 300);
            Console.Beep(1900, 350);
            Console.Beep(1600, 300);
            Console.Beep(1700, 300);
            Console.Beep(1600, 300);
            Console.Beep(1700, 250);
            Console.Beep(1900, 800);
            Console.Beep(1900, 300);
            Console.Beep(1900, 200);
            Console.Beep(1600, 200);
            Console.Beep(1700, 250);
            Console.Beep(1600, 250);
            Console.Beep(1700, 250);
            Console.Beep(1900, 800);
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public static void TelaFinal()
        {

            if (vitoria == true && derrota == false)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@" 
              **VOCÊ GANHOU!

          ───▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───
          ───█▒▒░░░░░░░░░▒▒█───
          ────█░░█░░░░░█░░█────
          ─▄▄──█░░░▀█▀░░░█──▄▄─
          █░░█─▀▄░░░░░░░▄▀─█░░█

     **Aperte 1 para jogar novamente");
            }


            else if (derrota == true && vitoria == false)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@" 
        **VOCÊ PERDEU.

     ▄██████████████▄▐█▄▄▄▄█▌
     ██████▌▄▌▄▐▐▌███▌▀▀██▀▀
     ████▄█▌▄▌▄▐▐▌▀███▄▄█▌
     ▄▄▄▄▄██████████████▀

   **Aperte 1 para jogar novamente");
            }
            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                voltar = true;
                pontos = 0;
                vitoria = false;
                derrota = false;
                A = new Dino();
                O = new Obstaculo();
                M = new Moedas();
                Console.Clear();
            }
            else if (escolha == 2)
            {
                vitoria = false;
                derrota = true;
                voltar = false;
            }

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
                    if (mapa[y + 1, x] == 'x')

                        Yvel = -1.8f;
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
            y = 7;
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

