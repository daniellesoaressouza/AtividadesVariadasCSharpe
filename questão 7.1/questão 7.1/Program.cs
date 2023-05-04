using System;

namespace questão_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double el; double vb; double vn; double vv; double tt;

            Console.WriteLine("Digite quantos eleitores votaram na última eleição em Belo Horizonte:");
            el = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos votos foram em branco?");
            vb = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos foram nulos?");
            vn = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos votos válidos?");
            vv = double.Parse(Console.ReadLine());

            while(el < (vb+vn+vv) || el > (vb + vn + vv))
            {
                Console.Clear();
                Console.WriteLine("Dados informados invalidos. Digite novamente.");
                Console.WriteLine("Digite quantos eleitores votaram na última eleição em Belo Horizonte:");
                el = double.Parse(Console.ReadLine());

                Console.WriteLine("Quantos votos foram em branco?");
                vb = double.Parse(Console.ReadLine());

                Console.WriteLine("Quantos foram nulos?");
                vn = double.Parse(Console.ReadLine());

                Console.WriteLine("Quantos votos válidos?");
                vv = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Os votos em branco representam"+" "+vb * el/100+"% dos eleitores");
            Console.WriteLine("Os votos nulos representam" + " " + vn * el / 100 + "% dos eleitores");
            Console.WriteLine("Os votos válidos representam" + " " + vv * el / 100 + "% dos eleitores");





        }
    }
}
