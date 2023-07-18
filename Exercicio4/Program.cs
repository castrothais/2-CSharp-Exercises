using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá. Por favor, digite o valor da sua nota: ");

            string inputTextGrade = Console.ReadLine();
            // Verifica se é nula ou vazia
            if (string.IsNullOrWhiteSpace(inputTextGrade))
            {
                Console.WriteLine("Entrada inválida. Por favor, inserir os dados corretamente. Não pode conter espaços vazios ou nulos.");
            }
            else
            {
                if (DecimalInputValidation(inputTextGrade, out double gradeInputnumber))
                {
                    if (gradeInputnumber >= 0 && gradeInputnumber <= 3.99)
                    {
                        Console.WriteLine("Péssimo");
                    }
                    else if (gradeInputnumber <= 5.99)
                    {
                        Console.WriteLine("Regular");
                    }
                    else if (gradeInputnumber <= 7.99)
                    {
                        Console.WriteLine("Bom");
                    }
                    else if (gradeInputnumber <= 10)
                    {
                        Console.WriteLine("Ótimo");
                    }
                    else
                    {
                        Console.WriteLine("Nota Inválida!");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida! Por favor, sua nota deve posuir apenas duas casas decimais e número positivos.");
                }

            }

        }

        static bool DecimalInputValidation(string inputTextGrade, out double gradeInputnumber)
        {
            if (double.TryParse(inputTextGrade, out gradeInputnumber) && (Math.Round(gradeInputnumber, 2) == gradeInputnumber) && gradeInputnumber > 0)
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
