using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    internal class SampleLambda
    {
        public static bool IsEvenNoLambda(int number)
        {
            return number %2 == 0;
        }
        
        //using lambda
        public static bool IsEvenLambda(int number) => number % 2 == 1;

        public static int Count(int[] inputArray, Func<int, bool> func)
        {
            int count = 0;
            foreach (var input in inputArray)
            {
                if(func(input)) count++;
            }
            return count;
        }
    }
}
