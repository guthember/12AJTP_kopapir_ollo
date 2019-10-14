using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoPapirOllo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kő    legyőzi az ollót
            // Papír legyőzi a  követ
            // Olló  legyőzi a  papírt
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Kő - Papír - Olló játék");
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("| Kő -> 1, Papír -> 2, Olló -> 3 |");
            Console.WriteLine("----------------------------------\n");
            // számítógép lehetséges választásai
            string[] valasztas = new string[] { 
                "Kő",
                "Papír",
                "Olló"
            };

            // nyerések könyvelése
            int emberNyer = 0;
            int gepNyer = 0;
            int korokSzama = 1;

            // véletlen szám 0,1,2
            Random vel = new Random();

            // játék kezdete
            // leállási feltételt megfogalmazni
            // addig amíg 
            //      az "emberNyer" vagy a "gepNyer" nem egyenlő hárommal!!
            //while ( !(emberNyer == 3 || gepNyer == 3) ) // true
            // egyszerűbb megfogalmazás
            while( emberNyer < 3 && gepNyer < 3)
            {
                int mit = vel.Next(0, 3);

                // Ellenőrzés! a végleges kódba nem kell
                //for (int i = 0; i < 10; i++)
                //{
                //    mit = vel.Next(0, 3);
                //    Console.WriteLine(valasztas[mit]);
                //}
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0}. kör --------------------------",korokSzama++);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Kérek egy lehetőséget: ");
                
                int felhMit = Convert.ToInt32(Console.ReadLine()) - 1;

                // Ellenőrzés! a végleges kódba nem kell
                //Console.WriteLine(valasztas[felhMit]);

                // Eredmény kiértékelése
                string nyert = "";

                // számítógép Kő
                if (mit == 0)
                {
                    if (felhMit == 0)
                    {
                        nyert = "Döntetlen";
                    }
                    else if (felhMit == 1)
                    {
                        nyert = "Ember";
                        emberNyer++;
                    }
                    else
                    {
                        nyert = "Gép";
                        gepNyer++;
                    }
                }
                // számítógép Papír
                else if (mit == 1)
                {
                    if (felhMit == 0)
                    {
                        nyert = "Gép";
                        gepNyer++;
                    }
                    else if (felhMit == 1)
                    {
                        nyert = "Döntetlen";
                    }
                    else
                    {
                        nyert = "Ember";
                        emberNyer++;
                    }
                }
                // számítógé Olló
                else
                {
                    if (felhMit == 0)
                    {
                        nyert = "Ember";
                        emberNyer++;
                    }
                    else if (felhMit == 1)
                    {
                        nyert = "Gép";
                        gepNyer++;
                    }
                    else
                    {
                        nyert = "Döntelen";
                    }
                }

                Console.WriteLine("Gép: {0}", valasztas[mit]);
                Console.WriteLine("Ember: {0}", valasztas[felhMit]);
                Console.WriteLine(nyert);

                // Minden egyes körben kiírjuk az eredményt
                Console.WriteLine("Ember: {0} --- Gép: {1}",emberNyer,gepNyer);

            }

            Console.WriteLine("\nAbszolút győztes:");
            // Abszolút győztes kiírása
            if (emberNyer > gepNyer)
            {
                Console.WriteLine("----> EMBER <----");
            }
            else if (gepNyer > emberNyer)
            {
                Console.WriteLine("----> GÉP <----");
            }
            else
            {
                Console.WriteLine("----> DÖNTETLEN <----");
            }

            Console.ReadKey();
        }
    }
}
