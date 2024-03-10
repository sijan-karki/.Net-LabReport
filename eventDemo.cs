// Simple c# program to demonstrate the concept of event using delegate
using System;
using System.Collections.Generic;

namespace LabReport_Csit_SijanKarki
{
    public delegate void notifyFlightStatus();
    public class Aeroplane
    {
       public event notifyFlightStatus ReachedDestination;
       public void StartAeroplane()
        {
            Console.WriteLine("The Flight is Running on the RunWay to Fly");
            Console.WriteLine("The flight is Flying above 2000 meters");
            OnReachedDestination();
        }
        protected virtual void OnReachedDestination()
        {
            ReachedDestination?.Invoke();
        }
        static void Main(string[] args)
        {
           Aeroplane yeti345= new Aeroplane();
            yeti345.ReachedDestination += yeti_ReachedDestination;
            yeti345.StartAeroplane();
        }

       public static void yeti_ReachedDestination()
        {
            Console.WriteLine("Aeroplane is landed Sucessfully.");
        } 
    }
    
}
