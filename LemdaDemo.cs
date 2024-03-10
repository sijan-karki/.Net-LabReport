// c# program to demostrate the concept of lemda expression 
using System;
using System.Reflection.Metadata.Ecma335;
namespace LabReport_Csit_SijanKarki
{
    public delegate void Greetingdelegate(string name);
    public delegate int MathOperation(int num1,int num2);
    internal class LemdaDemo
    {
        static void Main(string[] args)
        {
            LemdaDemo L1=new LemdaDemo();
            Greetingdelegate hd = (name) =>
            {
                Console.WriteLine("Hello Good Afternoon {0}",name);
            };
            MathOperation M1 = (num1, num2) => num1 * num2;
            hd("Sijan Karki");
           long c= M1(45, 23);
            Console.WriteLine("The multiply of 45 and 23 is {0}",c);
        }
    }
}
