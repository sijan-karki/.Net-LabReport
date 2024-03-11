using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LabReport_Csit_SijanKarki
{
    public class Calculator
    {
        [Obsolete("Use Addnumber(List<int> numbers) method")]
        public static int Addnumber(int a,int b)
        {
            return a + b;
        }
        public static int Addnumber(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
    internal class BuildInAttribute
    {
        static void Main(string[] args)
        {
            int c= Calculator.Addnumber(11, 22);
            Console.WriteLine("The sum of two number is :"+c);
            int b = Calculator.Addnumber(new List<int> { 11, 23, 45, 67 });
            Console.WriteLine("The sum of numbers of list : "+b);
            Console.WriteLine("\n Lab NO :16'a'");
            Console.WriteLine(" Name : Sijan Karki");
            Console.WriteLine(" Roll No:28");
        }
       
    }
}
