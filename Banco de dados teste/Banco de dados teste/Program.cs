using System;

namespace Banco_de_dados_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            //imprimir a soma dos elmentos de um array
            int[] tabela1 = new int[10] { 10, 15, 26, 30, 55, 21, 3, 14, 12, 30 };
            int soma = 0;
            for(int i = 0; i<10;i++)
            {
                soma = soma + tabela1[i];
            }
            Console.WriteLine(soma);


        }
    }
}
