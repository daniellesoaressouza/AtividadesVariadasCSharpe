using System;

namespace desafiopts
{
    public class Ponto2D
    {
        public int X;
        public int Y;

        public Ponto2D(int x, int y )
        {
            X = x;
            Y = y;
        }
         public void Input()
        {
            Console.WriteLine("Escolha uma posição: Cima, baixo, esquerda ou direita.");
            string posicao = Console.ReadLine();

            if (posicao == "cima")
            {
                Y--;
            }
            else if (posicao == "baixo")
            {
                Y++;
            }
            else if (posicao == "esquerda")
            {
                X--;
            }
            else if(posicao == "direita")
            {
                X++;
            }
        }
    }
    class Plano
    {
        public char[,] Matriz = new char[20, 20];
        public Ponto2D P1;

        //-Implementar um construtor que instancia a variável ponto 2D com números aleatórios para x e y de 0 até 19
        public Plano ()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            
            P1 = new Ponto2D(rnd.Next(0, 20), rnd.Next(0, 20));
        }

        public void Draw()
        {
            Console.Clear();
            for(int i = 0; i<Matriz.GetLength(0);i++)
            {
                Console.WriteLine();

                for(int j = 0; j<Matriz.GetLength(1);j++)
                {
                    Console.Write(Matriz[i, j] + " ");
                }
            }
        }
        public void ReceiveInput()
        {
            //-Implementar uma função ReceiveInput() que irá preencher a matriz com ‘ ‘ (espaço), e na posição do
            //ponto 2D preencher com ‘X
            for (int i = 0; i<Matriz.GetLength(0);i++)
            {
                for(int j = 0; j<Matriz.GetLength(1);j++)
                {
                    if (i == P1.Y && j == P1.X )
                    {
                        Matriz[i, j] = 'x';
                    }
                    else
                    {
                        Matriz[i, j] = ' ';
                    }
                }
            }
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Plano plano = new Plano();
            plano.ReceiveInput();
            plano.Draw();

            while(true)
            {
                plano.P1.Input();
                plano.ReceiveInput();
                plano.Draw();
            }


        }
    }
}
