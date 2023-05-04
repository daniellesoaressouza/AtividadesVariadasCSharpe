using System;

namespace lista_5___6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random (DateTime.Now.Millisecond);
            int[] Vetor10 = new int[10] { rnd.Next(1,10), rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10) };
            int soma = 0;
            for (int i = 0; i<=9; i++)
            {
                Console.Write("{0}  ", Vetor10[i]);
                
                if(Vetor10[i]%2==0)
                {
                    soma = soma + 1;
                }
            }
            Console.WriteLine(" ");
            Console.Write("Quantidade de pares da tabela:"+" "+soma);   
               
        }
    }
}
