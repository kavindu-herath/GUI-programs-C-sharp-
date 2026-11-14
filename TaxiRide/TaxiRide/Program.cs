using System;

namespace TaxiRide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaxiRide ride = new TaxiRide();
            ride.setCustomer("John Doe"); //setter
            ride.Vehicle = "CCC-0001"; //property
            ride.Start = "Kandy";
            ride.Destination = "Kegalle";
            ride.calFee(30.0);
            Console.WriteLine($"Taxi ride fee: {ride.Fee}");
            Console.ReadKey();
        }
    }
}
