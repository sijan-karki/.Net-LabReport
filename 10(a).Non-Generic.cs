using System;
using System.Collections;
using System.Collections.Generic;
namespace LabReport_Csit_SijanKarki
{
    internal class NonGenericCOllection
    {
        static void Main(string[] args)
        {
            ArrayList al= new ArrayList();
            al.Add(1);
            al.Add(2.3);
            al.Add("sijan");
            al.Add('A');
            al.Add("Ram");
            Console.WriteLine("Capacity = {0}",al.Capacity);
            Console.WriteLine("Count = {0}",al.Count);
            Console.WriteLine("The elements in non generic collection are ::");
            foreach(object i in al) Console.Write(i+" ");
            Console.WriteLine("\n Lab NO :10'a'");
            Console.WriteLine(" Name : Sijan Karki");
            Console.WriteLine(" Roll No:28");
        }
    }
}
