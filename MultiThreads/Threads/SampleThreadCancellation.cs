using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreads.Threads
{
    internal class SampleThreadCancellation
    {
        public static void InitThreadCancel() 
        {
            Thread.CurrentThread.Name = "Main";
            Console.WriteLine("Thread : " +Thread.CurrentThread.Name);

            //declare object cancel
            CancellationTokenSource cancellationTokenSource= new CancellationTokenSource();
            Thread thread = new Thread(SampleCancel.Method);
            thread.Name = "ThreadA";
            Console.WriteLine($"run ThreadA shortly ...");
            thread.Start(cancellationTokenSource.Token);
            Thread.Sleep(1000);

            Console.WriteLine("Cancellation is request ...");
            cancellationTokenSource.Cancel();
            Thread.Sleep(1000);
            cancellationTokenSource.Dispose();
            Console.WriteLine($"End of current thread : {Thread.CurrentThread.Name} end");

        }

    }

    internal class SampleCancel
    {
        public static void Method(object? token) 
        { 
            CancellationToken cancellationToken = (CancellationToken)token;
            for (int i = 0; i < 100000; i++)
            {
                Console.Write($"{i}, ");
                if (cancellationToken.IsCancellationRequested)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} has been execute ExecuteMethod3.");
                    Console.WriteLine($" iteration {i+1}, the cancellation has been requested. ");
                    //cleanup operation
                    break;
                }
            }
            // the SpinWait is used in order to thread been waiting
            // dalam waktu tertentu  yang di define di iteration params
            Thread.SpinWait(500000);
        }
    }
}
