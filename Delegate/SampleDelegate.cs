using System;                                    
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class SampleDelegate
    {
        public static int SUm(int a, int b)
        { return a + b; }
        public static int Difference(int a, int b)
        { return a - b; }

        public static void Show1(string name, int age) => Console.WriteLine($"Show1 {name}, {age} called");
        public static void Show2(string name, int age) => Console.WriteLine($"Show2 {name}, {age} called");
        public static void Show3(string name, int age) => Console.WriteLine($"Show3 {name}, {age} called");
        public static bool isGreaterThan20(int number){ return number > 20;} 
        
    }
    //delegate is reference type, call using  new operator
    public delegate int Calculate(int a, int b);
}
