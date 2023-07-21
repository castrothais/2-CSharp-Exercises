using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Olá, seja bem-vindo! Por favor, informe os quatro valores.Sendo respectivamente: A,B,C e D. ");

            int[] arrayIntegers = ReadValuesInputs();

            int valueA = arrayIntegers[0];
            int valueB = arrayIntegers[1];
            int valueC = arrayIntegers[2];
            int valueD = arrayIntegers[3];


            if (valueB > valueC && valueD > valueA && (valueC + valueD) > (valueA + valueB) && valueC > 0 && valueD > 0 && valueA % 2 == 0)
            {
                Console.WriteLine("Valores Aceitos");
            }
            else
            {
                Console.WriteLine("Valores Não Aceitos");
            }
        }

        static int[] ReadValuesInputs()
        {
            int[] arrayIntegers = new int[4];
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
