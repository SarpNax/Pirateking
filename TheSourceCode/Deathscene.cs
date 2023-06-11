using System;
using System.Threading;

namespace Pirate_King
{
	internal class Deathscene
	{
		private Colour CX = new Colour();

		public Deathscene()
		{
		}

		public void gameover()
		{
			this.CX.white();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("  GGGG    AAA   MM    MM EEEEEEE   OOOOO  VV     VV EEEEEEE RRRRRR  ");
			Console.WriteLine(" GG  GG  AAAAA  MMM  MMM EE       OO   OO VV     VV EE      RR   RR ");
			Console.WriteLine("GG      AA   AA MM MM MM EEEEE    OO   OO  VV   VV  EEEEE   RRRRRR  ");
			Console.WriteLine("GG   GG AAAAAAA MM    MM EE       OO   OO   VV VV   EE      RR  RR  ");
			Console.WriteLine(" GGGGGG AA   AA MM    MM EEEEEEE   OOOO0     VVV    EEEEEEE RR   RR ");
			Thread.Sleep(400);
			Console.Clear();
		}

		public void gameover2()
		{
			this.CX.red();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("  GGGG    AAA   MM    MM EEEEEEE   OOOOO  VV     VV EEEEEEE RRRRRR  ");
			Console.WriteLine(" GG  GG  AAAAA  MMM  MMM EE       OO   OO VV     VV EE      RR   RR ");
			Console.WriteLine("GG      AA   AA MM MM MM EEEEE    OO   OO  VV   VV  EEEEE   RRRRRR  ");
			Console.WriteLine("GG   GG AAAAAAA MM    MM EE       OO   OO   VV VV   EE      RR  RR  ");
			Console.WriteLine(" GGGGGG AA   AA MM    MM EEEEEEE   OOOO0     VVV    EEEEEEE RR   RR ");
			Thread.Sleep(400);
			Console.Clear();
		}

		public void ship1()
		{
            this.CX.white();
            Console.ForegroundColor = ConsoleColor.White;
			Console.Clear();
            Console.WriteLine("");
			Console.WriteLine("               _¦_¦_~");
			Console.WriteLine("              )      )");
			Console.WriteLine("              )______)");
			Console.WriteLine("          ___~ __!!__    ___~ ");
			Console.WriteLine("         )___))      )  )___)");
			Console.WriteLine("     ___ )___))______)  )___) ");
			Console.WriteLine("    /***\\_!!_____!!______!!_____/");
			Console.WriteLine("    \\      o * o o o o o * o t /");
			Console.WriteLine("     \\*** o * o o o o o o * o /");
			Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
			Console.WriteLine();
            Thread.Sleep(2000);
            Console.Clear();
        }

		public void ship2()
		{
            this.CX.white();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                        ___U___~                      ");
			Console.WriteLine("                                                       (       (                      ");
			Console.WriteLine("                                                       (       (                      ");
			Console.WriteLine("                                                       (_______(                      ");
			Console.WriteLine("                                                           !!             ____        ");
			Console.WriteLine("                                                    o.__,-. o.__,-. o.__,-.   \\      ");
			Console.WriteLine("                                            \\____ o._( .`-') ( .`-') ( .`-')  /      ");
			Console.WriteLine("                                             \\   o._(_ (_,_)(_ (_,_)(_ (_,_) /       ");
			Console.WriteLine("                                              \\      `--'    `--'    `--'   /        ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
			Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);
            Console.Clear();
        }

		public void ship3()
		{
            this.CX.white();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                                                 ");
			Console.WriteLine("                                                                                 ");
			Console.WriteLine("                                                                                 ");
			Console.WriteLine("                     o.__, . .                                                   ");
			Console.WriteLine("                        o.__  , . .                                              ");
			Console.WriteLine("                       o.__  ,, '. .                                             ");
			Console.WriteLine("                        o.__ .  ' ,                                              ");
			Console.WriteLine("                      o.__ . . '                                                 ");
			Console.WriteLine("                                                                                 ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
			Console.WriteLine();
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
        }

		public void ship4()
		{
            this.CX.white();
            Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
			Console.WriteLine("             //  .:'.'.:..'' \\	     //  .:'.'.:..'' \\                  ");
			Console.WriteLine("         -  (/  ....  . .  \\)-    -  (/  ....  . . \\ )-                 ");
			Console.WriteLine("            ((| :. ~ ^  :. .|))       ((| :. ~ ^  :. .|))                 ");
			Console.WriteLine("            -(- \\  . .  // | /) - -  - \\   . .  // |//) -               ");
			Console.WriteLine("              -((      ))  )) -         -\\      //  //-                  ");
			Console.WriteLine("                 ((   ))  ))              \\   //  //                     ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1000);
            Console.Clear();
        }

		public void ship5()
		{
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
			Console.WriteLine("");
			Console.WriteLine("          \\     .:'.'.:..''  //        \\ .:'.'.:..'' //                   ");
			Console.WriteLine("             (M^^.^~~:.'//;).            (M^^.^~~:.';).                    ");
			Console.WriteLine("        -   (//  .    . . \\ \\)  -  - (//  .    . . \\ \\)  -              ");
			Console.WriteLine("            ((| :. ~ ^  :. .|))        ((| :. ~ ^  :. .|))                  ");
			Console.WriteLine("       -   (\\- |  \\ //  |  /)  - -  (\\- |  \\ //  |  //)  -              ");
			Console.WriteLine("            -\\  \\     //  //-         -\\  \\     //  //-                 ");
			Console.WriteLine("              \\  \\   //  //            \\  \\   //  //                    ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
        }

		
        
    }
}