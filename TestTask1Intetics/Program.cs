using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Threading.Timer;

namespace TestTask1Intetics
{
    class Program
    {
        const int NUMBER_OF_DIAGONALS = 999;

        static List<int> GetDiagonalElement(int diagonalNumber)
        {
            if (diagonalNumber == 0) return new List<int>() { NUMBER_OF_DIAGONALS * NUMBER_OF_DIAGONALS };
            List<int> diagonalElements = new List<int>();
            int firstNumber, secondNumber;
            if (diagonalNumber % 2 == 0)
            {
                firstNumber = secondNumber = NUMBER_OF_DIAGONALS - diagonalNumber / 2;
            }
            else
            {
                firstNumber = NUMBER_OF_DIAGONALS - diagonalNumber / 2;
                secondNumber = NUMBER_OF_DIAGONALS - diagonalNumber / 2 + 1;
            }

            while ((firstNumber != NUMBER_OF_DIAGONALS + 1) && (secondNumber / 100 != 0))
            {
                diagonalElements.Add(firstNumber * secondNumber);
                firstNumber++;
                secondNumber--;
            }
            return diagonalElements;
        }

        static bool IsPolindrom(int numberToCheck)
        {
            string number = numberToCheck.ToString();
            return number.CompareTo(new string(number.Reverse().ToArray())) == 0;
        }

        static void SolveSmart()
        {
            for (int diagonalIndex = 0; diagonalIndex < NUMBER_OF_DIAGONALS; diagonalIndex++)
            {
                List<int> diagonalElements = GetDiagonalElement(diagonalIndex);
                foreach (int product in diagonalElements)
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


        static void Main(string[] args)
        {
            SolveSmart();
            Console.ReadLine();
        }
    }
}
