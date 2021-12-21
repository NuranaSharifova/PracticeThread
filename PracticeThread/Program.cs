using System;
using System.Threading;
namespace PracticeThread
{
    class Program
    {

        static void Main(string[] args)
        {
            //ThreadStart start = new ThreadStart(Task1);
            //Thread thread = new Thread(start);
            //thread.Start();

            //ThreadStart start2 = new ThreadStart(Task2);
            //Thread thread2 = new Thread(start2);
            //thread2.Start();



            ThreadStart start2 = new ThreadStart(Task3);
            Thread thread2 = new Thread(start2);
            thread2.Start();
        }
        static void Task1()
        {

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i.ToString());
            }
        }
        static void Task2() {
            Console.WriteLine("Enter the beginning of the list");
            int begin =Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end of the list");
            int end = Int32.Parse(Console.ReadLine());
            for (int i = begin; i < end; i++)
            {
                Console.WriteLine(i.ToString());
            }
        }
        static void Task3()
        {
            Console.WriteLine("Enter the beginning of the list");
            int begin = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end of the list");
            int end = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of threads");
            int count = Int32.Parse(Console.ReadLine());
           
            int rest = (end - begin) / count;

            for (int i = 0; i < count; i++)
            {

                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine(i.ToString());
                }
            }
           
        }

    }
}
