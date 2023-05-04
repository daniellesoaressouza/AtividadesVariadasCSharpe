using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler as medidas dos lados de um triângulo e escreva se é:

            // a) Equilátero
            // b) Isósceles
            // C) Escaleno
            
            {  int A, B, C;

            Console.WriteLine("Diga a medida do lado A do triangulo:");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Diga a medida do lado B do triangulo:");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("Diga a medida do lado C do triangulo:");
            C = int.Parse(Console.ReadLine());


            if (A == B && C == B && C == A)
            {
                Console.WriteLine("O Triangulo e:");
                Console.WriteLine("Equilatero");
            }
            if ((A == B && A != C) || (A == C && A != B) || (C == B && C != A))
            {
                Console.WriteLine("O Triangulo e:");
                Console.WriteLine("Isosceles");
            }
            if (C != B && C != A && B != A)
            {
                Console.WriteLine("O Triangulo e:");
                Console.WriteLine("Escaleno");
            }

        }
            
            //Ler do teclado os termos  A, B e C de uma Equação do 2° grau. o programa deve imprimir as raízes se existirem, o programa irá repetir até que A=0 B=0 C=0

            float X, Z, Y;
            float Delta;
            float Raiz, Raiz2;

            Console.WriteLine("Escolha o primeiro numero da sua equacao do 2 grau:");
            X = float.Parse(Console.ReadLine());

            Console.WriteLine("Escolha o segundo numero da sua equacao do 2 grau:");
            Z = float.Parse(Console.ReadLine());

            Console.WriteLine("Escolha o terceiro numero da sua equacao do 2 grau:");
            Y = float.Parse(Console.ReadLine());

            Delta = Z * Z - 4 * X * Y;
            Console.WriteLine(Delta);

            if (Delta <= 0) 
            {
                Console.WriteLine("Não existe raiz possível, numero negativo.");
            }

            if (Delta > 0)
            {

                Raiz = (-Z + MathF.Sqrt(Delta))/ (2 * X);
                Console.WriteLine("Primeira Raiz");
                Console.WriteLine(Raiz);

                Raiz2 = (-Z - MathF.Sqrt(Delta) )/( 2 * X);
                Console.WriteLine("Segunda Raiz");
                Console.WriteLine(Raiz2);

            }










        }
    }
}
