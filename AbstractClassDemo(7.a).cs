// Simple c# program to demonstrate Abstract Class
using System;

namespace LabReport_Csit_SijanKarki
{
     class AbstractClassDemo
    {
      public abstract class Calculator
        {
            public abstract void Sum(int a,int b);
            public abstract void diff(int a,int b);
            public void DisplayInfo()
            {
                Console.WriteLine("This is the abstract base class Calculator");
            }
        }
        abstract class SimpleCalculator :Calculator
        {
            public override void Sum(int a, int b)
            {
                Console.WriteLine("The sum of {0} and {1} = {2}",a,b,(a+b));
            }
        }
         class ScientificCalculator : Calculator
        {
            public override void Sum(int a, int b)
            {
                Console.WriteLine("The sum of {0} and {1} = {2}", a, b, (a + b));
            }
            public override void diff(int a, int b)
            {
                Console.WriteLine("The difference of {0} and {1} = {2}", a, b, (a - b));
            }
        }

        static void Main(string[] args)
        {
            Calculator calculator = new ScientificCalculator();
            calculator.Sum(1267, 278);
            calculator.diff (134, 67);
        }

    }
}
