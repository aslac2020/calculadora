using System;

namespace Calculator    
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value is "not-a-number" which we use if an operation, such as division, could result in an error.

            // Use a switch statement to do the math.
            switch (op)
            {
                case "sm":
                    result = num1 + num2;
                    break;
                case "st":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
    }

    public class Program
       {
            static void Main(string[] args)
            {
                bool endApp = false;

                Console.WriteLine("Minha Calculadora\n");
                Console.WriteLine("---------------------\n");

            Calculator calculator = new Calculator();

            while (!endApp)
            {
                //declarando variaveis
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                Console.WriteLine("Insira um número, e pressione Enter:");
                numInput1 = Console.ReadLine();


                //primeiro numero
                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Valor inserido inválido, Favor entrar com um valor: ");
                    numInput1 = Console.ReadLine();

                }


                Console.WriteLine("Insira outro número, e pressione Enter:");
                numInput2 = Console.ReadLine();

                //segundo numero
                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Valor inserido inválido, Favor entrar com um valor: ");
                    numInput2 = Console.ReadLine();

                }

                //Opçoes de selecão
                Console.WriteLine("Selecione uma Opção:");
                Console.WriteLine("\tsm - Soma");
                Console.WriteLine("\tst - Subtração");
                Console.WriteLine("\tm - Multiplicação");
                Console.WriteLine("\td - Divisão");
                Console.WriteLine("Sua opção?");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Esta operação resultará em um erro matemático. \n");
                    }
                    else Console.WriteLine("Seu resultado: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ah não! Ocorreu uma exceção ao tentar fazer as contas.\n - Detalhes:" + e.Message);
                }

                Console.WriteLine("------------------------\n");

                Console.Write("Pressione Enter para sair do aplicativo");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.
            }
            return;
            }
        }
    }
