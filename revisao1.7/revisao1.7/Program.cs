using System;

namespace revisao1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um algoritmo para ler o ano de nascimento de uma pessoa e imprima que idade terá no ano corrente.

            Console.WriteLine("Digite seu ano de nascimento:");
            int ano = int.Parse(Console.ReadLine());
            int idade = 0;
            while(ano<=2021)
            {
                ano++;
                idade++;
               
            }
            Console.WriteLine("sua idade atual:"+idade+"\nSua idade no ano seguinte:"+(idade+1));
        }
    }
}
