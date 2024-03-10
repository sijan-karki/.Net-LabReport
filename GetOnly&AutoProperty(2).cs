using System;

namespace LabReport_Csit_SijanKarki
{
    class College
    {
        private String clzName="Nagarjuna ";
        private int noOfDepartment=6;

        // Auto property
        public String location
        {
            get; set;
        }
        // Read Only Property
        public String clzname
        {
            get { return clzName; }
        }
        
        public int noOfdepartment
        {
            get { return noOfDepartment; }
        }
    }
    internal class GetOnly_AutoProperty
    {
        static void Main(string[] args)
        {
            College c1= new College();
            Console.WriteLine(c1.clzname);
            Console.WriteLine(c1.noOfdepartment);

            c1.location = "Lalitpur";// it set the value of location as lalitpur
            Console.WriteLine(c1.location); // it is used to get the value of location
        }
    }
}
