using System;

namespace Lista_4___Questão_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random N = new Random(DateTime.Now.Millisecond);
            int inteiro = N.Next(1,50);

            for (int i = 0; i<=10; i++)
            {
                Console.WriteLine(inteiro);
               inteiro = N.Next(1, 50);
            }
            
        }
    }
}
