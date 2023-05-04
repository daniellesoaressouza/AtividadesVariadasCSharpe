using System;

namespace Questão_10_
{
    class Program
    {
        static void Main(string[] args)
        {
            char nota;
            Console.WriteLine("Descubra o status da sua nota. Digite ela:");
            nota = char.Parse(Console.ReadLine());
            while (nota != 'a' && nota != 'A' && nota != 'c' && nota != 'C' && nota != 'e' && nota != 'E' && nota != 'F' && nota != 'f' && nota != 'g' && nota != 'G')
            {
                Console.Clear();
                Console.WriteLine("Digite uma nota válida.");
                nota = char.Parse(Console.ReadLine());
            }

            Notas(nota);
        }
        static void Notas(char nota)
        {
            if (nota == 'A')
            {
                Console.WriteLine("Excelente.");  
                
            }
            if (nota == 'a')
            {
                Console.WriteLine("Excelente.");
            }
            if (nota == 'C')
            {
                Console.WriteLine("Muito Bom.");
            }
            if (nota == 'c')
            {
                Console.WriteLine("Muito Bom.");
            }
            if (nota == 'E')
            {
                Console.WriteLine("Bom.");
            }
            if (nota == 'e')
            {
                Console.WriteLine("Bom.");
            }
            if (nota == 'F')
            {
                Console.WriteLine("Média.");
            }
            if (nota == 'f')
            {
                Console.WriteLine("Média.");
            }
            if (nota == 'G')
            {
                Console.WriteLine("Falhou");
            }
            if (nota == 'g')
            {
                Console.WriteLine("Falhou.");
            }
        }
    }
}
