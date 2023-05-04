using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Questão 1)
            float x = 0;
            float y = 0;

            Console.WriteLine("Determine uma coordenada e descubra em qual quadrante do plano cartesiano ela se encontra.");

            Console.WriteLine("Valor de X:");
            x = float.Parse(Console.ReadLine());

            Console.WriteLine("Valor de Y:");
            y = float.Parse(Console.ReadLine());


            if (x < 0 && y > 0)
            {
                Console.WriteLine("Coordenadas" + " "+ x + ","+ y + " " + "localizada no segundo quadrante.");
            }
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Coordenadas" + " " + x + "," + y + " " + "localizada no primeiro quadrante.");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine("Coordenadas" + " " + x + "," + y + " " + "localizada no terceiro quadrante.");
            }
            if (x > 0 && y< 0)
            {
                Console.WriteLine("Coordenadas" + " " + x + "," + y + " " + "localizada no quarto quadrante.");
            }
            */
            //Questão 2)
            float A = 0;
            float B = 0;
            float Resultado = 0;
            float resultado = 0;
            float dobro = 0;
            Console.WriteLine("Vamos subtrair dois números.");

            Console.WriteLine("Valor primeiro número:");
            A = float.Parse(Console.ReadLine());

            Console.WriteLine("Valor segundo número:");
            B = float.Parse(Console.ReadLine());

            if(A>B)
            {
                Resultado = A - B;
                Console.WriteLine("Resultado:" + " " + Resultado);
                
                if(Resultado < 0)
                {
                    resultado = Resultado * (-1);
                    dobro = (resultado * 2);
                    Console.WriteLine("Dobro do resultado:" + " " + dobro);

                }
                else
                {
                    resultado = (Resultado * 2);
                    Console.WriteLine("Dobro do resultado:" + " " + resultado);
                }
             
            }
            else
            {
                Resultado = A - B;
                if(Resultado < 0)
                {
                    resultado = Resultado * (-1);
                }
                Console.WriteLine("Resultado:" + " " + resultado );

            }
            
            /*
            //Questão 3)

            float n1 = 0;
            float n2 = 0;
            float n3 = 0;

            Console.WriteLine("Digite um número:");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número:");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite um último número:");
            n3 = float.Parse(Console.ReadLine());

            if(n1 > n2 && n1 > n3)
            {
                Console.WriteLine("O maior dos três número é:" + " " + n1);
            }
            if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("O maior dos três número é:" + " " + n2);

            }
            if (n3 > n2 && n3 > n1)
            {
                Console.WriteLine("O maior dos três número é:" + " " + n3);
            }
            

            //Questão 4)

            float i = 0;
            float j = 0;
            
            Console.WriteLine("Vamos somar dois números! Se os números somados forem iguais será retornado também o triplo de sua soma.");

            Console.WriteLine("Primeiro número:");
            i = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo número:");
            j = float.Parse(Console.ReadLine());

            if(i == j)
            {
                Console.WriteLine("A soma desses número é:" + " " + (i + j));
                Console.WriteLine("Triplo do resultado" + " " + (3 * (i + j)));
            }
            else
            {
                Console.WriteLine("A soma desses número é:" + " " + (i + j));
            }
            

            //Questão 5)
            int dias = 0;
            double valorfinal = 0;
            Console.WriteLine("Olá, seja bem vindo ao hotel Belo! Nossa taxa diária é R$50,00 + taxas de serviços.");
            Console.WriteLine("   ");
            Console.WriteLine("Diga quantos dias você passará no hotel para calcular o valor final da estádia");
            dias = int.Parse(Console.ReadLine());

            if(dias < 15)
            {
                valorfinal = (dias * 50) + (dias * 1.50);
                Console.WriteLine("Sua estádia custará R$" + valorfinal);
            }
            if (dias == 15)
            {
                valorfinal = (dias * 50) + (dias * 1);
                Console.WriteLine("Sua estádia custará R$" + valorfinal);
            }
            if (dias > 15)
            {
                valorfinal = (dias * 50) + (dias * 0.50);
                Console.WriteLine("Sua estádia custará R$" + valorfinal);
            }
            
            float media = 0;
            float credito = 0;
            Console.WriteLine("Seu banco pode conceder a você um crédito especial \n de acordo com sua média salárial do último ano.");
            Console.WriteLine("Diga sua média salárial para calcular o crédito:");
            media = float.Parse(Console.ReadLine());

            if(media >= 0 && media <= 200)
            {
                Console.WriteLine("Você não possui credito disponivel.");
            }
            if (media >= 201 && media <= 400)
            {
                credito = media * 20 / 100;
                Console.WriteLine("Você possui um crédito de: R$" + credito);
            }
            if (media >= 401 && media <= 600)
            {
                credito = media * 30 / 100;
                Console.WriteLine("Você possui um crédito de: R$" + credito);
            }
            if (media > 600)
            {
                credito = media * 40 / 100;
                Console.WriteLine("Você possui um crédito de: R$" + credito);
            }
            */
        }

    }       
}
