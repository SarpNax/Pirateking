using System;

namespace Pirate_King
{
	internal class Tutorial : Colour
	{
		public Tutorial()
		{
		}

		public void Aids()
		{
			Console.WriteLine(" Hello and welcome to the tutorial of PIRATEKING");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Here you can select from the following:");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1.Tutorial");
            Console.WriteLine();
            Console.WriteLine("2.Version information");

			Console.WriteLine("3.Frequently Asked Questions");
            Console.WriteLine();
            Console.WriteLine("4.Credits");
			string str = Console.ReadLine();
			if (str != null)
			{
				if (str == "1")
				{
					base.white();
					Console.WriteLine("This is Pirate king");
					Console.WriteLine("You will take turns doing actions");
					base.green();
					Console.WriteLine("Press Enter to progress in every action !");
					base.white();
					Console.WriteLine("the way you do this is by lowering the other ships hull to 0");
                    Console.WriteLine();
                    Console.WriteLine("while keeping your own ships hull above 0");
                    Console.WriteLine();
                    Console.WriteLine("when you defeat an enemy you regain hull points");
                    Console.WriteLine();
                    Console.WriteLine("actions:");
                    Console.WriteLine();
                    Console.WriteLine("Hold fire = hull regen");
					Console.WriteLine("Fire = damage to other ships");
					Console.WriteLine("aim = increase to stats");
					Console.WriteLine("remember the saying ' yo ho ho the pirates life for me!'");
					Console.ReadLine();
					Console.Clear();
					base.yellow();
				}
				else if (str == "2")
				{
					Console.WriteLine("This is Version 0.1");
					Console.ReadLine();
					Console.Clear();
					base.yellow();
				}
				else if (str == "3")
				{
					Console.Clear();
					Console.WriteLine("Frequently asked Questions");
					Console.WriteLine();
					Console.WriteLine("Question:Why cant i beat this game");
					Console.WriteLine("Answer  :Because your not Good Enough sorry :)");
					Console.WriteLine();
					Console.WriteLine("Question: When you aim what exactly happens");
					Console.WriteLine("Answer  : Well the Crew stat increases and so does the Cannon while helping with a bit of healing. hope it helps.");
					Console.ReadLine();
					Console.Clear();
					base.yellow();
				}
				else if (str == "4")
				{
					Console.WriteLine("Thanks For Playing PIRATEKING");
					Console.WriteLine("Head developer - Sarp");
					Console.WriteLine("Lead Producer - MagiSarp");
					Console.ReadLine();
					Console.Clear();
					base.yellow();
				}
			}
		}
	}
}