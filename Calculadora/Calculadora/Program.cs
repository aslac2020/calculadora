using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0; int num2 = 0;

            Console.WriteLine("Minha Calculadora\n");
            Console.WriteLine("---------------------\n");


            //usuario digitar o nome
            Console.WriteLine("Insira um número, e pressione Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira outro número, e pressione Enter");
            num2 = Convert.ToInt32(Console.ReadLine());


            //Opçoes de selecão
            Console.WriteLine("Selecione uma Opção:");
            Console.WriteLine("\tsm - Soma");
            Console.WriteLine("\tst - Subtração");
            Console.WriteLine("\tm - Multiplicação");
            Console.WriteLine("\td - Divisão");
            Console.WriteLine("Sua opção?");

            switch (Console.ReadLine())
            {
                case "sm":
                    Console.WriteLine($"Seu Resultado é: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "st":
                    Console.WriteLine($"Seu Resultado é: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Seu Resultado é: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Seu Resultado é: {num1} / {num2} = " + (num1 / num2));
                    break;
                default:
                    break;
            }


        }
    }
}
