using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro algarismo:");
            string primeiroAlgarismoEmString = Console.ReadLine();
            decimal primeiroAlgarismoEmDecimal = Convert.ToDecimal(primeiroAlgarismoEmString);

            Console.WriteLine("Digite o segundo algarismo:");
            string segundoAlgarismoEmString = Console.ReadLine();
            decimal segundoAlgarismoEmDecimal = Convert.ToDecimal(segundoAlgarismoEmString);

            Console.WriteLine("Digite a operação:");
            string operacao = Console.ReadLine();

            decimal resultado = 0;

            if (operacao == "+")
            {
                resultado = primeiroAlgarismoEmDecimal + segundoAlgarismoEmDecimal;

            }
            else if (operacao == "-")
            {
                resultado = primeiroAlgarismoEmDecimal - segundoAlgarismoEmDecimal;
            }
            else if (operacao == "*")
            {
                resultado = primeiroAlgarismoEmDecimal * segundoAlgarismoEmDecimal;
            }
            else if (operacao == "/")
            {
                resultado = primeiroAlgarismoEmDecimal / segundoAlgarismoEmDecimal;
            }
            else
            {
                Console.WriteLine("Operação errada!");
            }

            Console.WriteLine("O resultado foi: " + resultado);
            Console.WriteLine();
            decimal div = primeiroAlgarismoEmDecimal / segundoAlgarismoEmDecimal;
            decimal resto = primeiroAlgarismoEmDecimal % segundoAlgarismoEmDecimal;
            Console.WriteLine("O resto é = " + resto);
            Console.WriteLine();
            if (resultado % 2 == 0)
                Console.WriteLine("Logo é PAR!");
            else
                Console.WriteLine("Logo é íMPAR!");



            //
            //if(numero == "1")
            //{
            //    Console.WriteLine("O número digitado foi igual a 1");
            //}
            //else
            //{
            //    Console.WriteLine("ERRRRRRRRRRROOOU");
            //}


            Console.ReadKey();
        }
    }
}
