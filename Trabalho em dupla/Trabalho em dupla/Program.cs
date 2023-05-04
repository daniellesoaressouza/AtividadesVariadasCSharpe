using System;

namespace Trabalho_em_dupla
{
    class Program
    {
        static void Main(string[] args)
        {
            //Integrantes: Danielle Soares e Nicolly Sheroom


            //Váriaveis para a realização das operações 

            int opcao = 0;
            double numero1 = 0;
            double numero2 = 0;
            double raio = 0;
            double hipotenusa = 0;
            double respotencia = 0;
            double raiz = 0;

            while (opcao != 10)
            {
                //Impressão menu da calculadora; guia para o úsuario escolher qual operação o console vai realizar
                Console.Clear();
                Console.WriteLine("Escolha uma das opcoes de operacao para o calculo: \n 1 Soma \n 2 Subtracao \n 3 Multiplicação \n " +
                "4 Divisao \n 5 Area do circulo \n 6 Area do retangulo \n 7 Calculo Hipotenusa \n 8 Potenciacao \n 9 Raiz quadrada \n 10 Sair");
                opcao = int.Parse(Console.ReadLine());



                // Utilizamos if para cada opção possivel do úsuario escolher 

                if (opcao == 1)

                {
                    Console.WriteLine("Primeiro numero:");
                    numero1 = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Segundo numero:");
                    numero2 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Resultado:");
                    Console.WriteLine(numero1 + numero2);
                    Console.ReadLine();

                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Primeiro numero:");
                    numero1 = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Segundo numero:");
                    numero2 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Resultado:");
                    Console.WriteLine(numero1 - numero2);
                    Console.ReadLine();
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Primeiro numero:");
                    numero1 = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Segundo numero:");
                    numero2 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Resultado:");
                    Console.WriteLine(numero1 * numero2);
                    Console.ReadLine();
                }
                else if (opcao == 4)
                {
                    Console.WriteLine("Primeiro numero:");
                    numero1 = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Segundo numero:");
                    numero2 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Resultado:");
                    Console.WriteLine(numero1 / numero2);
                    Console.ReadLine();
                }

                // Para a area do ciculos, tem se uma várivel diferente que refere-se ao raio. Utilizamos π = 3,14.
                else if (opcao == 5)
                {
                    Console.WriteLine("Qual a medida do raio do circulo:");
                    raio = Double.Parse(Console.ReadLine());

                    
                    Console.WriteLine("Area do circulo:");
                    Console.WriteLine(3.14 * raio * raio);
                    Console.ReadLine();
                }
                else if (opcao == 6)
                {
                    Console.WriteLine("Base do retangulo:");
                    numero1 = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Altura do retangulo:");
                    numero2 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Resultado:");
                    Console.WriteLine(numero1 * numero2);
                    Console.ReadLine();
                }
                else if (opcao == 7)
                {
                    Console.WriteLine("Cateto A:");
                    numero1 = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Cateto B:");
                    numero2 = Double.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Resultado:");
                    
                    hipotenusa  = (numero1 * numero1) + (numero2 * numero2);
                    hipotenusa = Math.Sqrt(hipotenusa);
                    
                    Console.WriteLine(hipotenusa);
                    Console.ReadLine();
                     
                }
                else if (opcao == 8) 
                {
                    Console.WriteLine("digite o expoente da sua potência:");
                    numero1 = Double.Parse(Console.ReadLine());

                    Console.WriteLine("digite a base da sua potência:");
                    numero2 = Double.Parse(Console.ReadLine());


                    Console.WriteLine("Resultado:");
                    respotencia = Math.Pow(numero2, numero1);
                    Console.WriteLine(respotencia);
                    Console.ReadLine();
                    
                }
                else if (opcao == 9)
                {
                    Console.WriteLine("digite o radicando:");
                    numero1 = Double.Parse(Console.ReadLine());

                    Console.WriteLine("A raiz quadrada é:");
                    raiz = Math.Sqrt(numero1);
                    Console.WriteLine(raiz);
                    Console.ReadLine();
                }
            }
        }
    }
}
