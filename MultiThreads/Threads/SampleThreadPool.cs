using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreads.Threads
{
    internal class SampleThreadPool
    {

        public static void InitThreadPool() 
        {
            Thread.CurrentThread.Name = "Main";
            Console.WriteLine($"Thread : " + Thread.CurrentThread.Name);

            //call thread pool
            ThreadPool.QueueUserWorkItem(SampleThreadPool.Method3,25);
            // the Method2 cant assign to QueueUserWorkItem
            // because the parameter sould be method with object? param e.g WaitCallback(object? state){}

            Console.WriteLine($"end of current thread : {Thread.CurrentThread.Name} end.");

        }
        public static void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} from Method2 print {i}");
            }
        }

        public static void Method3(object? number)
        {
            int upperInt = Convert.ToInt32(number); //for example set number 15
            for (int i = upperInt - 3; i < upperInt; i++)   //i = 12, 12<15,
            {
                Console.WriteLine($"The {Thread.CurrentThread.Name} from Method 3 print : {i}");
                Thread.Sleep(5);
            }
        }
    }
}
