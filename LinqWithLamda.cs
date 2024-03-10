// Simple c# program to demonstrate the concept of lemda expression with LINQ
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
namespace LabReport_Csit_SijanKarki
{
    internal class LinqWithLamda
    {
        static void Main(string[] args)
        {
            string[] names = { "Sijan", "Sadhana", "Lal", "Nishan", "Sanjaya", "tammana", "Gaurav" };
            var result = names.Where(name=>name.StartsWith("S"));
            Console.WriteLine("The names starting with S are ::");
            foreach (var name in result)
            {
                Console.WriteLine(name + " ");
            }

            var result1 = names .Where(name=>name.Length<=3);
            Console.WriteLine("\nThe names with length less than or equals to 3 length are ::");
            foreach (var name in result1)
            {
                Console.WriteLine(name + " ");
            }

            var result2 = names.Where(name=>name.Contains("a"));
            Console.WriteLine("\nThe names containing a are ::");
            foreach (var name in result2)
            {
                Console.WriteLine(name + " ");
            }
        }
    }
}
