using System;

namespace LabReport_Csit_SijanKarki
{
    class Building
    {
        public string buildingTime=" 34 hours";
        private string buildingName="RS Complex";
        private string builderCompany="Pathan Construction";
         
        public Building() {
            Console.WriteLine("This is the base class Constuctor\n");
        }
        public void displayInfo()
        {
            Console.WriteLine($"The building name is {buildingName} and is constructed by {builderCompany} in time{buildingTime}\n ");
        }
    }
    class BuildingBridge : Building
    {
        private string bridgeName="Hanging Bridge";
        public BuildingBridge() : base() { }// base() this will call the constructor Building() which is base class constructor
       public void displayDetails()
        {
            base.displayInfo();// this is used to call base class method
            Console.WriteLine($"The name of bridge is {bridgeName} and the buiding time is {base.buildingTime}\n");
            // in the above line we have use base.building time to access base class fields
        }
    }
    internal class BaseKeyword
    {
        static void Main(string[] args)
        {
            BuildingBridge b1 = new BuildingBridge();
            b1.displayDetails();
            Building house = new Building();
            house.displayInfo();
        }
    }
}
