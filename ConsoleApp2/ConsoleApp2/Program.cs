using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{

			float Valorinicial;






			Valorinicial = 789.54f;
			Valorinicial += Valorinicial * 0.56f / 100;







			Console.WriteLine("Valor total com os redimentos do primeiro mes");
			Console.WriteLine(Valorinicial);

			Valorinicial += 303.20f;
			Valorinicial += Valorinicial * 0.56f / 100;












			Console.WriteLine("Valor total com os redimentos do segundo mes");
			Console.WriteLine(Valorinicial);
			Console.ReadLine();

			Valorinicial -= 58.25f;
			Valorinicial += Valorinicial * 0.56f / 100;

			Console.WriteLine("Valor total com os redimentos do terceiro mes");
			Console.WriteLine(Valorinicial);
			Console.ReadLine();


		}
	}
}
