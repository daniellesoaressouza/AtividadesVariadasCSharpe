using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double Idade1 = 0;
                double Idade2 = 0;
                double Idade3 = 0;
                double Idade4 = 0;
                double Idade5 = 0;


                Console.WriteLine("Diga a idade do primeiro aluno:");
                Idade1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Diga a idade do segundo aluno:");
                Idade2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Diga a idade do terceiro aluno:");
                Idade3 = double.Parse(Console.ReadLine());

                Console.WriteLine("Diga a idade do quarto aluno:");
                Idade4 = double.Parse(Console.ReadLine());

                Console.WriteLine("Diga a idade do quinto aluno:");
                Idade5 = double.Parse(Console.ReadLine());

                double media = (Idade1 + Idade2 + Idade3 + Idade4 + Idade5) / 5;

                Console.WriteLine("A media de idade dos alunos e:" + media);
                Console.ReadKey();
            }
            

            
            String condicao;

            Console.WriteLine("A danielle tem o namorado mais gato do mundo?");
            condicao = Console.ReadLine();


            if (condicao.Contains("sim"))
            {
                Console.WriteLine("Sim e verdade");

            }


            else
            {
                Console.WriteLine("voce e cego");

            }
            







           


            
           
        }
    }
}
