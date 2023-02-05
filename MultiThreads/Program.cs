using MultiThreads;
using MultiThreads.Threads;
using System;
namespace Multithreads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            SampleThread.CreateBasicThread();//basicmultithread 
            SampleThread.CreateThreadParam();//threadusing parameter
            SampleThread.CreateThreadLambda();
            SampleThread.CreateThreadBeckground(false);
             */

            /*
            SampleThreadSafety.InitThreadSafety();
            SampleThreadSafety.InitThreadSafetyWithLock();
             */
            
            //SampleThreadCancellation.InitThreadCancel();

            SampleThreadPool.InitThreadPool(); // run with debugging
        }
    }
}