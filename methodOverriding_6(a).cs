// simple c# program to demonstrate the concept of method overriding and method hiding
using System;

namespace LabReport_Csit_SijanKarki
{
    class methodOverridingDemo
    {
        class Father
        {
            public virtual void marriageType()
            {
                Console.WriteLine("I prefer Arrange marriage");
            }

            public void Greeting() // Not virtual, cannot be overridden
            {
                Console.WriteLine("Hello and Namaste eveyone. I am father");
            }
        }

        class Son : Father
        {
            public override void marriageType()
            {
                Console.WriteLine("I prefer Love marriage");
            }

            public new void Greeting() // Hides the base class Greeting()
            {
                Console.WriteLine("Good afternoon everyone from Son");
            }
        }

        static void Main(string[] args)
        {
            Father f1=new Father();
            Son s1 = new Son();
            s1.Greeting(); // Calls Son's Greeting() due to method hiding
            s1.marriageType(); // Calls Son's marriageType() due to overriding
        }
    }
}

