using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verschillende int variabelen aanmaken:
            int number, firstNumber = 0, secondNumber = 1, NextNumber, i;
            // Vraag aan gebruiker hoeveel getallen er getoont moeten worden:
            Console.Write("Vul hier het aantal nummers in dat u wilt tonen : ");
            number = Int32.Parse(Console.ReadLine());
            // For loop + If en Else statement
            for (i = 0; i < number; i++)
            {
                // Als i kleiner of gelijk is aan i ga naar de writeline:
                if (i <= 1)
                    NextNumber = i;
                // Anders doe berekening voor volgende getal en toon gebruiker::
                else
                {
                    NextNumber = firstNumber + secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = NextNumber;
                }
                // Writeline om de gebruiker te laten tonen:
                Console.Write(NextNumber + ", ");
            }
            Console.ReadKey();
        }
    }
}
