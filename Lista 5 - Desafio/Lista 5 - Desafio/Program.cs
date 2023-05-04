using System;

namespace Lista_5___Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numR = new int[10];
            Random rnd = new Random(DateTime.Now.Millisecond);
            int maiornum = 1;
            int menornum = 500;
            int media = 0;
            int soma = 0;

            for (int i = 0; i<numR.Length;i++)
            {
                int a = rnd.Next(1, 101);
                
               Console.Write((numR[i] = a) + "  ");

                if (maiornum<numR[i])
                {
                    maiornum = numR[i];
                }
                if (menornum > numR[i])
                {
                    menornum = numR[i];
                }
                soma = soma + numR[i];

            }
            media = soma / numR.Length;

           
            Console.WriteLine(" ");
            Console.WriteLine("media:" + " " + media);
            Console.WriteLine("Maior numero:" + " " + maiornum);
            Console.WriteLine("menor numero:" + " " + menornum);


        }
    }
}
