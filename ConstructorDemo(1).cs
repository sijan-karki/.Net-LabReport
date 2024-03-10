using System;

namespace LabReport_Csit_SijanKarki
{
    class Car
    {
        private String carCompany;
        private String model;
        static int carNO;
        public Car() {
            Console.WriteLine("This is default Constructor\n");
        }

        public Car(String carCompany,String model) {
           this.carCompany = carCompany;
           this.model = model;
            Console.WriteLine("The car Company name is " + carCompany + " and the car model is " + model);
            Console.WriteLine("This is  parameterized Constructor\n");
        }
        public Car(Car c)
        {
            carCompany = c.carCompany;
            model = c.model;
            Console.WriteLine("The car Company name is " + carCompany + " and the car model is " + model);
            Console.WriteLine("This is Copy Constructor\n");
        }

        static Car()
        {
            carNO = 8848;
            Console.WriteLine("The car no of car is "+carNO);
            Console.WriteLine("This is static constructor of car class\n");
        }
     /*
        private Car()
        {
            Console.WriteLine("This is private constructor");
        } 
     */

    }
    internal class ConstructorDemo
    {
        static void Main(string[] args) {

            Car c2 = new Car("Maruti Suzuki", "Suxuki530");
            Car c1=new Car();
            Car c3 = new Car(c2);
        }
    }
}
