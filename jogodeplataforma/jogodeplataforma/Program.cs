using System;
using System.Threading;

class Program
{
    public static char[,] Mapa = new char[20, 20];
    public static Personagem P;
    public static int timer = 0;
    public static Abelha A;
    static void Main(string[] args)
    {
        P = new Personagem();

        A = new Abelha(15, 9);

        for (int i = 0; i < Mapa.GetLength(0); i++)
        {
            Mapa[19, i] = 'x';
        }
        while (true)
        {
            P.Gravidade(Mapa);
            P.Input(Mapa);
            A.Move(timer);

            Draw();

            timer += 100;
            Thread.Sleep(100);
        }

    }

    static void Draw()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(A.Y);
        Console.BackgroundColor = ConsoleColor.Blue;
        for (int i = 0; i < Mapa.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < Mapa.GetLength(1); j++)
            {
                //Personagem está na posição que está sendo impressa
                if (P.X == j && P.Y == i)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(" ");
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                else if (Mapa[i, j] == 'x')
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write(" ");
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                else if (A.X == j && A.Y == i)
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
}

class Personagem
{
    public int X = 9, Y = 0;
    public float Yvel = 0;
    public float Ypos = 0;

    public Personagem()
    {
        /*
        X = 9;
        Y = 0;
        Ypos = 0;
        Yvel = 0;
        */
    }

    public void Gravidade(char[,] mapa)
    {
        Yvel += 0.3f;
        Ypos += Yvel;
        Y = (int)Ypos;
        //Caso o personagem chegue no limite do mapa, prende ele dentro da mapa
        if (Ypos >= 19)
        {
            Y = 18;
        }

        if (Ypos < 0)
        {
            Y = 0;
        }
        //Se no mapa tiver o X(Chao), zera a velocidade
        if (mapa[Y + 1, X] == 'x')
        {
            Yvel = 0;
            Ypos = Y;
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
                Yvel = -3f;
            }

            if (cki.Key == ConsoleKey.RightArrow)
            {

                if (X < 19 && mapa[Y, X + 1] != 'x')
                    X++;

            }

            if (cki.Key == ConsoleKey.LeftArrow)
            {
                if (X > 0 && mapa[Y, X - 1] != 'x')
                    X--;
            }

        }
    }
}

class Abelha
{
    public int X, Y;
    public int Yinicial;
    public int XMinimo, XMaximo;
    int Vel = 1;
    public Abelha(int x, int yinicial)
    {
        Yinicial = yinicial;
        X = x;

        XMinimo = x - 2;
        XMaximo = x + 2;
    }

    public void Move(int timer)
    {
        Y = (int)(Yinicial + MathF.Sin(timer) * 3);

        if (X < XMinimo || X > XMaximo)
            Vel *= -1;

        X += Vel;
    }
}

