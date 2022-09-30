using System;
namespace Uppgift_3._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet?");
            string svar = Console.ReadLine().ToLower();
            if (svar == "j")
{
                Console.WriteLine("Hur gammal är du ?");

                int ålder = int.Parse(Console.ReadLine());
             if (ålder >= 18&& ålder <= 22)
                    Console.WriteLine("Vi vill gärna anställa dig");
                else
                {
                    Console.WriteLine(" Vi letar tyvärr efter en annan person just nu!");
                }

            }
            if (svar =="n")
{
                Console.WriteLine(" Vi letar tyvärr efter en annan person just nu!");
    
            }
        }
    }
}