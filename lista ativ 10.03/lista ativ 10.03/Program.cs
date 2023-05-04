using System;

namespace lista_ativ_10._03
{
    class Program
    {
        static void Main(string[] args)
        {
            String R;
            Console.WriteLine("Qual o seu nome?");
            R = Console.ReadLine();
            Nome(R);
           


        }
        static void Nome(string n) 
        {
            Console.WriteLine("Oi, meu nome é" + " " + n);
         
        }

        

    }
}
