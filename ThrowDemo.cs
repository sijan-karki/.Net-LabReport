// Simple c# program to illustrate the concept of throw keyboard in exceptational handeling
using System;
using System.Collections.Generic;

namespace LabReport_Csit_SijanKarki
{
    internal class ThrowDemo
    {
        class student
        {
           public void marks(int marks)
            {
                if (marks<= 0) {
                    throw (new ArithmeticException("The Obtatined marks cannot be zero or less than Zero"));
                }
                else 
                {
                    Console.WriteLine("The Obtained marks of student is ::" + marks);
                }
            }
        }
        static void Main(string[] args)
        {
            student s = new student();
            try
            {
                s.marks(60);
                s.marks(-9);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Exceptation occurs :: "+e.Message);
            }
            finally { Console.WriteLine("We are out of exceptation"); }
        }
    }
}
