using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabReport_Csit_SijanKarki
{
    internal class EnumDemo
    {
        enum districtName
        {
            Udayapur,
            Saptari = 901,
            Jhapa,
            Khotang,
            Makauwanpur
        }
        static void Main(string[] args)
        {
          int a=(int)districtName.Udayapur;    
          Console.WriteLine(districtName.Udayapur+" = "+a);
          Console.WriteLine(districtName.Saptari + " = " + (int)districtName.Saptari);
          Console.WriteLine(districtName.Jhapa + " = " + (int)districtName.Jhapa);
        }
    }
}
