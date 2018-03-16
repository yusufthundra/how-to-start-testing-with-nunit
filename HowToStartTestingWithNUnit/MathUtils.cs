using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToStartTestingWithNUnit
{
    public static class MathUtils
    {
        // First version
        //public static int CalculateFibonacciNumber(int numberIndex)
        //{
        //    if (numberIndex == 1 || numberIndex == 2)
        //    {
        //        return 1;
        //    }

        //    return CalculateFibonacciNumber(numberIndex - 1) + CalculateFibonacciNumber(numberIndex - 2);
        //}

        // Second version
        //public static int CalculateFibonacciNumber(int numberIndex)
        //{
        //    if (numberIndex == 0 || numberIndex == 1)
        //    {
        //        return numberIndex;
        //    }
            
        //    return CalculateFibonacciNumber(numberIndex - 1) + CalculateFibonacciNumber(numberIndex - 2);
        //}

        public static int CalculateFibonacciNumber(int numberIndex)
        {
            if(numberIndex < 0)
            {
                throw new ArgumentException("Index cannot be negative.");
            }

            if (numberIndex == 0 || numberIndex == 1)
            {
                return numberIndex;
            }

            return CalculateFibonacciNumber(numberIndex - 1) + CalculateFibonacciNumber(numberIndex - 2);
        }

        public static List<int> GetFibonacciSequence(int maxNumberIndexInclusive)
        {
            List<int> result = new List<int>();

            for(int i = 0; i <= maxNumberIndexInclusive; ++i)
            {
                result.Add(CalculateFibonacciNumber(i));
            }

            return result;
        }
    }
}
