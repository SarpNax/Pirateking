using System;
using System.Threading;

namespace Pirate_King
{
	internal class Fleetleader : Colour
	{
		public Fleetleader()
		{
		}

		public void BattleMap()
		{
			int num; // Enemy Attack
			int num1;
			int num2;
			short num3;//The random Generator number.  
			short num4;
			string str;
			ShipAnimation shipAnimation = new ShipAnimation();
			Deathscene deathscene = new Deathscene();
			Tutorial tutorial = new Tutorial();
			Random random = new Random();
			Random random1 = new Random();
			bool flag = true;
			int num5 = 1000;//Player Health
			int num6 = 10;//Player CannonNumber
			int num7 = 30;//Player Crew
			int num8 = 0; // Player ATTACK ?
			int num9 = 1500; //Mecenery Skiff (MS)
			int num10 = 7; //MS Cannon
			int num11 = 20; // MS Crew 
			int num12 = 0; // MS ATTACK
			int num13 = 3000;
			int num14 = 22;
			int num15 = 17;
			int num16 = 5000;// Blackbeard ship (BB)
			int num17 = 40; // BB cannons
			int num18 = 30; //BB crew
			int num19 = 7500;
			int num20 = 50;
			int num21 = 30;
			flag = true;
			if ((!flag ? false : num5 > 0))
			{
				Console.Clear();
				base.red();
				Console.WriteLine("Jack ");
				base.gray();
				Thread.Sleep(250);
				Console.WriteLine("takes a bottle of rum lying around the deck and takes a huge swig out of it");
				Console.ReadLine();
				base.yellow();
				Console.WriteLine("Would You Like Help? (Y/N)");
				if (Console.ReadLine().ToUpper() == "Y")
				{
					tutorial.Aids();
				}
				if (Console.ReadLine().ToUpper() == "n")
				{
					base.green();
					Console.WriteLine();
					Console.WriteLine("GOOD LUCK CAPTIAN!");
					Console.ReadLine();
					Console.Clear();
					base.gray();
					Console.WriteLine(" You and your crew sail on and face your first Enemy");
					Console.WriteLine();
					Console.WriteLine("Basic Stats of your ship.");
					Console.WriteLine();
					base.white();
					Console.WriteLine(" Your ships Health then Cannons and Crew are shown in green before each fight");
					base.green();
					Console.WriteLine(string.Concat(" Your Hull ", num5));
					Console.WriteLine(string.Concat(" Your Cannons ", num6));
					Console.WriteLine(string.Concat(" Your Crew ", num7));
					shipAnimation.Jship();
					Console.ReadLine();
					Console.Clear();
					Console.WriteLine(" The First Enemy Ship Comes Port Side and begins to load their cannons");
					Console.WriteLine("be carefull your first battle has Begun.");
					Console.WriteLine("press the 'enter key' to continue");
					Console.ReadLine();
					base.white();
					Console.WriteLine("`AVAST YEEE, your ship is ours for the TAKING'");
					Console.WriteLine();
					Console.WriteLine("Before you is a Mercenary skiff");
					shipAnimation.Mship();
					Console.Clear();
					base.gray();
					while (true)
					{
						if ((num5 <= 0 ? true : num9 <= 0))
						{
							break;
						}
						Console.WriteLine("The Battle begins");
						base.green();
						Console.WriteLine();
						Console.WriteLine(string.Concat("Jack's Ship Hull: ", num5));
						base.gray();
						Console.WriteLine("Enemy Ship Hull: {0}", num9);
						Console.WriteLine();
						base.red();
						Console.WriteLine(" |||||**** HOLD STEADY MEN ****||||| ");
						Console.WriteLine();
						base.white();
						Console.WriteLine("What will you do");
						base.gray();
						Console.Write("you can either");
						base.white();
						Console.Write(" `hold fire'");
						base.gray();
						Console.Write(" or ");
						base.white();
						Console.WriteLine("`fire'");
						base.gray();
						Console.Write(" or ");
						base.white();
						Console.WriteLine("aim");
						base.yellow();
						str = Console.ReadLine();
						Console.Clear();
						if (str == "hold fire")
						{
							Console.Clear();
							num12 = num11 * num10;
							num5 += 250;
							Console.WriteLine(" Your crew wait and plug up holes in the ship and steady the hull");
							Console.WriteLine("Incoming ENEMY CANNON FIRE ");
							Console.ReadLine();
							Console.WriteLine("Enemy Attack ; {0}", num12);
							Console.WriteLine();
							num5 -= num12;
							num7 -= 3;
							num11--;
							num10 += 3;
							Console.WriteLine();
							Console.WriteLine(" Your Hull ; {0}", num5);
							Console.ReadLine();
						}
						if (str == "fire")
						{
							Console.Clear();
							num12 = num11 * num10;
							num8 = num7 * num6;
							num5 -= num12;
							Console.WriteLine();
							Console.WriteLine(" Your crew line up the cannons and fire a well timed barrage at the enemy");
							Console.ReadLine();
							Console.WriteLine("Our Attack ; {0}", num8);
							Console.WriteLine("Enemy Attack ; {0}", num12);
							num9 -= num8;
							num5 -= num12;
							num11 -= 2;
							num7--;
							num6--;
							Console.ReadLine();
						}
						if (!(str == "aim"))
						{
							Console.Clear();
						}
						else
						{
							Console.Clear();
							num6 += 10;
							num7 += 5;
							num5 += 50;
							Console.WriteLine(" Your Crew consolidate and Aim at your target gaining bonuses to all 3 stats");
							Console.ReadLine();
							num12 = num11 * num10;
							num11 += 2;
							num5 -= num12;
							base.green();
							Console.WriteLine("Stat Increase -   Crew  : {0}", num7);
							Console.WriteLine("Stat Increase - Cannons : {0}", num6);
							Console.WriteLine("Stat Increase -   Hull  : {0}", num5);
							Console.WriteLine();
							Console.WriteLine("Enemy Attack ; {0}", num12);
							base.gray();
							Console.ReadLine();
							Console.Clear();
						}
					}
					if (num9 < 0)
					{
						num5 += 500;
					}
					if (num5 >= 0)
					{
						base.gray();
						Console.WriteLine("By the chin of four chin chevy");
						Console.WriteLine();
						Console.Write("You did it ");
						base.red();
						Console.WriteLine("Jack ");
						base.gray();
						Console.WriteLine("press enter to continue");
						Console.ReadLine();
						base.green();
						Console.WriteLine();
						base.green();
						Console.WriteLine(string.Concat(" Your Hull ", num5));
						Console.WriteLine(string.Concat(" Your Cannons ", num6));
						Console.WriteLine(string.Concat(" Your Crew ", num7));
						base.white();
						Console.WriteLine();
						Console.WriteLine("ONWARDS YOU SCALLYWAGS");
						Console.ReadLine();
						base.gray();
						Console.Clear();
						Console.WriteLine(" The Next ship bares down your ship rushing to get into firing range");
						Console.WriteLine("press 'enter' to continue");
						Console.ReadLine();
						base.white();
						Console.WriteLine();
						Console.WriteLine(" Your treatury will not go un punished");
						shipAnimation.Aship();
						base.gray();
						Console.WriteLine("press 'enter' to continue");
						Console.ReadLine();
						Console.WriteLine();
						base.green();
						Console.WriteLine(string.Concat(" Your Hull ", num5));
						Console.WriteLine(string.Concat(" Your Cannons ", num6));
						Console.WriteLine(string.Concat(" Your Crew ", num7));
						base.white();
						Random random2 = new Random();
						while (true)
						{
							if ((num5 <= 0 ? true : num13 <= 0))
							{
								break;
							}
							Console.Clear();
							Console.WriteLine("The Battle begins");
							base.green();
							Console.WriteLine();
							Console.WriteLine("Jack's Ship Hull: {0} ", num5);
							base.gray();
							Console.WriteLine("Enemy Ship Hull: {0}", num13);
							Console.WriteLine();
							base.red();
							Console.WriteLine(" |||||**** HOLD STEADY MEN ****||||| ");
							Console.WriteLine();
							base.white();
							Console.WriteLine("What will you do");
							base.gray();
							Console.Write("you can either");
							base.white();
							Console.Write(" `hold fire'");
							base.gray();
							Console.Write(" or ");
							base.white();
							Console.WriteLine("`fire'");
							base.gray();
							Console.Write(" or ");
							base.white();
							Console.WriteLine("aim");
							base.yellow();
							str = Console.ReadLine();
							Console.Clear();
							if (str == "fire")
							{
								Console.Clear();
								Console.WriteLine(" Your crew line up the cannons and fire a well timed barrage at the enemy");
								Console.ReadLine();
								num8 = num7 * num6;
								Console.WriteLine();
								Console.WriteLine("Our Attack ; {0}", num8);
								num13 -= num8;
								Console.ReadLine();
								num3 = Convert.ToInt16(random.Next(1, 3));
								if (num3 == 3)
								{
									base.white();
									Console.WriteLine("The Enemy Shoots you with poorly timed cannon fire");
									Console.ReadLine();
									num = num15 * num14;
									num15--;
									num5 -= num;
									num7 -= 2;
									base.yellow();
									Console.WriteLine("Enemy Attack ; {0}", num12);
									base.green();
									Console.WriteLine();
									Console.WriteLine("Status of -   Crew  : {0}", num7);
									Console.WriteLine("Status of - Cannons : {0}", num6);
									Console.WriteLine("Status of -   Hull  : {0}", num5);
									Console.ReadLine();
									base.gray();
									Console.Clear();
								}
								if (num3 == 1)
								{
									base.white();
									Console.WriteLine("The Enemy seem to be holding their fire waiting for the opertune moment");
									Console.ReadLine();
									num13 += 150;
									num15 += 3;
									num14 += 3;
									num = 0;
									base.yellow();
									Console.WriteLine("Enemy Attack ; {0}", num);
									base.green();
									Console.WriteLine();
									Console.WriteLine("Status of -   Crew  : {0}", num7);
									Console.WriteLine("Status of - Cannons : {0}", num6);
									Console.WriteLine("Status of -   Hull  : {0}", num5);
									base.gray();
									Console.ReadLine();
									Console.Clear();
								}
								if (num3 == 2)
								{
									base.white();
									Console.WriteLine("The enemy ready their cannons and FIRE !");
									Console.ReadLine();
									num = num15 * num14;
									num7 -= 3;
									base.yellow();
									Console.WriteLine("Enemy Attack ; {0}", num);
									num5 -= num;
									base.green();
									Console.WriteLine();
									Console.WriteLine("Status of -   Crew  : {0}", num7);
									Console.WriteLine("Status of - Cannons : {0}", num6);
									Console.WriteLine("Status of -   Hull  : {0}", num5);
									base.gray();
									Console.ReadLine();
									Console.Clear();
								}
							}
							if (str == "hold fire")
							{
								num5 += 600;
								base.yellow();
								Console.WriteLine(" Your crew wait and plug up holes in the ship and steady the hull");
								Console.WriteLine();
								Console.WriteLine(" Your Hull ; {0}", num5);
								Console.ReadLine();
								num3 = Convert.ToInt16(random.Next(1, 3));
								if (num3 == 3)
								{
									base.white();
									Console.WriteLine("The Enemy Shoots you with poorly timed cannon fire");
									Console.ReadLine();
									num = num15 * num14;
									num15--;
									num5 -= num;
									num7 -= 2;
									base.yellow();
									Console.WriteLine("Enemy Attack ; {0}", num12);
									base.green();
									Console.WriteLine();
									Console.WriteLine("Status of -   Crew  : {0}", num7);
									Console.WriteLine("Status of - Cannons : {0}", num6);
									Console.WriteLine("Status of -   Hull  : {0}", num5);
									Console.ReadLine();
									base.gray();
									Console.Clear();
								}
								if (num3 == 1)
								{
									base.white();
									Console.WriteLine("The Enemy seem to be holding their fire waiting for the opertune moment");
									Console.ReadLine();
									num13 += 150;
									num15 += 3;
									num14 += 3;
									num = 0;
									base.yellow();
									Console.WriteLine("Enemy Attack ; {0}", num);
									base.green();
									Console.WriteLine();
									Console.WriteLine("Status of -   Crew  : {0}", num7);
									Console.WriteLine("Status of - Cannons : {0}", num6);
									Console.WriteLine("Status of -   Hull  : {0}", num5);
									base.gray();
									Console.ReadLine();
									Console.Clear();
								}
								if (num3 == 2)
								{
									base.white();
									Console.WriteLine("The enemy ready their cannons and FIRE !");
									Console.ReadLine();
									num = num15 * num14;
									num7 -= 3;
									base.yellow();
									Console.WriteLine("Enemy Attack ; {0}", num);
									num5 -= num;
									base.green();
									Console.WriteLine();
									Console.WriteLine("Status of -   Crew  : {0}", num7);
									Console.WriteLine("Status of - Cannons : {0}", num6);
									Console.WriteLine("Status of -   Hull  : {0}", num5);
									base.gray();
									Console.ReadLine();
									Console.Clear();
								}
							}
							if (!(str == "aim"))
							{
								Console.Clear();
							}
							else
							{
								Console.Clear();
								num6 += 2;
								num7 += 2;
								num5 += 60;
								Console.WriteLine(" Your Crew consolidate and Aim at your target gaining bonuses to all 3 stats");
								Console.ReadLine();
								base.green();
								Console.WriteLine("Stat Increase -   Crew  : {0}", num7);
								Console.WriteLine("Stat Increase - Cannons : {0}", num6);
								Console.WriteLine("Stat Increase -   Hull  : {0}", num5);
								Console.ReadLine();
								num3 = Convert.ToInt16(random.Next(1, 3));
								if (num3 == 3)
								{
									base.white();
									Console.WriteLine("The Enemy Shoots you with poorly timed cannon fire");
									Console.ReadLine();
									num = num15 * num14;
									num15--;
									num5 -= num;
									num7 -= 2;
									base.yellow();
									Console.WriteLine("Enemy Attack ; {0}", num12);
									base.green();
									Console.WriteLine();
									Console.WriteLine("Status of -   Crew  : {0}", num7);
									Console.WriteLine("Status of - Cannons : {0}", num6);
									Console.WriteLine("Status of -   Hull  : {0}", num5);
									Console.ReadLine();
									base.gray();
									Console.Clear();
								}
								if (num3 == 1)
								{
									base.white();
									Console.WriteLine("The Enemy seem to be holding their fire waiting for the opertune moment");
									Console.ReadLine();
									num13 += 150;
									num15 += 3;
									num14 += 3;
									num = 0;
									base.yellow();
									Console.WriteLine("Enemy Attack ; {0}", num);
									base.green();
									Console.WriteLine();
									Console.WriteLine("Status of -   Crew  : {0}", num7);
									Console.WriteLine("Status of - Cannons : {0}", num6);
									Console.WriteLine("Status of -   Hull  : {0}", num5);
									base.gray();
									Console.ReadLine();
									Console.Clear();
								}
								if (num3 == 2)
								{
									base.white();
									Console.WriteLine("The enemy ready their cannons and FIRE !");
									Console.ReadLine();
									num = num15 * num14;
									num7 -= 3;
									base.yellow();
									Console.WriteLine("Enemy Attack ; {0}", num);
									num5 -= num;
									base.green();
									Console.WriteLine();
									Console.WriteLine("Status of -   Crew  : {0}", num7);
									Console.WriteLine("Status of - Cannons : {0}", num6);
									Console.WriteLine("Status of -   Hull  : {0}", num5);
									base.gray();
									Console.ReadLine();
									Console.Clear();
								}
							}
						}
						if (num5 >= 0)
						{
							if (num13 == 0)
							{
								num5 += 1000;
							}
							base.gray();
							Console.WriteLine("By the Leg of No Leg Johnny");
							Console.WriteLine();
							Console.Write("You did it ");
							base.red();
							Console.WriteLine("Jack ");
							base.gray();
							Console.WriteLine("press enter to continue");
							Console.ReadLine();
							base.green();
							Console.WriteLine();
							Console.WriteLine(string.Concat(" Your Hull ", num5));
							Console.WriteLine(string.Concat(" Your Cannons ", num6));
							Console.WriteLine(string.Concat(" Your Crew ", num7));
							base.white();
							Console.WriteLine();
							Console.WriteLine(" ONWARDS YOU SCALLYWAGS");
							Console.ReadLine();
							base.gray();
							Console.Clear();
							Console.WriteLine("as you sail further into the battle a huge ship blocks your way");
							Console.WriteLine("ITS BLACKBEARD'S SHIP");
							Console.WriteLine("Your crew hurry and repair all they can. They plug every hole possible");
							Console.WriteLine("you can end this war and save your Kingdom with the death of this MENACE!");
							Console.ReadLine();
							base.white();
							Console.WriteLine();
							base.gray();
							Console.WriteLine("press 'enter' to continue");
							Console.ReadLine();
							Console.Clear();
							shipAnimation.BBship();
							base.white();
							Console.Write("'So We finally meet agian");
							base.red();
							Console.WriteLine(" Jack");
							base.white();
							Console.WriteLine(" it will be a pleasure to destroy you after what you did to me in the Caribbean!!");
							Console.ReadLine();
							Console.Clear();
							while (true)
							{
								if ((num5 <= 0 ? true : num16 <= 0))
								{
									break;
								}
								Console.Clear();
								Console.WriteLine("The Final Battle begins");
								Console.WriteLine("Good luck");
								base.green();
								Console.WriteLine();
								Console.WriteLine("Jack's Ship Hull: {0} ", num5);
								base.gray();
								Console.WriteLine("Enemy Ship Hull: {0}", num16);
								Console.WriteLine();
								base.red();
								Console.WriteLine(" |||||**** HOLD STEADY MEN ****||||| ");
								Console.WriteLine();
								base.white();
								Console.WriteLine("What will you do");
								base.gray();
								Console.Write("you can either");
								base.white();
								Console.Write(" `hold fire'");
								base.gray();
								Console.Write(" or ");
								base.white();
								Console.WriteLine("`fire'");
								base.gray();
								Console.Write(" or ");
								base.white();
								Console.WriteLine("aim");
								base.yellow();
								str = Console.ReadLine();
								Console.Clear();
								if (str == "fire")
								{
									Console.Clear();
									Console.WriteLine(" Your crew line up the cannons and fire a well timed barrage at the enemy");
									Console.ReadLine();
									num8 = num7 * num6;
									num18 -= 4;
									Console.WriteLine();
									Console.WriteLine("Our Attack ; {0}", num8);
									num16 -= num8;
									Console.ReadLine();
									num3 = Convert.ToInt16(random.Next(1, 3));
									if (num3 == 3)
									{
										base.white();
										Console.WriteLine("The Enemy Shoots you with poorly timed cannon fire");
										Console.ReadLine();
										num1 = num18 * num17;
										num18--;
										num5 -= num1;
										num7 -= 2;
										base.yellow();
										Console.WriteLine("Enemy Attack ; {0}", num1);
										base.green();
										Console.WriteLine();
										Console.WriteLine("Status of -   Crew  : {0}", num7);
										Console.WriteLine("Status of - Cannons : {0}", num6);
										Console.WriteLine("Status of -   Hull  : {0}", num5);
										Console.ReadLine();
										base.gray();
									}
									if (num3 == 1)
									{
										base.white();
										Console.WriteLine("The Enemy seem to be holding their fire waiting for the opertune moment");
										Console.ReadLine();
										num16 += 750;
										num18 += 3;
										num1 = 0;
										base.yellow();
										Console.WriteLine("Enemy Attack ; {0}", num1);
										base.green();
										Thread.Sleep(1000);
										Console.WriteLine("Status of -   Crew  : {0}", num7);
										Console.WriteLine("Status of - Cannons : {0}", num6);
										Console.WriteLine("Status of -   Hull  : {0}", num5);
										base.gray();
										Console.ReadLine();
									}
									if (num3 == 2)
									{
										base.white();
										Console.WriteLine("The enemy ready their cannons and FIRE !");
										Console.ReadLine();
										num1 = num18 * num17;
										num7 -= 3;
										base.yellow();
										Console.WriteLine("Enemy Attack ; {0}", num1);
										num5 -= num1;
										base.green();
										Console.WriteLine();
										Console.WriteLine("Status of -   Crew  : {0}", num7);
										Console.WriteLine("Status of - Cannons : {0}", num6);
										Console.WriteLine("Status of -   Hull  : {0}", num5);
										base.gray();
										Console.ReadLine();
									}
									num4 = Convert.ToInt16(random1.Next(1, 60));
									if (num4 == 58)
									{
										base.white();
										Console.WriteLine(" OH NO THE GUN POW");
										Console.ReadLine();
										Console.Clear();
										break;
									}
								}
								if (str == "hold fire")
								{
									Console.WriteLine("Your crew plug holes in the hull with what ever is around");
									Console.ReadLine();
									num5 += 1000;
									num7++;
									num6 += 4;
									base.green();
									Console.WriteLine();
									Console.WriteLine(string.Concat(" Your Hull ", num5));
									Console.WriteLine(string.Concat(" Your Cannons ", num6));
									Console.WriteLine(string.Concat(" Your Crew ", num7));
									base.gray();
									Console.ReadLine();
									num3 = Convert.ToInt16(random.Next(1, 3));
									if (num3 == 3)
									{
										base.white();
										Console.WriteLine("The Enemy Shoots you with poorly timed cannon fire");
										Console.ReadLine();
										num1 = num18 * num17;
										num18--;
										num5 -= num1;
										num7 -= 2;
										base.yellow();
										Console.WriteLine("Enemy Attack ; {0}", num1);
										base.green();
										Console.WriteLine();
										Console.WriteLine("Status of -   Crew  : {0}", num7);
										Console.WriteLine("Status of - Cannons : {0}", num6);
										Console.WriteLine("Status of -   Hull  : {0}", num5);
										Console.ReadLine();
										base.gray();
									}
									if (num3 == 1)
									{
										base.white();
										Console.WriteLine("The Enemy seem to be holding their fire waiting for the opertune moment");
										Console.ReadLine();
										num16 += 750;
										num18 += 3;
										num1 = 0;
										base.yellow();
										Console.WriteLine("Enemy Attack ; {0}", num1);
										base.green();
										Thread.Sleep(1000);
										Console.WriteLine("Status of -   Crew  : {0}", num7);
										Console.WriteLine("Status of - Cannons : {0}", num6);
										Console.WriteLine("Status of -   Hull  : {0}", num5);
										base.gray();
										Console.ReadLine();
									}
									if (num3 == 2)
									{
										base.white();
										Console.WriteLine("The enemy ready their cannons and FIRE !");
										Console.ReadLine();
										num1 = num18 * num17;
										num7 -= 3;
										base.yellow();
										Console.WriteLine("Enemy Attack ; {0}", num1);
										num5 -= num1;
										base.green();
										Console.WriteLine();
										Console.WriteLine("Status of -   Crew  : {0}", num7);
										Console.WriteLine("Status of - Cannons : {0}", num6);
										Console.WriteLine("Status of -   Hull  : {0}", num5);
										base.gray();
										Console.ReadLine();
									}
									num4 = Convert.ToInt16(random1.Next(1, 60));
									if (num4 == 58)
									{
										base.white();
										Console.WriteLine(" OH NO THE GUN POW");
										// NEED TO AFILL THIS IN ! 
										Console.Clear();
									}
								}
								if (!(str == "aim"))
								{
									Console.Clear();
								}
								else
								{
									Console.Clear();
									num6 += 3;
									num7 += 3;
									num5 += 250;
									Console.WriteLine(" Your Crew consolidate and Aim at your target gaining bonuses to all 3 stats");
									Console.ReadLine();
									base.green();
									Console.WriteLine("Stat Increase -   Crew  : {0}", num7);
									Console.WriteLine("Stat Increase - Cannons : {0}", num6);
									Console.WriteLine("Stat Increase -   Hull  : {0}", num5);
									base.gray();
									Console.ReadLine();
									num3 = Convert.ToInt16(random.Next(1, 3));
									if (num3 == 3)
									{
										base.white();
										Console.WriteLine("The Enemy Shoots you with poorly timed cannon fire");
										Console.ReadLine();
										num1 = num18 * num17;
										num18--;
										num5 -= num1;
										num7 -= 2;
										base.yellow();
										Console.WriteLine("Enemy Attack ; {0}", num1);
										base.green();
										Console.WriteLine();
										Console.WriteLine("Status of -   Crew  : {0}", num7);
										Console.WriteLine("Status of - Cannons : {0}", num6);
										Console.WriteLine("Status of -   Hull  : {0}", num5);
										Console.ReadLine();
										base.gray();
									}
									if (num3 == 1)
									{
										base.white();
										Console.WriteLine("The Enemy seem to be holding their fire waiting for the opertune moment");
										Console.ReadLine();
										num16 += 750;
										num18 += 3;
										num1 = 0;
										base.yellow();
										Console.WriteLine("Enemy Attack ; {0}", num1);
										base.green();
										Thread.Sleep(1000);
										Console.WriteLine("Status of -   Crew  : {0}", num7);
										Console.WriteLine("Status of - Cannons : {0}", num6);
										Console.WriteLine("Status of -   Hull  : {0}", num5);
										base.gray();
										Console.ReadLine();
									}
									if (num3 == 2)
									{
										base.white();
										Console.WriteLine("The enemy ready their cannons and FIRE !");
										Console.ReadLine();
										num1 = num18 * num17;
										num7 -= 3;
										base.yellow();
										Console.WriteLine("Enemy Attack ; {0}", num1);
										num5 -= num1;
										base.green();
										Console.WriteLine();
										Console.WriteLine("Status of -   Crew  : {0}", num7);
										Console.WriteLine("Status of - Cannons : {0}", num6);
										Console.WriteLine("Status of -   Hull  : {0}", num5);
										base.gray();
										Console.ReadLine();
									}
									num4 = Convert.ToInt16(random1.Next(1, 60));
									if (num4 == 58)
									{
										base.white();
										Console.WriteLine(" OH NO THE GUN POW");

									}
								}
							}
							if (num5 >= 0)
							{
								base.gray();
								Console.WriteLine("The smoke clears all that is left is the burning wreckage of Black Beards ship.");
								Console.WriteLine();
								Console.Write("You did it ");
								base.red();
								Console.Write("Jack ");
								base.gray();
								Console.WriteLine("The War is over whats left of Black beards Ships will run away in panic");
								Console.WriteLine("press enter to continue");
								Console.WriteLine("Break out the rum !!");
								Console.ReadLine();
								base.green();
								base.white();
								Console.WriteLine();
								Console.WriteLine(" VICTORY IS OURS");
								Console.WriteLine();
								base.green();
								Console.WriteLine(string.Concat(" Your Hull ", num5));
								Console.WriteLine(string.Concat(" Your Cannons ", num6));
								Console.WriteLine(string.Concat(" Your Crew ", num7));
								Console.ReadLine();
								base.gray();
								Console.Clear();
								Console.WriteLine("The Lands and Seas belong to you now what will you do?");
								Console.WriteLine("hold on a minute. There is movement in the fog to the distance, who could that be");
								Console.WriteLine("press enter to continue");
								Console.Clear();
								Console.WriteLine("The fog clears and a ship is left in its place");
								Console.Write("as");
								base.red();
								Console.Write(" Jack ");
								base.gray();
								Console.WriteLine("looks at the ship a terrible shiver runs down his whole body.");
								Console.ReadLine();
								base.cyan();
								Console.WriteLine("ITS OVERLY ATTACHED PIRATE WENCH");
								Console.WriteLine();
								base.white();
								Console.WriteLine(" 'I LOVE YOU' ");
								Console.WriteLine();
								base.gray();
								Console.WriteLine(" her ships sail port side and her crew load their cannons. hell hath no fury like a woman");
								base.gray();
								Console.WriteLine("press 'enter' to face your doom");
								shipAnimation.GFship();
								Console.ReadLine();
								while (true)
								{
									if ((num5 <= 0 ? true : num19 <= 0))
									{
										break;
									}
									Console.Clear();
									Console.WriteLine("The Final Battle begins");
									Console.WriteLine("Good luck");
									base.green();
									Console.WriteLine();
									Console.WriteLine("Jack's Ship Hull: {0} ", num5);
									base.gray();
									Console.WriteLine("Enemy Ship Hull: {0}", num19);
									Console.WriteLine();
									base.red();
									Console.WriteLine(" |||||**** HOLD STEADY MEN ****||||| ");
									Console.WriteLine();
									base.white();
									Console.WriteLine("What will you do");
									base.gray();
									Console.Write("you can either");
									base.white();
									Console.Write(" `hold fire'");
									base.gray();
									Console.Write(" or ");
									base.white();
									Console.WriteLine("`fire'");
									base.gray();
									Console.Write(" or ");
									base.white();
									Console.WriteLine("aim");
									base.yellow();
									str = Console.ReadLine();
									Console.Clear();
									if (str == "fire")
									{
										Console.Clear();
										Console.ReadLine();
										num8 = num7 * num6;
										num21 -= 3;
										Console.WriteLine("Your Crew load the cannons and Fire");
										Console.WriteLine("Our Attack ; {0}", num8);
										num19 -= num8;
										Console.ReadLine();
										num3 = Convert.ToInt16(random.Next(1, 3));
										if (num3 == 3)
										{
											base.white();
											Console.WriteLine("The Enemy Shoots you with poorly timed cannon fire");
											Console.ReadLine();
											num2 = num21 * num20;
											num21--;
											num5 -= num2;
											num7 -= 3;
											base.yellow();
											Console.WriteLine("Enemy Attack ; {0}", num2);
											base.green();
											Console.WriteLine();
											Console.WriteLine("Status of -   Crew  : {0}", num7);
											Console.WriteLine("Status of - Cannons : {0}", num6);
											Console.WriteLine("Status of -   Hull  : {0}", num5);
											Console.ReadLine();
											base.gray();
										}
										if (num3 == 1)
										{
											base.white();
											Console.WriteLine("The Enemy seem to be holding their fire waiting for the opertune moment");
											Console.ReadLine();
											num19 += 750;
											num21 += 3;
											num2 = 10;
											base.yellow();
											Console.WriteLine("Enemy Attack ; {0}", num2);
											base.green();
											Console.WriteLine();
											Console.WriteLine("Status of -   Crew  : {0}", num7);
											Console.WriteLine("Status of - Cannons : {0}", num6);
											Console.WriteLine("Status of -   Hull  : {0}", num5);
											base.gray();
											Console.ReadLine();
										}
										if (num3 == 2)
										{
											base.white();
											Console.WriteLine("The enemy ready their cannons and FIRE !");
											Console.ReadLine();
											num2 = num21 * num20;
											num7 -= 3;
											base.yellow();
											Console.WriteLine("Enemy Attack ; {0}", num2);
											num5 -= num2;
											base.green();
											Console.WriteLine();
											Console.WriteLine("Status of -   Crew  : {0}", num7);
											Console.WriteLine("Status of - Cannons : {0}", num6);
											Console.WriteLine("Status of -   Hull  : {0}", num5);
											base.gray();
											Console.ReadLine();
										}
										num4 = Convert.ToInt16(random1.Next(1, 30));
										if ((num4 != 29 || num4 != 17 ? false : num4 == 22))
										{
											base.white();
											Console.WriteLine(" OH NO THE GUN POW");
											// NEED TO AFILL THIS IN ! 
											Console.Clear();
										}
									}
									if (str == "hold fire")
									{
										num5 += 1100;
										num7++;
										num6 += 5;
										Console.WriteLine("Your crew fix the ships damages with whatever they can find");
										Console.ReadLine();
										base.green();
										Console.WriteLine();
										Console.WriteLine(string.Concat(" Your Hull ", num5));
										Console.WriteLine(string.Concat(" Your Cannons ", num6));
										Console.WriteLine(string.Concat(" Your Crew ", num7));
										Console.ReadLine();
										num3 = Convert.ToInt16(random.Next(1, 3));
										if (num3 == 3)
										{
											base.white();
											Console.WriteLine("The Enemy Shoots you with poorly timed cannon fire");
											Console.ReadLine();
											num2 = num21 * num20;
											num21--;
											num5 -= num2;
											num7 -= 3;
											base.yellow();
											Console.WriteLine("Enemy Attack ; {0}", num2);
											base.green();
											Console.WriteLine();
											Console.WriteLine("Status of -   Crew  : {0}", num7);
											Console.WriteLine("Status of - Cannons : {0}", num6);
											Console.WriteLine("Status of -   Hull  : {0}", num5);
											Console.ReadLine();
											base.gray();
										}
										if (num3 == 1)
										{
											base.white();
											Console.WriteLine("The Enemy seem to be holding their fire waiting for the opertune moment");
											Console.ReadLine();
											num19 += 750;
											num21 += 3;
											num2 = 10;
											base.yellow();
											Console.WriteLine("Enemy Attack ; {0}", num2);
											base.green();
											Console.WriteLine();
											Console.WriteLine("Status of -   Crew  : {0}", num7);
											Console.WriteLine("Status of - Cannons : {0}", num6);
											Console.WriteLine("Status of -   Hull  : {0}", num5);
											base.gray();
											Console.ReadLine();
										}
										if (num3 == 2)
										{
											base.white();
											Console.WriteLine("The enemy ready their cannons and FIRE !");
											Console.ReadLine();
											num2 = num21 * num20;
											num7 -= 3;
											base.yellow();
											Console.WriteLine("Enemy Attack ; {0}", num2);
											num5 -= num2;
											base.green();
											Console.WriteLine();
											Console.WriteLine("Status of -   Crew  : {0}", num7);
											Console.WriteLine("Status of - Cannons : {0}", num6);
											Console.WriteLine("Status of -   Hull  : {0}", num5);
											base.gray();
											Console.ReadLine();
										}
										num4 = Convert.ToInt16(random1.Next(1, 30));
										if ((num4 != 29 || num4 != 17 ? false : num4 == 22))
										{
											base.white();
											Console.WriteLine(" OH NO THE GUN POW");
											// NEED TO AFILL THIS IN ! 
											Console.Clear();
										}
									}
									if (!(str == "aim"))
									{
										Console.Clear();
									}
									else
									{
										Console.Clear();
										num6 += 3;
										num7 += 4;
										num5 += 500;
										Console.WriteLine(" Your Crew consolidate and Aim at your target gaining bonuses to all 3 stats");
										Console.ReadLine();
										base.green();
										Console.WriteLine("Stat Increase -   Crew  : {0}", num7);
										Console.WriteLine("Stat Increase - Cannons : {0}", num6);
										Console.WriteLine("Stat Increase -   Hull  : {0}", num5);
										base.gray();
										Console.ReadLine();
										num3 = Convert.ToInt16(random.Next(1, 3));
										if (num3 == 3)
										{
											base.white();
											Console.WriteLine("The Enemy Shoots you with poorly timed cannon fire");
											Console.ReadLine();
											num2 = num21 * num20;
											num21--;
											num5 -= num2;
											num7 -= 3;
											base.yellow();
											Console.WriteLine("Enemy Attack ; {0}", num2);
											base.green();
											Console.WriteLine();
											Console.WriteLine("Status of -   Crew  : {0}", num7);
											Console.WriteLine("Status of - Cannons : {0}", num6);
											Console.WriteLine("Status of -   Hull  : {0}", num5);
											Console.ReadLine();
											base.gray();
										}
										if (num3 == 1)
										{
											base.white();
											Console.WriteLine("The Enemy seem to be holding their fire waiting for the opertune moment");
											Console.ReadLine();
											num19 += 750;
											num21 += 3;
											num2 = 10;
											base.yellow();
											Console.WriteLine("Enemy Attack ; {0}", num2);
											base.green();
											Console.WriteLine();
											Console.WriteLine("Status of -   Crew  : {0}", num7);
											Console.WriteLine("Status of - Cannons : {0}", num6);
											Console.WriteLine("Status of -   Hull  : {0}", num5);
											base.gray();
											Console.ReadLine();
										}
										if (num3 == 2)
										{
											base.white();
											Console.WriteLine("The enemy ready their cannons and FIRE !");
											Console.ReadLine();
											num2 = num21 * num20;
											num7 -= 3;
											base.yellow();
											Console.WriteLine("Enemy Attack ; {0}", num2);
											num5 -= num2;
											base.green();
											Console.WriteLine();
											Console.WriteLine("Status of -   Crew  : {0}", num7);
											Console.WriteLine("Status of - Cannons : {0}", num6);
											Console.WriteLine("Status of -   Hull  : {0}", num5);
											base.gray();
											Console.ReadLine();
										}
										num4 = Convert.ToInt16(random1.Next(1, 30));
										if ((num4 != 29 || num4 != 17 ? false : num4 == 22))
										{
											base.white();
											Console.WriteLine(" OH NO THE GUN POW");
											// NEED TO AFILL THIS IN ! 
											Console.Clear();
										}
									}
									if (num5 < 0)
									{
										Console.WriteLine("hahahah");
										Console.ReadLine();
										Console.Clear();
										deathscene.gameover();
										deathscene.gameover2();
										deathscene.gameover();
										deathscene.gameover2();
										deathscene.gameover();
										deathscene.gameover2();
										deathscene.gameover();
										deathscene.gameover2();
										flag = false;
										break;
									}
								}
								Console.WriteLine(" Well done ");
								Console.WriteLine(" You Are King Of The Seas Agian ");
								Console.WriteLine(" You are the True Pirate King!");
								Console.ReadLine();
								flag = false;
							}
							else
							{
								Console.WriteLine("hahahah");
								Console.ReadLine();
								Console.Clear();
								deathscene.gameover();
								deathscene.gameover2();
								deathscene.gameover();
								deathscene.gameover2();
								deathscene.gameover();
								deathscene.gameover2();
								deathscene.gameover();
								deathscene.gameover2();
								flag = false;
							}
						}
						else
						{
							Console.WriteLine("hahahah");
							Console.ReadLine();
							Console.Clear();
							deathscene.gameover();
							deathscene.gameover2();
							deathscene.gameover();
							deathscene.gameover2();
							deathscene.gameover();
							deathscene.gameover2();
							deathscene.gameover();
							deathscene.gameover2();
							flag = false;
						}

					}


				}
			}
	}	}
}