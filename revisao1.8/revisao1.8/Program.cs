using System;

namespace revisao1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça  um  algoritmo  que  leia  o  valor  de  uma  mercadoria  e  o  percentual  de desconto.
            //O algoritmo deve exibir o novo valor da mercadoria com desconto.

            Console.WriteLine("Valor mercadoria:");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("desconto mercadoria (%):");
            double desconto = double.Parse(Console.ReadLine());

            double descontofinal = (preco * desconto / 100);
            double valorFinal = preco - descontofinal;

            Console.WriteLine("Valor final:" + " R$" + valorFinal);



        }
    }
}
