using System.Diagnostics;

namespace GisaTalet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool spelaIgen = true;

            while (spelaIgen)
            {
                int hemligTal = random.Next(1, 101);
                int antalGissningar = 0;
                int gissning = 0;

                Console.WriteLine("Välkommen till Gissa Talet!");
                Console.WriteLine("Jag har valt ett tal mellan 1 och 100. Kan du gissa vilket?");


                // Här börjar själva gissningsloopen
                while (gissning != hemligTal)
                {
                    Console.Write("Ange din gissning: ");
                    bool correctInput = int.TryParse(Console.ReadLine(), out gissning);
                    if (!correctInput)
                    {
                        Console.WriteLine("Var god ange ett giltigt nummer.");
                        continue;
                    }
                    antalGissningar++;
                    if (gissning < hemligTal)
                    {
                        Console.WriteLine("För lågt! Försök igen.");
                    }
                    else if (gissning > hemligTal)
                    {
                        Console.WriteLine("För högt! Försök igen.");
                    }
                    else
                    {
                        Console.WriteLine($"Grattis! Du gissade rätt på {antalGissningar} försök.");
                    }

                    // Ge en ledtråd efter 5 felaktiga gissningar
                    if (antalGissningar == 5 && gissning != hemligTal)
                    {
                        if (hemligTal % 2 == 0)
                        {
                            Console.WriteLine("Ledtråd: Talet är jämnt.");
                        }
                        else
                        {
                            Console.WriteLine("Ledtråd: Talet är udda.");
                        }
                    }
                    // fråga om spelaren vill spela igen
                    if (gissning == hemligTal)
                    {
                        Console.Write("Vill du spela igen? (ja/nej): ");
                        string svar = Console.ReadLine().ToLower();
                        if (svar == "ja")
                        {
                            spelaIgen = true;
                        }
                        else
                        {
                            spelaIgen = false;
                            Console.WriteLine("Tack för att du spelade! Hej då!");
                        }



                    }
                }
            }
        }
    }

}