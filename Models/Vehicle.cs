using ParkingLot.Enums;

namespace ParkingLot.Models
{
    public class Vehicle
    {
        public VehicleType VehicleType;

        public string VehicleNumber {get;set;}

        public Vehicle(VehicleType vehicleType, string vehicleNumber)
        {
            this.VehicleType = vehicleType;
            this.VehicleNumber = vehicleNumber;
        }
    }
}