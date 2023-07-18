using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, seja bem-vindo! Por favor, informe os cinco valores: ");

            int[] arrayIntegers = ReadValuesInputs();

            int amountEven = 0;
            int amountOdd = 0;
            int amountPositive = 0;
            int amountNegative = 0;

            for (int i = 0; i < arrayIntegers.Length; i++)
            {
                if (arrayIntegers[i] % 2 == 0)
                {
                    amountEven++;

                }
                else
                {
                    amountOdd++;
                }

                if (arrayIntegers[i] > 0)
                {
                    amountPositive++;
                }

                if (arrayIntegers[i] < 0)
                {
                    amountNegative++;
                }
            }
            Console.WriteLine($"Quantidade de numeros pares:{amountEven}");
            Console.WriteLine($"Quantidade de números ímpares:{amountOdd}");
            Console.WriteLine($"Quantidade de números positivos:{amountPositive}");
            Console.WriteLine($"Quantidade de números negativos:{amountNegative}");

        }

        static int[] ReadValuesInputs()
        {
            int[] arrayIntegers = new int[5];

            for (int i = 0; i < arrayIntegers.Length; i++)
            {
                string inputText = Console.ReadLine();
                while (string.IsNullOrEmpty(inputText))
                {
                    Console.WriteLine("Entrada inválida! Por favor, preencher todos os campos corretamente. Não pode conter espaços vazios.");
                    inputText = Console.ReadLine();
                }

                int valueInteger;
                if (int.TryParse(inputText, out valueInteger))
                {
                    arrayIntegers[i] = valueInteger;
                }
                else
                {
                    Console.WriteLine($"Valor inválido! Não foi possível realizar a conversão. ");
                }
            }

            return arrayIntegers;
        }

    }
}
