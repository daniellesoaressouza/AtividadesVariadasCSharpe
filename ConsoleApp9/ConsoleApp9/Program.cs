using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Questão 1)
            bool idadeMax = true;
            int idadeUsuario = 0;
            string nome;
            Console.WriteLine("Este programa é para pessoas 30+");
           
            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade:");
            idadeUsuario = int.Parse(Console.ReadLine());

            if(idadeUsuario < 30)
            {
                idadeMax = false;
            
            }
          if (idadeMax)
            {
                Console.WriteLine("Idade permitida.");
            }
          else
            {
                Console.WriteLine("Idade não permitida.");
            }
          

            //Questão 2)

            float nota1 = 0;
            float nota2 = 0;
            float nota3 = 0;
            int opcao = 0;
            int peso1 = 0;
            int peso2 = 0;
            int peso3 = 0;
            float resultado = 0;
            

            Console.WriteLine("Vamos calcular a média de 3 notas de um aluno");
          
            Console.WriteLine("Primeira nota");
            nota1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Segunda nota");
            nota2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Terceira nota");
            nota3 = float.Parse(Console.ReadLine());


            Console.WriteLine("Escolha uma das opções para calcular a média: \n 1)Média simples \n 2)Média Ponderada \n 3)Média harmônica.");
            opcao = int.Parse(Console.ReadLine());

            if(opcao == 1)
            {
                resultado = nota1 + nota2 + nota3 / 3f;
                Console.WriteLine("A média é:" + resultado);

            }
            if(opcao == 2)
            {
                Console.WriteLine("Peso primeira nota");
                peso1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Peso segunda nota");
                peso2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Peso terceira nota");
                peso3 = int.Parse(Console.ReadLine());

                resultado = (peso1 * nota1 + peso2 * nota2 + peso3 * nota3) / (peso1 + peso2 + peso3);
                Console.WriteLine("A média é:" + resultado);

            }
            if (opcao == 3)
            {
                resultado = 3 /( (1 / nota1) + (1 / nota2) + (1 / nota3));
                Console.WriteLine("A média é:" + resultado);
            }
            

            //Questão 3)

            String Nproduto;
            float preco = 0;
            int escolha = 0;
            float desconto = 0;
            float juros = 0;
            string opParcelas;
            int parcelas = 0;
            float precoFinal = 0;
            float precoFina2 = 0;
            
            Console.WriteLine("Calcular o valor final do seu produto");
            Console.WriteLine("Digite o nome do produto:");
            Nproduto = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto:");
            preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Forma de pagamento: \n 1)Dinheiro \n 2) Cartão de débito \n 3)Cartão de crédito da loja \n 4) Cartão de crédito ");
            escolha = int.Parse(Console.ReadLine());

            if(escolha == 1)
            {
                Console.WriteLine("Dinheiro.");
                desconto = preco * 10 / 100;
                precoFinal = preco - desconto;
                Console.WriteLine("O valor final do produto é:" + precoFinal);
            }
            if (escolha == 2)
            {
                Console.WriteLine("Débito");
                Console.WriteLine("O valor final do produto é" + preco);
            }
            if (escolha == 3)
            {
                Console.WriteLine("Cartão da loja");
                Console.WriteLine("Optar por parcelamento? Digite sim ou não");
                opParcelas = Console.ReadLine();
            

                if (opParcelas == "sim")
                {
                    Console.WriteLine("Deseja dividir em quantas parcelas?");
                    parcelas = int.Parse(Console.ReadLine());

                    precoFinal = preco / parcelas;
                    Console.WriteLine("O valor final do produto é:" + precoFinal);

                }
                else
                {
                    Console.WriteLine("O valor final do produto é:" + preco);
                }
            
            }
            if (escolha == 4)
            {
                Console.WriteLine("Cartão de crédito.\n Será aplicado um juros de 5%");
         
                Console.WriteLine("Deseja optar por parcelamento? Digite sim ou não");
                opParcelas = Console.ReadLine();

                if (opParcelas == "sim")
                {
                    Console.WriteLine("Deseja dividir em quantas parcelas?");
                    parcelas = int.Parse(Console.ReadLine());

                    juros = preco * 5 / 100;
                    precoFinal = preco + juros;
                    precoFina2 = precoFinal / parcelas;
                    Console.WriteLine("O valor final do produto é:" + precoFina2 +"\n E será parcelado em:"+ parcelas + "x");
           
                }
                else
                {
                    juros = preco * 5 / 100;
                    precoFinal = preco + juros;
                    Console.WriteLine("O preço final do produto é:" + precoFinal);
                }
           

            //Questão 4

            string nomeUS;
            int n = 0;

            Console.WriteLine("Digite o seu nome");
            nomeUS = Console.ReadLine();

             while(n <= 124)
            {
                n++;
                Console.WriteLine(n + "  " + nomeUS);
            }
             */

            //Questão 5)
            int num = 1, i;
            
            

            Console.WriteLine("Escolha um numero para fatorar:");
            i = int.Parse(Console.ReadLine());
            while (num != 1)
            {
                num = num * i;
                i = i - num;
                num--;
               
                
            if (i <= 0)
                {
                    Console.WriteLine("Digite um número positivo");
                    i = int.Parse(Console.ReadLine());


                }
            if ( i == 0)
                {
                    num = 1;
                    Console.WriteLine(num);
                }
                Console.WriteLine(num);

            }
            
            

            















        }
    }
}
