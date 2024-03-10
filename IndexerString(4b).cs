using System;

namespace LabReport_Csit_SijanKarki
{
    class phone
    {
        private string PhoneCompany;
        private string PhoneModel;
        private int imeiNumber;

        public phone(string PhoneCompany, string PhoneModel, int imeiNumber)
        {
           this. PhoneCompany = PhoneCompany;
           this. PhoneModel = PhoneModel;
            this.imeiNumber = imeiNumber;
        }

        public object this[string index] {
            get
            {
                if (index == "Nepal")
                {
                    return PhoneCompany;
                }
                else if (index == "is")
                {
                    return PhoneModel;
                }
                else if (index == "Beutiful")
                {
                    return imeiNumber;
                }
                else
                    return "Invalid index string";
            }
            set
            {
                if(index == "Nepal")
                {
                    PhoneCompany =(string) value;
                }
                else if(index == "is")
                {
                    PhoneModel =(string) value;
                }
                else if(index == "Beutiful")
                {
                    imeiNumber=(int) value;
                }
            }
        }
    }
    internal class IndexerString
    {
        static void Main(string[] args)
        {
            phone p1= new phone("Nokia","Nokia Series 2",231244);
            Console.WriteLine($"The name of the phone is {p1["Nepal"]} ,the model is {p1["is"]}\n ");

            phone p2 = new phone(" ", " ", 234216);
            p2["Nepal"] = " Samsung";
            p2["is"] = "s23 pro";
            Console.WriteLine($"The name of the phone is {p2["Nepal"]} and the imei number is {p2["Beutiful"]}");

        }
    }
}
