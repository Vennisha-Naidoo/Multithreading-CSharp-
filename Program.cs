using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Question_Three
{
    class Program
    {
        //static void method declaration
        static void ThreadOne() {
            //integer variable declaration
            int tableOf10;
            //currently displaying
            Console.WriteLine("Table of Ten:");
            //for loop declaration
            for (int x = 0; x <= 10; x++)
            {
                //multiplication 
                tableOf10 = x * 10;
                //displaying multiplication of 10
                Console.WriteLine(x + " X " + 10 + " = " + tableOf10);
            }
        }

        static void Main(string[] args)
        {
            //new thread object created
            //passing method as an arguement
            Thread t1 = new Thread(ThreadOne);
            //starting the thread
            t1.Start();

            Console.WriteLine();
            Console.WriteLine();

            //currently printing the multiplication of 15
            Console.WriteLine("Table of 15:");
            //declaration of integer variable
            int tableOf15;
            //declaration of for loop
            for (int x = 0; x <= 10; x++) {
                //calculation of multiplication of 15
                tableOf15 = x * 15;
                //displaying multiplication of 15
                Console.WriteLine(x + " X " + 15 + " = " + tableOf15);
                //main thread being put to sleep for a second
                Thread.Sleep(1000);
            }

            Console.ReadLine();

        }
    }
}
