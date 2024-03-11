using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabReport_Csit_SijanKarki
{
    internal class AsyncronousProgrammingDemo
    {
        public static async void Task1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 1 Starting...");
                Thread.Sleep(5000);
                Console.WriteLine("Task 1 Completed.");
            });
            Console.WriteLine("\n Lab NO :17");
            Console.WriteLine(" Name : Sijan Karki");
            Console.WriteLine(" Roll No:28");

        }
        public static async void Task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 2 Starting...");
                Thread.Sleep(4000);
                Console.WriteLine("Task 2 Completed.");
            });
        }
        public static async void Task3()
        {
           await Task.Run(() =>
            {
                Console.WriteLine("Task 3 Starting...");
                Thread.Sleep(1000);
                Console.WriteLine("Task 3 Completed.");
            });
        }
        public static async void Task4()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 4 Starting...");
                Thread.Sleep(3000);
                Console.WriteLine("Task 4 Completed.");
            });
        }
        static void  Main(string[] args)
        {
            Task1(); 
            Task2();
            Task4();
            Task3();
            Console.ReadLine(); // to hold console window
        }
    }
}
