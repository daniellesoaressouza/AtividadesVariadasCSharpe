using System;

namespace questao_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1; string a2; string a3; string a4; string a5;
            float nt1; float nt2; float nt3; float nt4; float nt5;

            Console.WriteLine("Calcule a média de 5 alunos.");
            Console.WriteLine("  ");
            Console.WriteLine("Nota e nome primeiro aluno:");
            Console.WriteLine("Nome:");
            a1 = Console.ReadLine();
            Console.WriteLine("Nota:");
            nt1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Nota e nome segundo aluno:");
            Console.WriteLine("Nome:");
            a2 = Console.ReadLine();
            Console.WriteLine("Nota:");
            nt2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Nota e nome terceiro aluno:");
            Console.WriteLine("Nome:");
            a3 = Console.ReadLine();
            Console.WriteLine("Nota:");
            nt3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Nota e nome quarto aluno:");
            Console.WriteLine("Nome:");
            a4 = Console.ReadLine();
            Console.WriteLine("Nota:");
            nt4 = float.Parse(Console.ReadLine());

            Console.WriteLine("Nota e nome quinto aluno:");
            Console.WriteLine("Nome:");
            a5 = Console.ReadLine();
            Console.WriteLine("Nota:");
            nt5 = float.Parse(Console.ReadLine());

            MediaAlunos(nt1, nt2, nt3, nt4, nt5,a1,a2,a3,a4,a5);
        }
        static void MediaAlunos(float n1, float n2, float n3, float n4, float n5, string al1, string al2, string al3, string al4, string al5)
        {
            double media = 0;
            
            media = (n1 + n2 + n3 + n4 + n5) / 5;
            Console.WriteLine("A média deles é" + " " + media);
            if (n1 > n2 && n1 > n3 && n1 > n4 && n1 > n5)
            {
                Console.WriteLine("A maior nota é do aluno (a)" + " " +al1+ " " +"sua nota é"+" "+n1);
            }
            if (n2 > n1 && n2 > n3 && n2 > n4 && n2 > n5)
            {
                Console.WriteLine("A maior nota é do aluno (a)" + " " + al2 + " " + "sua nota é" + " " + n2);
            }
            if (n3 > n2 && n3 > n2 && n3 > n4 && n3 > 5)
            {
                Console.WriteLine("A maior nota é do aluno (a)" + " " + al3 + " " + "sua nota é" + " " + n3);
            }
            if (n4 > n2 && n4 > n3 && n4 > n1 && n4 > n5)
            {
                Console.WriteLine("A maior nota é do aluno (a)" + " " + al4 + " " + "sua nota é" + " " + n4);
            }
            if (n5 > n2 && n5 > n3 && n5 > n4 && n5 > n1)
            {
                Console.WriteLine("A maior nota é do aluno (a)" + " " + al5 + " " + "sua nota é" + " " + n5);
            }
            if (n1 < n2 && n1 < n3 && n1 < n4 && n1 < n5)
            {
                Console.WriteLine("A menor nota é do aluno (a)" + " " + al1 + " " + "sua nota é" + " " + n1);
            }
             if (n2 < n1 && n2 < n3 && n2 < n4 && n2 < n5)
            {
                Console.WriteLine("A menor nota é do aluno (a)" + " " + al2 + " " + "sua nota é" + " " + n2);
            }
            if (n3 < n2 && n3 < n1 && n3 < n4 && n3 < n5)
            {
                Console.WriteLine("A menor nota é do aluno (a)" + " " + al3 + " " + "sua nota é" + " " + n3);
            }
            if (n4 < n2 && n4 < n3 && n4 < n1 && n4 < n5)
            {
                Console.WriteLine("A menor nota é do aluno (a)" + " " + al4 + " " + "sua nota é" + " " + n4);
            }
            if (n5 < n2 && n5 < n3 && n5 < n4 && n5 < n1)
            {
                Console.WriteLine("A menor nota é do aluno (a)" + " " + al5 + " " + "sua nota é," + " " + n5);
            }
        }

    }
}
