// simple c# program to illustrate the concept of Try catch and finally while exceptation handeling
using System;

namespace LabReport_Csit_SijanKarki
{
    class ExceptationHandeling
    {
       static void Main(string[] args)
        {
            int[] number = { 23, 45,0, 101, 21, 56, 12 };
            Console.WriteLine("Enter the 'a' index number ::  ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 'b' index number ::  ");
            int b = Convert.ToInt32(Console.ReadLine());
            try
            {
                int c = (a + b) / number[b];
                Console.WriteLine("The numer at index {0} is {1}", c, number[c]);
                Console.WriteLine("The number at index {0} is {1}", b, number[b]);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Exceptation occured ::"+ex.Message);
            }
            catch (IndexOutOfRangeException ex) {
                Console.WriteLine("Exceptation occured ::" + ex.Message);
            }
            finally { Console.WriteLine("Finally outof excepation"); }
        }
    }
}
