using System;

namespace jogo2
{
    public class Ponto
    {
       public int x = 0;
       public int y = 0;

        public Ponto (int X,int Y)
        {
            x = X;
            y = Y;
        }
           
    }
    public class PlanoCartesiano
    {
        public Ponto P1, P2;
        public char[,] matriz = new char[20, 20];

        public PlanoCartesiano()
        {
            Console.WriteLine("Digite a coordenada X do ponto 1:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a coordenada Y do ponto 1:");
            int y = int.Parse(Console.ReadLine());

            P1 = new Ponto(x, y);
           
            Console.WriteLine("Digite a coordenada X do ponto 2:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a coordenada Y do ponto 2:");
            int b = int.Parse(Console.ReadLine());

            P2 = new Ponto(a, b);

        }


        public void Draw()
        {
            Console.Clear();
            for(int i = 0; i<matriz.GetLength(0);i++)
            {
                Console.WriteLine();
                for(int j = 0; i<matriz.GetLength(1);j++)
                {
                    Console.Write(matriz[i, j]);
                }
            }
        }
    }
    class outra
    {
        static void Main(string[] args)
        {
            Ponto i = new Ponto(15, 40);
            Console.WriteLine(i.x);
            Console.WriteLine(i.y);
        }  
    }

}
