using System;

namespace desafioDanio
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] QuestMT = new string[5]
        {
                "Qual o elemento AU da tabela periódica?",
                "Quantas casas decimais possui π?",
                "Qual o maior oceano do mundo?",
                "Qual o maior arquepelago da terra?",
                "Quem foi o autor de O Principe?"
        };
            string[] QuestABT = new string[5]
        {
               "Qual a quatidade mínima de jogares para iniciar uma partida de futebol?",
               "Qual país inventou o chuveiro elétrico?",
               "Qual país possuí o formato de bota?",
               "Qual a formula da água?",
               "Qual o menor e maior país do mundo?"
        };
            string[] RespostasABT = new string[5]
     {
               "7",
               "Brasil",
               "Itália",
               "H2O",
               "Vaticano e Rússia"
     };
            string[] dicaAB1 = new string[3] {"Dica1","Dica2","Dica3"};
            string[] dicaAB2 = new string[3] {"Dica1","Dica2","Dica3" };
            string[] dicaAB3 = new string[3] {"Dica1","Dica2","Dica3" };
            string[] dicaAB4 = new string[3] {"Dica1", "Dica2", "Dica3"};
            string[] dicaAB5 = new string[3] {"Dica1", "Dica2", "Dica3"};

            Console.WriteLine("Digite seu nome.");
            string nome = Console.ReadLine();

            QuestAB(QuestABT, RespostasABT, dicaAB1);

        }
        static void QuestAB(string[] a, string[] b, string[] c)
        {
            string resp;
            for (int i = 0; i<=3;i++)
            {
                Console.WriteLine(a[i]);
                resp = Console.ReadLine();
                if (resp == b[i])
                {
                    Console.WriteLine("Certa resposta!");
                }
                else if(resp!=b[i])
                {
                    Console.WriteLine(c[0]);
                    Console.WriteLine("Tente novamente:");
                    resp = Console.ReadLine();
                }
                else if(resp!=b[i])
                {
                    Console.WriteLine(c[1]);
                    Console.WriteLine("Tente novamente:");
                    resp = Console.ReadLine();
                }
                else if(resp!=b[i])
                {
                    Console.WriteLine(c[2]);
                    Console.WriteLine("Tente novamente:");
                    resp = Console.ReadLine();
                }
               
            }
        }
    }
}
