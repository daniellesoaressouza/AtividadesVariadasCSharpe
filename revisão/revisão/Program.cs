using System;

namespace revisão
{
    class Program
    {
        static void Main(string[] args)
        {
            /*O que é um algoritimo? Algoritimo pode ser entendido como uma receita para a relização de algo ou passos para 
              a solução de algum problema. Um conjunto de regras e etapas.
              
            O que é uma váriavel? Armazenamento de dados.

            O que é um int, float, double, bool, char e string? int: Várivel que guada números inteiros. Float: Váriavel que
            guarda um número com 6 a 7 casas decimais de precisão. Double: Guarda um número com 10 casas decimais de precisão.
            bool: Guarda um valor e retorna se verdadeiro ou falso. char: Guarda caracteres. string: Guarda palavras e frases.

            O que é um Array? Uma array também é armazenamento de dados, porem diferente de uma várivel, ela consegue gravar
            uma série de dados e não somente um. Array pode ser até matrizes.

            O que é uma linguagem de programação? Cite alguns exemplos. Linguagem de programação é a comunicação que se utiliza
            para se "comunicar" com um computador para que ele entenda o que você espera que ele faça,para então reproduzir. Assim
            como temos nossas linguagens como português, ingles... a máquina também tem a que ele se comunica. Existem diferentes 
            tipos de linguagens para se comunicar com um computador, mas todas com o mesmo intuito. Ex de linguagens: C#, C++,
            Javascript, python.

            O que é uma linguagem de marcação? Cite alguns exemplos.Em informática, uma linguagem de marcação, é um conjunto de 
            sinais e códigos aplicados a um texto ou a dados para definir a sua configuração. A marcação não aparece no trabalho 
            final. O termo "marcação" vem da sinalética ou "marcas de revisão" utilizada por redatores em provas de impressão de 
            jornais e manuscritos. Ex de linguagem de marcação: HTML, XHTML.

            O que é uma linguagem de programação orientada a objetos? A programação orientada a objetos é um modelo de programação 
            onde diversas classes possuem características que definem um objeto na vida real. Cada classe determina o comportamento 
            do objeto definido por métodos e seus estados possíveis definidos por atributos.
            */

            //Soma de dois números
            /* 
             Console.WriteLine("Soma de dois números. \nDigite o primeiro número:");
             double i = double.Parse(Console.ReadLine());

             Console.WriteLine("Digite o segundo número número:");
             double j = double.Parse(Console.ReadLine());

             Console.WriteLine("Resultado:" + " " + (i + j));

             //Ler dois números inteiros, imprimir se são iguais ou não.

             Console.WriteLine("Digite o primeiro número:");
             double a = double.Parse(Console.ReadLine());

             Console.WriteLine("Digite o segundo número número:");
             double b = double.Parse(Console.ReadLine());

             if(a==b)
             {
                 Console.WriteLine("Os números são iguais.");
             }
             else
             {
                 Console.WriteLine("Os números não são iguais.");
             }

             //Ler um inteiro e dizer se é par ou impar.

             bool par = true;
             Console.WriteLine("Digite um número para verificar se ele é par ou ímpar:");
             int c = int.Parse(Console.ReadLine());

             if(c%2==0)
             {
                 par = true;
                 Console.WriteLine("Número par");
             }
             else
             {
                 Console.WriteLine("Número ímpar");
             }

             //Ler dois inteiros e dizer qual o maior e qual o menor.

             Console.WriteLine("Digite o primeiro número:");
             double d = double.Parse(Console.ReadLine());

             Console.WriteLine("Digite o segundo número número:");
             double e = double.Parse(Console.ReadLine());
             if(d==e)
             {
                 Console.WriteLine("São iguais.");
             }
            else if(d>e)
             {
                 Console.WriteLine("Maior:" + " " + d + "\nMenor:" + " " + e);
             }
             else
             {
                 Console.WriteLine("Maior:" + " " + e + "\nMenor:" + " " + d);
             }
            
            //Ler três números e imprimir em ordem crescente

            Console.WriteLine("Digite o primeiro número:");
            int f = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número número:");
            int g = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número número:");
            int h = int.Parse(Console.ReadLine());

            int maior = 0;
            int menor = 0;
            int medio = 0;
            if(f>g && f>h)
            {
                maior = f; 
            }
            else if (g > f && g > h)
            {
                maior = g;
            }
            else if (h > f && h > g)
            {
                maior = h;
            }
            if (f < g && f < h)
            {
                menor = f;
            }
            else if (g < f && g < h)
            {
                menor = g;
            }
            else if (h < f && h < g)
            {
                menor = h;
            }
            if(f==maior && g==menor)
            {
                medio = h;
            }
            else if (f == menor && g == maior)
            {
                medio = h;
            }
            else if (h == maior && g == menor)
            {
                medio = f;
            }
            else if (h == menor && g == maior)
            {
                medio = f;
            }
            else if (h == maior && f == menor)
            {
                medio = g;
            }
            else if (h == menor && f == maior)
            {
                medio =g;
            }

            Console.Write("Ordem crescente:" + " " + menor + " " + medio + " " + maior);
            */
            //Calcular raizes de uma equação de 2°

            Console.WriteLine("Levando em consideração os número de uma equação do 2° como A, B e C. De valores a essas incognitas.");
            Console.WriteLine("Valor de A:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor de B:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor de C:");
            double c = double.Parse(Console.ReadLine());

            double delta = (b * b) - 4 * (a * c);

            double raizdelta = Math.Sqrt(delta);

            double raiz1 = -((b) + raizdelta) / (2 * a);
            double raiz2 = -((b) - raizdelta) / (2 * a);


            Console.WriteLine("Raiz 1:" + " " + raiz1);
            Console.WriteLine("Raiz 2:" + " " + raiz2);



        }
    }
}
