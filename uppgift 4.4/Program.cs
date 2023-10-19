using System;
using System.Diagnostics.SymbolStore;
using System.Runtime.CompilerServices;

namespace uppgift_4_4
{
    class program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Välj ett av följande alternativ.");
                Console.WriteLine("1. Subtrahera ett tal med ett annat");
                Console.WriteLine("2. Dividera ett tal med ett annat");
                Console.WriteLine("3. Avsluta programmet");
                int s = int.Parse(Console.ReadLine());

                switch (s)
                {
                    case 1:
                    { 
                        Console.WriteLine("Skriv 2 tal på detta sätt 7-6");
                        string svar = Console.ReadLine();
                            int subindex = svar.IndexOf("-");
                            string tal1text = svar[..subindex];
                            string tal2text = svar[(subindex+1)..];

                            int tal1 = int.Parse(tal1text);
                            int tal2 = int.Parse(tal2text);
                            int sum1 = tal1 - tal2;

                            Console.WriteLine("Summan av de två talen blir " + sum1);
                            continue;
                    }
                    case 2:
                    {
                            Console.WriteLine("Skriv 2 tal på detta sätt 7/6");
                            string svar2 = Console.ReadLine();
                            int divindex = svar2.IndexOf("/");
                            string tal3text = svar2[..divindex];
                            string tal4text = svar2[(divindex + 1)..];

                            double tal3 = double.Parse(tal3text);
                            double tal4 = double.Parse(tal4text);
                            double sum1 = tal3 / tal4;

                            Console.WriteLine("kvoten av de två talen blir " + sum1);
                            continue;
                    }
                    case 3:
                    {
                        Console.WriteLine("Programmet avslutar");
                        break;
                    }

                    default:
                    {
                        Console.WriteLine("Välj ett av alternativen");
                        continue;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}