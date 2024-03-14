using System;

namespace LabReport_Csit_SijanKarki
{ 
// Creating a custom attribute MyAttribute
[AttributeUsage(AttributeTargets.All)]
    public class MyAttribute : Attribute
    {
        // Fields to store attribute data
        private string name;
        private string action;

        // Constructor to initialize attribute data
        public MyAttribute(string name, string action)
        {
            this.name = name;
            this.action = action;
        }

        // Properties to retrieve attribute data
        public string Name
        {
            get { return name; }
        }

        public string Action
        {
            get { return action; }
        }
    }

    // A class representing a Student
    class Student
    {
        // Private fields of the Student class
        private int rollNo;
        private string stuName;
        private double marks;

        // Method to set student details
        [MyAttribute("Modifier", "Assigns the Student Details")]
        public void setDetails(int r, string sn, double m)
        {
            rollNo = r;
            stuName = sn;
            marks = m;
        }

        // Methods to retrieve specific student details
        [MyAttribute("Accessor", "Returns Value of rollNo")]
        public int getRollNo()
        {
            return rollNo;
        }

        [MyAttribute("Accessor", "Returns Value of stuName")]
        public string getStuName()
        {
            return stuName;
        }

        [MyAttribute("Accessor", "Returns Value of marks")]
        public double getMarks()
        {
            return marks;
        }
    }

    class TestAttributes
    {
        // Main Method
        static void Main(string[] args)
        {
            // Creating an instance of Student class
            Student s = new Student();

            // Setting details for the student
            s.setDetails(18, "Rajan Karki", 83.5);

            // Printing student details
            Console.WriteLine("Student Details");
            Console.WriteLine("Roll Number : " + s.getRollNo());
            Console.WriteLine("Name : " + s.getStuName());
            Console.WriteLine("Marks : " + s.getMarks());
            Console.WriteLine("\n Lab NO: 16'b'");
            Console.WriteLine(" Name: Sijan Karki");
            Console.WriteLine(" Roll No: 28");
        }
    }

}
