using System;
using System.Collections.Generic;
using System.Linq;

namespace TestTask1Intetics
{
    internal class Program
    {
        private const int NUMBER_OF_DIAGONALS = 999;

        private static List<int> GetDiagonalElement(int diagonalNumber)
        {
            if (diagonalNumber == 0) return new List<int> {NUMBER_OF_DIAGONALS*NUMBER_OF_DIAGONALS};
            var diagonalElements = new List<int>();
            int firstNumber, secondNumber;
            if (diagonalNumber%2 == 0)
            {
                firstNumber = secondNumber = NUMBER_OF_DIAGONALS - diagonalNumber/2;
            }
            else
            {
                firstNumber = NUMBER_OF_DIAGONALS - diagonalNumber/2;
                secondNumber = NUMBER_OF_DIAGONALS - diagonalNumber/2 + 1;
            }

            while ((firstNumber != NUMBER_OF_DIAGONALS + 1) && (secondNumber/100 != 0))
            {
                diagonalElements.Add(firstNumber*secondNumber);
                firstNumber++;
                secondNumber--;
            }
            return diagonalElements;
        }

        private static bool IsPolindrom(int numberToCheck)
        {
            var number = numberToCheck.ToString();
            return number.CompareTo(new string(number.Reverse().ToArray())) == 0;
        }

        private static void SolveSmart()
        {
            for (var diagonalIndex = 0; diagonalIndex < NUMBER_OF_DIAGONALS; diagonalIndex++)
            {
                var diagonalElements = GetDiagonalElement(diagonalIndex);
                foreach (var product in diagonalElements)
                {
                    if (IsPolindrom(product))
                    {
                        Console.WriteLine(product);
                        Console.ReadLine();
                        return;
                    }
                }
            }
        }


        private static void Main(string[] args)
        {
            SolveSmart();
            Console.ReadLine();
        }
    }
}