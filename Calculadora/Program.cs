using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first digit: (Digite o primeiro algarismo)");
            string firstDigitInString = Console.ReadLine();
            decimal firstDigitInDecimal = Convert.ToDecimal(firstDigitInString);

            Console.WriteLine("Enter the first digit: (Digite o segundo algarismo)");
            string secondDigitInString = Console.ReadLine();
            decimal secondDigitInDecimal = Convert.ToDecimal(secondDigitInString);

            Console.WriteLine("Enter the operation: (Digite a operação)");
            string operation = Console.ReadLine();

            decimal result = 0;

            if (operation == "+")
            {
                result = firstDigitInDecimal + secondDigitInDecimal;

            }
            else if (operation == "-")
            {
                result = firstDigitInDecimal - secondDigitInDecimal;
            }
            else if (operation == "*")
            {
                result = firstDigitInDecimal * secondDigitInDecimal;
            }
            else if (operation == "/")
            {
                result = firstDigitInDecimal / secondDigitInDecimal;
            }
            else
            {
                Console.WriteLine("Wrong operation! (Operação errada!)");
            }

            Console.WriteLine("O resultado foi: " + result);
            Console.WriteLine();
            decimal div = firstDigitInDecimal / secondDigitInDecimal;
            decimal resto = firstDigitInDecimal % secondDigitInDecimal;
            Console.WriteLine("O resto é = " + resto);
            Console.WriteLine();
            if (result % 2 == 0)
                Console.WriteLine("So it's par (Logo é PAR)");
            else
                Console.WriteLine("So it's odd (Logo é íMPAR)");

            Console.ReadKey();
        }
    }
}
