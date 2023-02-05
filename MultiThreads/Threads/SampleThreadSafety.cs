using System;                     
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreads.Threads
{
    internal class SampleThreadSafety
    {
        public static void InitThreadSafety()
        {
            ShareData shareData = new ShareData();

            Thread thread = new Thread(shareData.Increment);
            thread.Start();

            Thread thread1= new Thread(shareData.Increment);
            thread1.Start();
            //shareData.Increment();
            thread.Join();
            thread1.Join();

            Console.WriteLine($"ShareData Counter {shareData.Counter}");   //ShareData Counter 1 or 2

        }

        public static void InitThreadSafetyWithLock()
        {
            ShareDataLock shareData = new ShareDataLock();
            Thread thread= new Thread(shareData.Increment);
            thread.Start();
            Thread thread1= new Thread(shareData.Increment);
            thread1.Start();

            thread.Join();
            thread1.Join();
            Console.WriteLine($"ShareDataLock Counter : {shareData.Counter}");     // Sharedatalock Counter will be always 2 cause ShareDataLock use locking

        }
    }
    internal class ShareData
    {
        public int Counter { get; set; }
        public void Increment() => Counter++;
    }

    internal class ShareDataLock
    {
        // 1. Create readonly object
        private readonly object _counterLook = new object();
        private int _counter;

        public int Counter 
        {
            get
            {
                lock (_counterLook) //2 .then when youre tryin to return property variable, lock object first
                {
                    return _counter;
                }
            } 
        }

        public void Increment()
        {
            lock (_counterLook)   // .... this too
            {
                _counter++;
            }
        }
    }
}
