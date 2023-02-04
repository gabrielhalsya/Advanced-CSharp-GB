using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreads
{
    internal class SampleThread
    {
        public static void CreateBasicThread()
        {
            // 1. set main thread name to 'main'
            Thread.CurrentThread.Name = "Main";
            Console.WriteLine($"Thread : "+Thread.CurrentThread.Name);
            
            // 2. create child thread1
            Thread threadOne = new Thread(Method1);
            threadOne.Name= "thread-One";

            // 3. create child thread2
            Thread threadTwo = new Thread(Method2);
            threadTwo.Name = "thread-Two";

            // 4. start running thread1
            Console.WriteLine("Running thread-one ...");
            threadOne.Start();

            // 5. slow down thread using method sleep
            Thread.Sleep(5);

            // 6. start running thread2
            Console.WriteLine("Running thread-two ...");
            threadTwo.Start();

            //call method join
            //waiting thread one to finish
            threadOne.Join();

            //waiting thread two to finish
            threadTwo.Join();

            // 7. display end current thread
            Console.WriteLine($"end of current thread : {Thread.CurrentThread.Name} end.");
        }

        public static void CreateThreadParam()
        {
            Thread threadThree = new Thread(Method3);
            threadThree.Name = "Thread-Three";
            Console.WriteLine("Run Thread-Three ...");
            threadThree.Start(15);//sending parameter method 3 from this
            threadThree.Join();
        }

        public static void CreateThreadBeckground(bool status)
        {
            //8. foreground background thread
            Thread childthread = new Thread(
                () =>
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"Thread {Thread.CurrentThread.Name} print : {i}");
                        Thread.Sleep(500);
                    }
                    Console.WriteLine($"Thread {Thread.CurrentThread.Name} is about to finish");
                }
            );
            childthread.Name = "thread 5(background)";
            childthread.Start();
            childthread.IsBackground=status;
        }

        public static void CreateThreadLambda() 
        {
            //using lambda
            int result = 0;
            Thread threadFour = new Thread(
                (n)=>
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} is executing now");
                    try
                    {
                        int temp = Convert.ToInt32(n);
                        result = temp + 10;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Exepction : {e}");
                    }
                }
                );
            threadFour.Name = "Thread-4";
            threadFour.Start(15);
            threadFour.Join();
            Console.WriteLine($"Result {result}");
        }

        public static void Method1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} from Method1 print {i}");
            }
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
