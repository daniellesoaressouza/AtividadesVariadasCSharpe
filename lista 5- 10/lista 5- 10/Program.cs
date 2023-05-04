using System;

namespace lista_5__10
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] gabarito = new char[10] { 'a', 'b', 'c', 'a', 'd', 'd', 'c', 'a', 'c', 'b' };

            Console.WriteLine("Em uma prova com 10 questões fechadas com 4 opções cada (a,b,c,d), corrija a prova de 5 alunos.");

            char[] Gabriela = new char[10];
            char[] Julio = new char[10];
            char[] Maria = new char[10];
            char[] Estevam = new char[10];
            char[] Renata = new char[10];
            int acertos = 0, acertos2 =0, acertos3=0, acertos4=0, acertos5=0;
            Console.Write("Gabarito: ");
            for(int i = 0; i<=9;i++)
            {
                Console.Write (" " + gabarito[i]);
                
            }
            Console.WriteLine("\n");
            Console.WriteLine("Digite respostas da Gabriela:");
            for (int i = 0; i<=9;i++)
            {
                Console.Write("Resposta:");
                char B = char.Parse(Console.ReadLine());
                Gabriela[i] = B; 
                if (Gabriela[i] == gabarito[i])
                {
                    acertos++;
                    
                }
            }
            Console.Clear();
            Console.WriteLine("Acertos de Gabriela:" + " " + acertos);
            
            Console.WriteLine("Digite respostas de Julio:");
            for (int i = 0; i <= 9; i++)
            {
                Console.Write("Resposta:");
                char B = char.Parse(Console.ReadLine());
                Julio[i] = B;
                if (Julio[i] == gabarito[i])
                {
                    acertos2++;

                }
            }
            Console.Clear();
            Console.WriteLine("Acertos de Julio:" + " " + acertos2);

            Console.WriteLine("Digite respostas de Maria:");
            for (int i = 0; i <= 9; i++)
            {
                Console.Write("Resposta:");
                char B = char.Parse(Console.ReadLine());
                Maria[i] = B;
                if (Maria[i] == gabarito[i])
                {
                    acertos3++;

                }
            }
            Console.Clear();
            Console.WriteLine("Acertos de Maria:" + " " + acertos3);

            Console.WriteLine("Digite respostas de Estevam:");
            for (int i = 0; i <= 9; i++)
            {
                Console.Write("Resposta:");
                char B = char.Parse(Console.ReadLine());
                Estevam[i] = B;
                if (Estevam[i] == gabarito[i])
                {
                    acertos4++;

                }
            }
            Console.Clear();
            Console.WriteLine("Acertos de Estevam:" + " " + acertos4);

            Console.WriteLine("Digite respostas de Renata:");
            for (int i = 0; i <= 9; i++)
            {
                Console.Write("Resposta:");
                char B = char.Parse(Console.ReadLine());
                Renata[i] = B;
                if (Renata[i] == gabarito[i])
                {
                    acertos5++;

                }
            }
            Console.Clear();

            Console.Write("Gabarito: ");
            for (int i = 0; i <= 9; i++)
            {
                Console.Write(" " + gabarito[i]);

            }
            Console.WriteLine("\n");

            Console.WriteLine("Acertos de Renata:" + " " + acertos5);
            AprovReprov(acertos5);
            ImprimeResp(Renata);
            Console.WriteLine("Acertos de Estevam:" + " " + acertos4);
            AprovReprov(acertos4);
            ImprimeResp(Estevam);
            Console.WriteLine("Acertos de Maria:" + " " + acertos3);
            AprovReprov(acertos3);
            ImprimeResp(Maria);
            Console.WriteLine("Acertos de Julio:" + " " + acertos2);
            AprovReprov(acertos2);
            ImprimeResp(Julio);
            Console.WriteLine("Acertos de Gabriela:" + " " + acertos);
            AprovReprov(acertos);
            ImprimeResp(Gabriela);
        }
        static void ImprimeResp(char[] r)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < r.Length; i++)
            {
                Console.Write(" " + r[i]);
            }

            Console.WriteLine("\n");
        }
        static void AprovReprov(int i)
        {
            
            if(i>=6)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado.");
            }
        }

    }
}
