// Simple c# program to demonsrate concept of LINQ
using System;
using System.Linq;

namespace LabReport_Csit_SijanKarki
{
    internal class LinqDemo
    {
        static void Main(string[] args)
        {
            string[] names = { "Sijan", "Sadhana", "Lal", "Nishan", "Sanjaya", "tammana", "Gaurav" };
            var result= from src in names where src.StartsWith("S") select src;
            Console.WriteLine("The names starting with S are ::");
            foreach(var name in result)
            {
                Console.WriteLine(name+" ");
            }

            var result1 = from src in names where src.Length <=3 select src;
            Console.WriteLine("\nThe names with length less than or equals to 3 length are ::");
            foreach (var name in result1) {
             Console.WriteLine(name+" ");
            }

            var result2 = from src in names where src.Contains("a") select src;
            Console.WriteLine("\nThe names containing a are ::");
            foreach (var name in result2)
            {
                Console.WriteLine(name + " ");
            }
        }

    }
}
