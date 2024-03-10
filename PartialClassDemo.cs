// program in c# to demonstrate the concept of partial class
using System;
namespace LabReport_Csit_SijanKarki
{
    public partial class mobile
    {
        public string mobileCompany;
        public string IMEIno;
        public mobile(string mobileCompany, string IMEIno)
        {
            this.mobileCompany = mobileCompany;
           this.IMEIno = IMEIno;
        }

    }
    public partial class mobile
    {
       public void display()
        {
            Console.WriteLine("The company of mobile is {0} and its IMEI number is {1}", mobileCompany, IMEIno);
        }
    }
    internal class PartialClassDemo
    {
        static void Main(string[] args)
        {
            mobile m1 = new mobile("Samsung","I23415J");
            m1.display();

        }
    }
}
