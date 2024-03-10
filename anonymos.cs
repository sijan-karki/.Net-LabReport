// simple c# program to illustrate the concept of anonymous method
using System;
using System.Reflection.Metadata.Ecma335;

namespace LabReport_Csit_SijanKarki
{
    internal class anonymos
    {
        static void Main(string[] args)
        {
            Func<int, int, int> obj1 =(a,b) => a + b;
            Console.WriteLine("The sum of Two number is:: " + obj1(334, 27));

            Func<int, double, int, double> obj2 = (a,b,c)=>a+b+c;
            Console.WriteLine("The sum of three number is:: " + obj2(23, 56.45, 78));

            Action<string> obj3 = x=>Console.WriteLine("Good afternoon "+x); // Action delegate
            obj3("Sijan Karki");
        }
    }
}
