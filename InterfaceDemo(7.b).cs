// Simple c# program to demonstrate the concept of Interface
using System;
namespace LabReport_Csit_SijanKarki
{
    public interface college
    {
      void Affileted();
        void FacultyMember();
    }
    public abstract class KanitipurCOllege:college { 
      public void Affileted()
        {
            Console.WriteLine("Kantipur College is affileted by Pokhara University");
        }
      public abstract void FacultyMember();
    }
    public class NCIT : college
    {
        public void Affileted()
        {
            Console.WriteLine("NCIT is affileted by Tribhuban University");
        }
        public  void FacultyMember()
        {
            Console.WriteLine("NCIT consists IT and Management faculty members ");
        }
    }

    class InterfaceDemo
    {
       static void Main(string[] args)
        {
            college c1;
            c1 = new NCIT();
            c1.Affileted();
            c1.FacultyMember();
        }

    }
}
