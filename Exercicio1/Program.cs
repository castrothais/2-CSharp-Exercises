using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Olá! Digite o primeiro valor: ");
            string inputValue1 = Console.ReadLine();
            var value1 = int.TryParse(inputValue1, out int number1);

            Console.WriteLine("Digite o segundo valor: ");
            string inputValue2 = Console.ReadLine();
            var value2 = int.TryParse(inputValue2, out int number2);

            if( inputValue1 == string.Empty || inputValue2 == string.Empty)
            {
                Console.WriteLine("Por favor, preencher o input corretamente!");

            }

            if (successfulConversation(value1, value2))
            {
                Console.WriteLine($"O resultado da soma de “{number1}” com “{number2}” é “{number1 + number2}”");
            }
            else
            {
                Console.WriteLine("Desculpe, ocorreu um erro durante a conversão. Tente novamente");
            }

        }
        static bool successfulConversation(bool vaule1, bool value2)
        {
            if (vaule1 && value2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
