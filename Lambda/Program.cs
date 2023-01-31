using System;
namespace Lambda
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lambda Implementation");
            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //calling isevenlambda in another class as func parameter
            //but func parameter must be 1 int param and return bool
            //cause Count(int[] inp,func<int,bool> func)
            int totalEven = SampleLambda.Count(list, SampleLambda.IsEvenLambda);
            Console.WriteLine($"total even : {totalEven}");

            //using lambda inline if one statement
            int totalEven2 = SampleLambda.Count(list,x=>x%2==0);
            Console.WriteLine($"total even2 : {totalEven2}");

            //or using lambda with {} if there is more than one statement
            int totalEven3 = SampleLambda.Count(list, x =>
            {
                Console.WriteLine(x);
                return x%2==0;
            });

            
        }
    }
}