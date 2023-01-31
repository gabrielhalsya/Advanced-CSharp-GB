using System;
namespace Delegate
{
    internal class program
    {
        public static void Main(string[] args)
        {
            //action,func,predicate is pre-define generic delegate type
            //action is used to call method void
            //func is used to call method return
            //Action<param1 ..param16>
            //Func<param1, ... param16, out return>

            //predicate used to evaluate something, return boolean
            Predicate<int> predicate = SampleDelegate.isGreaterThan20;
            Console.WriteLine($"25 is greater than 20? {predicate(25)}");
            Console.WriteLine($"15 is greater than 20? {predicate(15)}");

            //funciton implementation
            Func<int, int, int> func = SampleDelegate.SUm;
            Console.WriteLine($"func : {func(10, 10)}");
            
            //try add another method
            func += SampleDelegate.Difference;
            Console.WriteLine($"func : {func(10,10)}"); //out func : 0, cause will run last assigned method

            //action implementation
            Action<String,int> action = SampleDelegate.Show1;
            //action("Gabi");

            //multi chain delegate
            action += SampleDelegate.Show2;
            action += SampleDelegate.Show3;
            action("Gabi",23);

            //call without delegate
            Console.WriteLine(SampleDelegate.SUm(8,4));
            Console.WriteLine(SampleDelegate.Difference(8,4));

            //call instance delegate types,
            //then assign with method sum& difference
            Calculate calculate = SampleDelegate.SUm;
            Console.WriteLine($"Call instance delegate type a+b : {calculate.Invoke(8, 4)}");
            calculate = SampleDelegate.Difference;
            Console.WriteLine($"Call instance delegate type a+b : {calculate.Invoke(8, 4)}");

            //call delegate types with lamda
            int PlusOne(int a,int b) => a + b;
            Console.WriteLine(new Calculate(PlusOne).Invoke(8,4));


        }
    }
}