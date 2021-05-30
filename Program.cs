using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 0; int num2 = 0;


            Console.WriteLine("Napišite broj i pritisnite ENTER");
            num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Napišite još jedan broj i pritisnite ENTER");
            num2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Odaberite opciju:");
            Console.WriteLine("\tz - Zbrajanje");
            Console.WriteLine("\to - Oduzimanje");
            Console.WriteLine("\tm - Mnozenje");
            Console.WriteLine("\td - Dijeljenje");
            Console.Write("Vaša opcija? ");


            switch (Console.ReadLine())
            {
                case "z":
                    Console.WriteLine($"Vaš rezultat: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "o":
                    Console.WriteLine($"Vaš rezultat: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Vaš rezultat: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Vaš rezultat: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            Console.Write("Pritisnite bilo koju tipku za nastavak.");
            Console.ReadKey();
        }
    }
}