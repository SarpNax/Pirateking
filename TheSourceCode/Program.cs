using System;
using System.Reflection.Emit;
using System.Threading;

namespace Pirate_King
{
	internal class Program
	{
		public Program()
		{
		}

		private static void Main(string[] args)
		{
			bool flag = true;
			while (flag)
			{
                Colour colour = new Colour();
				PirateKingLogo pirateKingLogo = new PirateKingLogo();
				Deathscene deathscene = new Deathscene();
				Fleetleader fleetleader = new Fleetleader();
                Thread.Sleep(500);
                pirateKingLogo.Logo1();
				pirateKingLogo.Logo2();
				pirateKingLogo.Logo1();
				pirateKingLogo.Logo2();
				pirateKingLogo.Logo1();
				pirateKingLogo.Logo2();
                pirateKingLogo.Logo1();
                pirateKingLogo.Logo2();
                pirateKingLogo.Logo1();
                pirateKingLogo.Logo2();
				pirateKingLogo.Logo3();
				colour.gray();
                Console.WriteLine("Press Enter to continue");
				pirateKingLogo.Logo4();
                Console.ReadLine();
                colour.gray();
                Console.Clear();
				Console.Write("Welcome To PirateKing Your Ship Awaits you");
				colour.red();
				Console.Write(" Jack ");
				colour.gray();
				Console.WriteLine("the enemy is fast approaching !!");
                Thread.Sleep(1000);
                Console.Write("The Scallywag");
				colour.red();
				Console.Write(" Black Beard ");
				colour.gray();
				Console.WriteLine("is at it agian trying to steal your loot and Kingdom.");
                Console.WriteLine();
                Console.WriteLine("He has ammassed an army and is poised to attack.");
                Console.WriteLine();
                Console.WriteLine("As our Leader you must do something!");
				colour.green();
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
				Console.Clear();
				colour.gray();
                Console.Write("Dont Just Stand There");
				colour.red();
				Console.Write(" Jack ");
				colour.gray();
				Console.WriteLine("Do SomeThing !!");
				Console.WriteLine();
                colour.green();
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
                colour.gray();
				Console.WriteLine();
				Console.WriteLine("what will you do ?");
				Console.WriteLine();
				colour.gray();
				Console.WriteLine("Will you do something ??");
				Console.Write("(PLEASE TYPE THE WORD ");
				colour.blue();
                Console.WriteLine("*case sensative*)");
				colour.white();
				Console.Write(" 'do something'");
				colour.gray();
				Console.Write(" or ");
				colour.white();
				Console.Write("'drink rum'");
				colour.gray();
				Console.Write(" or ");
				colour.white();
				Console.WriteLine("'esc')");
				string str = Console.ReadLine();
				if (str == "drink rum")
				{
                    flag = true;
                    fleetleader.BattleMap();
					Console.ReadLine();
					flag = true;
				}
				if (str == "do something")
				{
					colour.green();
					Console.Write("Jack ");
					colour.white();
					Console.WriteLine("starts to panic and locks himself in his cabin");
					Console.WriteLine("etching out a plan to save his skin.");
					Console.WriteLine(" Before he knew it the enemy has gotten too close.");
					Console.WriteLine("An eeiry silence floods the battlefield.");
                    colour.green();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    colour.gray();

                    flag = false;

					deathscene.ship1();
                    deathscene.ship2();
                    deathscene.ship3();
                    deathscene.ship4();
					deathscene.ship5();
					deathscene.ship4();
                    deathscene.ship5();
                    deathscene.ship4();
                    deathscene.ship5();

                    deathscene.gameover();
					deathscene.gameover2();
					deathscene.gameover();
					deathscene.gameover2();
					deathscene.gameover();
					deathscene.gameover2();
				}
				if (!(str == "esc"))
				{
					Console.Clear();
				}
				else
				{
					flag = false;
					break;
				}
			}

        }
	}
}