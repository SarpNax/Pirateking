using System;
using System.Threading;

namespace Pirate_King
{
    internal class PirateKingLogo : Colour
    { public PirateKingLogo()
        {
        }

        public void Logo1()
        {
            base.yellow();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" P)P)P)P)  i)i)                        t)t)              K)  K)K)   i)i)                            ");
            Console.WriteLine(" P)P)  P)                            t)t)t)t)            K) K)                                      ");
            Console.WriteLine(" P)P)  P)  i)i)  r)r)r)r)  a)a)a)a)    t)t)   e)e)e)e)   K)K)       i)i)  n)n)n)n)     g)g)g)       ");
            Console.WriteLine(" P)P)P)P)  i)i)  r)r)  r)  a)a)  a)    t)t)   e)e)e)     K) K)      i)i)  n)n)  n)n)  g)   g)       ");
            Console.WriteLine(" P)P)      i)i)  r)r)      a)a)  a)a)  t)t)   e)         K)  K)     i)i)  n)n)  n)n)  g)   g)       ");
            Console.WriteLine(" P)P)      i)i)  r)r)      a)a)a)a)a)  t)t)   e)e)e)e)   K)   K)K)  i)i)  n)n)  n)n)  g)g)g)        ");
            Console.WriteLine("                                                                                           g)       ");
            Console.WriteLine("                                                                                       g)g)g)       ");
            Thread.Sleep(500);
            Console.Clear();
        }

        public void Logo2()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" P)P)P)P)  i)i)                        t)t)              K)  K)K)   i)i)                            ");
            Console.WriteLine(" P)P)  P)                            t)t)t)t)            K) K)                                      ");
            Console.WriteLine(" P)P)  P)  i)i)  r)r)r)r)  a)a)a)a)    t)t)   e)e)e)e)   K)K)       i)i)  n)n)n)n)     g)g)g)       ");
            Console.WriteLine(" P)P)P)P)  i)i)  r)r)  r)  a)a)  a)    t)t)   e)e)e)     K) K)      i)i)  n)n)  n)n)  g)   g)       ");
            Console.WriteLine(" P)P)      i)i)  r)r)      a)a)  a)a)  t)t)   e)         K)  K)     i)i)  n)n)  n)n)  g)   g)       ");
            Console.WriteLine(" P)P)      i)i)  r)r)      a)a)a)a)a)  t)t)   e)e)e)e)   K)   K)K)  i)i)  n)n)  n)n)  g)g)g)        ");
            Console.WriteLine("                                                                                           g)       ");
            Console.WriteLine("                                                                                       g)g)g)       ");
            Thread.Sleep(500);
            Console.Clear();
        }
        public void Logo3()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" P)P)P)P)  i)i)                        t)t)              K)  K)K)   i)i)                            ");
            Console.WriteLine(" P)P)  P)                            t)t)t)t)            K) K)                                      ");
            Console.WriteLine(" P)P)  P)  i)i)  r)r)r)r)  a)a)a)a)    t)t)   e)e)e)e)   K)K)       i)i)  n)n)n)n)     g)g)g)       ");
            Console.WriteLine(" P)P)P)P)  i)i)  r)r)  r)  a)a)  a)    t)t)   e)e)e)     K) K)      i)i)  n)n)  n)n)  g)   g)       ");
            Console.WriteLine(" P)P)      i)i)  r)r)      a)a)  a)a)  t)t)   e)         K)  K)     i)i)  n)n)  n)n)  g)   g)       ");
            Console.WriteLine(" P)P)      i)i)  r)r)      a)a)a)a)a)  t)t)   e)e)e)e)   K)   K)K)  i)i)  n)n)  n)n)  g)g)g)        ");
            Console.WriteLine("                                                                                           g)       ");
            Console.WriteLine("                                                                                       g)g)g)       ");

        }
        public void Logo4()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The text turn based sailing combat game !");
            Console.WriteLine("Set sail at your own peril. ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Created by Nax (AKA SARP)");
        }

    }
}