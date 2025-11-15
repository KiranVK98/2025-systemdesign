namespace ParkingLot.Models
{
    public class Ticket
    {
        public int TicketNumber {get;set;}
        public Vehicle Vehicle {get;set;}

        public int LeveLNumber {get;set;}
        public DateTime EnterTime;

        public Ticket(Vehicle vehicle, int levelNumber, DateTime enterTime, int ticketNumber)
        {
            {
                this.Vehicle = vehicle;
                this.LeveLNumber = levelNumber;
                this.EnterTime = enterTime;
                this.TicketNumber = ticketNumber;
            }
        }
    }
}