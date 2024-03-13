// Simple c# program to illustrate the concept of Funct delegate 

/* Func delegate is a generic delegate 
   * Func delegae is used for return type 
   * Action delegate is used for void type
  */
using System;

namespace LabReport_Csit_SijanKarki
{
     class funcDelegate
    {
        public int sumofTwoNumber(int a,int b)
        {
            return a + b;
        }
        public double sumofThreeNumber(int a,double b,int c) {
            return a + b + c;
        }
        public void Greeting(string name)
        {
            Console.WriteLine("Good Morning "+name);
        }

        static void Main(string[] args)
        {
            funcDelegate f1= new funcDelegate();
            Func<int, int, int> obj1 = f1.sumofTwoNumber;//Func delegate
            Console.WriteLine("The sum of Two number is:: "+ obj1(34, 27));

            Func<int, double, int, double> obj2 = f1.sumofThreeNumber;
            Console.WriteLine("The sum of three number is:: "+obj2(23, 56.45, 78));

            Action <string> obj3 = f1.Greeting; // Action delegate
            obj3("Sijan Karki");
        }
    }
}
