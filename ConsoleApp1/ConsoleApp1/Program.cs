using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
		

			float Valorinicial;
			float rendimentomes;

			float deposito;

			float rendimentos2;
			
			Valorinicial = 789.54f;
			Valorinicial *= 0.56f / 100;
			rendimentomes = 789.54f + Valorinicial;






			Console.WriteLine("Valor total com os redimentos do primeiro mes");
			Console.WriteLine(rendimentomes);

	
			
			deposito = 303.20f + 789.54f;
			deposito *= 0.56f / 100;
			deposito = deposito + 303.20f + 789.54f;
			
		
			

			Console.WriteLine("Valor total com os redimentos do segundo mes");
			Console.WriteLine(deposito);

			












		}

	}
}  



	