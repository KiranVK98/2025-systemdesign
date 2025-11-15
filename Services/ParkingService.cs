using ParkingLot.DTO;
using ParkingLot.Interfaces;
using ParkingLot.Models;

namespace ParkingLot.Services
{
    public class ParkingService : IParkingService
    {
        private List<ParkingLevel> Levels;

        private int TicketNumber = 0;
        public ParkingService(List<ParkingLevel> levels)
        {
            this.Levels = new List<ParkingLevel>();
            this.Levels = levels;

        }
        public PageResponse<Ticket> ParkVehicle(Vehicle vehicle)
        {

            foreach(var level in Levels)
            {
                if(level.ParkingSpots < 0)
                {
                    continue;
                }
                else
                {
                    this.TicketNumber++;
                    Ticket ticket = new Ticket(vehicle, level.LevelNumber, DateTime.Now.AddHours(-3), this.TicketNumber);
                    level.Vehicles.Add(vehicle);
                    return new PageResponse<Ticket>
                    {
                        Response = ticket,
                        Error = null
                    };
                }
            }
            return new PageResponse<Ticket>
            {
                Response = null,
                Error = "Parking Lot is full"
            };
            
        }


        public PageResponse<string> RemoveVehicle(Ticket ticket, DateTime exitTime)
        {
            int levelNumber = ticket.LeveLNumber;
            ParkingLevel level = Levels[levelNumber-1];
            TimeSpan duration = exitTime - ticket.EnterTime;
            int hours = duration.Hours;
            int price = hours * 20;
            foreach(Vehicle vehicle in level.Vehicles)
            {
                if(ticket.Vehicle.VehicleNumber == vehicle.VehicleNumber)
                {
                    level.Vehicles.Remove(vehicle);
                    this.TicketNumber--;
                    return new PageResponse<string>
                    {
                        Response = $"Vehicle {vehicle.VehicleNumber} was parked for {hours} and total price is {price}",
                        Error = null
                    };
                }
            }

            return new PageResponse<string>
            {
                Response = null,
                Error = "Car could not be found"
            };
            
        }
    }
}