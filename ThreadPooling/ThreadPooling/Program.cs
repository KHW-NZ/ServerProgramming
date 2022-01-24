using System;
using System.Threading;

namespace ThreadPooling
{
    internal class Program
    {
        static void MainThread(object state)
        {
            for(int i=0; i<5; i++)
            {
                Console.WriteLine("Hello Thread");
            }
        }

        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(MainThread);

            while (true)
            {

            }
        }
    }
}
