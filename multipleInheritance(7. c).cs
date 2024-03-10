// Simple c# sharp program to demonstrate the multiple inheritance in interface
using System;

namespace LabReport_Csit_SijanKarki
{
    interface IWorker
    {
        void Work();
    }

    interface IEater
    {
        void Eat();
    }

   public class WorkingPerson : IWorker, IEater
    {
        public void Work()
        {
            Console.WriteLine("Working hard to achieve goals.");
        }

        public void Eat()
        {
            Console.WriteLine("Eating a delicious meal.");
        }
    }
    internal class multipleInheritanceExample
    {
        static void Main(string[] args) { 
         WorkingPerson sijan = new WorkingPerson();
            sijan.Eat();
            sijan.Work();
        }
    }
}
