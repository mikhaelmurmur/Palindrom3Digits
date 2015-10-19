using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask1Intetics
{
    class Program
    {

        static List<int> GetDiagonalElement(int diagonalNumber)
        {
            if (diagonalNumber == 0) return new List<int>() { 999 * 999 };
            List<int> diagonalElements = new List<int>();
            int firstNumber, secondNumber;
            if (diagonalNumber % 2 == 0)
            {
                firstNumber = secondNumber = 999 - diagonalNumber / 2;
            }
            else
            {
                firstNumber = 999 - diagonalNumber / 2;
                secondNumber = 999 - diagonalNumber / 2 + 1;
            }

            while (firstNumber != 1000)
            {
                diagonalElements.Add(firstNumber * secondNumber);
                firstNumber++;
                secondNumber--;
            }
            return diagonalElements;
        }

        static bool IsPolindrom(int numberToCheck)
        {
            return numberToCheck.ToString().Equals(numberToCheck.ToString().Reverse());
        }


        static void Main(string[] args)
        {
            const int DIAGONAL_NUMBER = 999;
            int currentNumber = 0;
            for (int diagonalIndex = 0; diagonalIndex < DIAGONAL_NUMBER; diagonalIndex++)
            {
                
            }
        }
    }
}
