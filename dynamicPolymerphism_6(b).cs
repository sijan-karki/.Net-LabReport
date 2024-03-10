using System;

namespace LabReport_Csit_SijanKarki
{
    class DynamicPolymerphismDemo
    {
        class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Showing general animal sound");
            }
        }

        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Vou, Vou!");
            }
        }

        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meow, meow!");
            }
        }

        static void Main(string[] args)
        {
            Animal allanimal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            allanimal.MakeSound(); // Calls the base class method
            dog.MakeSound(); // Calls the overridden method in Dog class
            cat.MakeSound(); // Calls the overridden method in Cat class
        }
    }
}
