using System;

namespace Lista_5___9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letras = new char[15] { 'a', 'b', 'f', 'h', 'k', 'e', 'r', 'z', 'o', 'u', 'w', 'v', 'n', 'm', 'l' };
            int contador = 0;
            int contador2 = 0;
            for(int i = 0; i<=14;i++)
            {
                if (letras[i]=='a'|| letras[i]== 'e' || letras[i] == 'i'|| letras[i] == 'o' || letras[i] == 'u')
                {
                    contador++;
                   
                }
                else
                {
                    contador2++;
                    
                }
            }
            Console.WriteLine("Vogais:" + " " + contador);
            Console.WriteLine("Consoantes:" + " " + contador2);
            Console.Write(letras);



        }
    }
}
