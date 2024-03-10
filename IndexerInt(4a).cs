using System;

namespace LabReport_Csit_SijanKarki
{
    class Bank
    {
        private string bankName;
        private int bankCode;
        private string location;
        public Bank(string bankName, int bankCode, string location)
        {
            this.bankName = bankName;
            this.bankCode = bankCode;
            this.location = location;
        }

        public object this[int index]
        {
            get
            {
                if(index==0)
                {
                    return bankName;
                }
                else if(index==202) {
                    return bankCode;
                }
                else if (index == 203)
                {
                    return location;
                }
                else
                {
                    return "Invalid index !!!!";
                }
            }

            set
            {
                if(index==0)
                {
                    bankName = (string)value;
                }
                else if (index == 202)
                {
                    bankCode = (int)value;
                }
                else if (index == 203)
                {
                    location = (string)value;
                }
                else
                {
                    Console.WriteLine("Invalid index to set !!!!!");
                }
            }
        }
    }
    internal class IndexerInt
    {
        static void Main(string[] args)
        {
            Bank manakamana = new Bank("Manakamana",20786,"Mid Baneshwor");
            Bank nabil = new Bank(" ",25671 ," ");
            Console.WriteLine(nabil[0]);
            nabil[0] = "Nabil";
            nabil[203] = "Lalitpur";
            Console.WriteLine($"The name of bank is { nabil[0]} and it is located in {nabil[203]}\n");
            Console.WriteLine($"The name of bank is {manakamana[0]} and bank code no is {manakamana[202]}\n");
            manakamana[202] = 20653;
            Console.WriteLine($"The code no of {manakamana[0]} is {manakamana[202]}");

        }
    }
}
