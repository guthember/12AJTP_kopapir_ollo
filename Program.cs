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
            Console.WriteLine("Kő - Papír - Olló játék");
            
            // számítógép lehetséges választásai
            string[] valasztas = new string[] { 
                "Kő",
                "Papír",
                "Olló"
            };

            // véletlen szám 0,1,2
            Random vel = new Random();
            int mit = vel.Next(0, 3);

            // Ellenőrzés! a végleges kódba nem kell
            //for (int i = 0; i < 10; i++)
            //{
            //    mit = vel.Next(0, 3);
            //    Console.WriteLine(valasztas[mit]);
            //}
            Console.WriteLine("Kérek egy lehetőséget: ");
            Console.WriteLine("Kő -> 1, Papír -> 2, Olló -> 3");
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
	            }
                else
                {
                    nyert = "Gép";
                }
            }
            // számítógép Papír
            else if (mit == 1)
            {
                if (felhMit == 0)
                {
                    nyert = "Gép";
                }
                else if (felhMit == 1)
                {
                    nyert = "Döntetlen";
                }
                else
                {
                    nyert = "Ember";
                }  
            }
            // számítógé Olló
            else
            {
                if (felhMit == 0)
                {
                    nyert = "Ember";
                }
                else if (felhMit == 1)
                {
                    nyert = "Gép";
                }
                else
                {
                    nyert = "Döntelen";
                }  
            }

            Console.WriteLine("Gép: {0}", valasztas[mit]);
            Console.WriteLine("Ember: {0}", valasztas[felhMit]);
            Console.WriteLine(nyert);

            Console.ReadKey();
        }
    }
}
