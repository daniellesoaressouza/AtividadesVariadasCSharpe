using System;

namespace Desafio_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int l1a = rnd.Next(1, 11), l1b = rnd.Next(1, 11), l1c = rnd.Next(1, 11);
            int l2a = rnd.Next(1, 11), l2b = rnd.Next(1, 11), l2c = rnd.Next(1, 11);
            int l3a = rnd.Next(1, 11), l3b = rnd.Next(1, 11), l3c = rnd.Next(1, 11);

           

            Console.Write(l1a + " "+ l2a+" " + l3a);
            Console.WriteLine(" ");
            Console.Write(l1b + " " + l2b + " " + l3b);
            Console.WriteLine(" ");
            Console.Write(l1c + " " + l2c + " " + l3c);
           

            int somal1 = l1a + l2a + l3a;
            int somal2 = l1b + l2b + l3b;
            int somal3 = l1c + l2c + l3c;

            int multil1 = l1a * l1b * l1c;
            int multil2 = l2a * l2b * l2c;
            int multil3 = l3a * l3b * l3c;
            Console.WriteLine(" ");

            if (somal1 > somal2 && somal1 > somal3)
            {
                Console.WriteLine("A primeira linha possui a maior soma:" + " " + somal1);
            }
            else if (somal2 > somal1 && somal2 > somal3)
            {
                Console.WriteLine("A segunda linha possui a maior soma:" + " " + somal2);
            }
            else if (somal3 > somal1 && somal3 > somal2)
            {
                Console.WriteLine("A terceira linha possui a maior soma:" + " " + somal3);
            }

            //Multiplicação

            if (multil1 > multil2 && multil1 > multil3)
            {
                Console.WriteLine("A primeira coluna possui o maior produto:" + " " + multil1);
            }
            else if (multil2 > multil1 && multil2 > multil3)
            {
                Console.WriteLine("A segunda coluna possui o maior produto:" + " " + multil2);
            }
            else if (multil3 > multil1 && multil3 > multil2)
            {
                Console.WriteLine("A terceira coluna possui o maior produto:" + " " + multil3);
            }



        }
    }
}
