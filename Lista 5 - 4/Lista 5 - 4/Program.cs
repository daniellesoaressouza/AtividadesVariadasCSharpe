using System;

namespace Lista_5___4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Posicoes = new int[12] { 6, 25, 31, 20, 55, 44, 23, 10, 13, 2, 17, 1 };
            
            
                Console.WriteLine("Digite um indice de uma tabela de 12 elementos:");
                int x = int.Parse(Console.ReadLine());


                Console.WriteLine("Digite um indice de uma tabela de 12 elementos:");
                int y = int.Parse(Console.ReadLine());
            
                while(x>12 || y>12)
               {
                     Console.Clear();
                     Console.WriteLine("Digite um indice válido:");
                     Console.WriteLine("Digite um indice de uma tabela de 12 elementos:");
                      x = int.Parse(Console.ReadLine());


                      Console.WriteLine("Digite um indice de uma tabela de 12 elementos:");
                      y = int.Parse(Console.ReadLine());
               }
           

            Console.WriteLine("A soma da posição"+" "+x + " "+"e posição"+ " "+y+" "+"é:"+" "+(Posicoes[x]+Posicoes[y]));




        }
    }
}
