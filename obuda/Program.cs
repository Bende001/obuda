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
            Console.WriteLine("1. Feladat");

            char[] betuk = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', };
            var halmbetuk = new HashSet<char>(betuk);

            Console.Write("Írja be a kívánt szöveget kizárólag az angol abc betűit alkalmazva: ");
            string bekert = Console.ReadLine();
            char[] betuzbekert = bekert.ToCharArray();

            foreach (char betu in betuzbekert)
            {
                if (!halmbetuk.Contains(betu))
                {
                    Console.WriteLine("Kérem csak az angol abc betűit használja. ");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}