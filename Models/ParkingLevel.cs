namespace ParkingLot.Models
{
    public class ParkingLevel
    {
        //Properties
        public int LevelNumber {get;set;}
        public int ParkingSpots {get;set;}
        public List<Vehicle> Vehicles = new List<Vehicle>();

        public ParkingLevel(int levelNumber, int parkingSpots)
        {
            this.LevelNumber = levelNumber;
            this.ParkingSpots = parkingSpots;
        }
    }
}