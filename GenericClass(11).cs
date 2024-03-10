using System;
using System.Collections.Generic;

namespace LabReport_Csit_SijanKarki
{
    class GenericClassDemo
    {

        class Calculator<T>
        {
            T value;

            public Calculator(T value)
            {
                this.value = value;
                Console.WriteLine("This is your value :: "+value);
            }

            public T AreaofRectangle<T1, T2>(T1 length, T2 breadth)
            {
                dynamic a = length;
                dynamic b = breadth;
                return a * b;
            }
        }

        static void Main(string[] args)
        {
            Calculator<int> c1 = new Calculator<int>(42);
            int areaInt = c1.AreaofRectangle(24, 64);
            Console.WriteLine($"Area of rectangle (int):{areaInt}");

            Calculator<double> c2 = new Calculator<double>(23.56);
            double areaDouble = c2.AreaofRectangle(8.98, 4.878);
            Console.WriteLine($"Area of rectangle (double):{areaDouble}");
        }
    }
}
