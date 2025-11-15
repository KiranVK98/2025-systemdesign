using ParkingLot.DTO;
using ParkingLot.Models;

namespace ParkingLot.Interfaces
{
    public interface IParkingService
    {
        PageResponse<Ticket> ParkVehicle(Vehicle vehicle);

        PageResponse<string> RemoveVehicle(Ticket ticket, DateTime exitTime);
    }
}