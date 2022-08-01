 using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obuda
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //1.Feladat
            Console.WriteLine("1. Feladat");

            char[] betuk = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' '};
            var halmazbetuk = new HashSet<char>(betuk);

            //szöveg bekérése
            Console.Write("üzenet: ");
            string bekertszoveg = "";
            char[] betuzbekertszoveg = bekertszoveg.ToCharArray();
            int helyesbetu = 0;

                //szöveg vizsgálata
                while (helyesbetu == 0)
                {
                    bekertszoveg = Console.ReadLine();
                    betuzbekertszoveg = bekertszoveg.ToCharArray();

                    foreach (char betu in betuzbekertszoveg)
                    {
                        if (!halmazbetuk.Contains(betu))
                        {
                            Console.WriteLine("Kérem csak az angol abc betűit használja. ");
                            helyesbetu = 0;
                            break;
                        }
                        else helyesbetu++;
                    }
                }
                
            helyesbetu = 0;

            //kulcs bekérése
            Console.Write("kulcs: ");
            string bekertkulcs = "";
            char[] betuzbekertkulcs = bekertkulcs.ToCharArray();

                //kulcs vizsgálata
                while (helyesbetu == 0)
                {
                    bekertkulcs = Console.ReadLine();
                    betuzbekertkulcs = bekertkulcs.ToCharArray();

                    foreach (char betu in betuzbekertkulcs)
                    {
                        if (!halmazbetuk.Contains(betu))
                        {
                            Console.WriteLine("Kérem csak az angol abc betűit használja. ");
                            helyesbetu = 0;
                            break;
                        }
                        else if (bekertkulcs.Length < bekertszoveg.Length)
                        {
                            Console.WriteLine("A szöveggel legalább egyenlő hosszú legyen a kulcs.");
                            break;
                        }
                        else helyesbetu++;
                    }
                }

                helyesbetu = 0;

            //rejtjelzett üzenet
            char[] rejtjelzett = new char[betuzbekertszoveg.Length];
            char szovegbetu, kulcsbetu;
            int szovegszam=0, kulcsszam=0;

            //szöveg és kulcs számmá alakítása, rejtjelzett szöveggé alakítása
            for (int i = 0; i < betuzbekertszoveg.Length; i++)
            {
                for (int j = 0; j < betuk.Length; j++)
                {
                    if (betuzbekertszoveg[i] == betuk[j])
                    {
                        szovegszam = j;
                        break;
                    }
                }
                for (int k = 0; k < betuk.Length; k++)
                {
                    if (betuzbekertkulcs[i] == betuk[k])
                    {
                        kulcsszam = k;
                        break;
                    }
                }

                if ((szovegszam + kulcsszam) > 26) rejtjelzett[i] = betuk[(szovegszam + kulcsszam) % 27];

                else rejtjelzett[i] = betuk[szovegszam + kulcsszam];
            }

            //rejtjelzett szöveg kiírása
            string rejtjelzettteljes = new string(rejtjelzett);
            Console.WriteLine("rejtjelzett üzenet: " + rejtjelzettteljes);

            Console.ReadKey();
        }
    }
}
