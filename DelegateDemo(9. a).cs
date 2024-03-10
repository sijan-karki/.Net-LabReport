// Simple c# program to demonstrate the concept of delegate
using System;
using System.Security.Cryptography.X509Certificates;
namespace LabReport_Csit_SijanKarki
{
    public delegate void GreetingDelegat(string name);
     class DelegateDemo
    {
        public void Greeting(string name)
        {
            Console.WriteLine("Namaste "+name);
        }

        static void Main(string[] args) { 
          DelegateDemo d1 = new DelegateDemo();
          GreetingDelegat gd=new GreetingDelegat(d1.Greeting);
          gd("Sijan");
          gd("Mitchel Santenr");
        }
    }
}
