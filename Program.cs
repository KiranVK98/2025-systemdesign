// See https://aka.ms/new-console-template for more information
using ParkingLot.DTO;
using ParkingLot.Models;
using ParkingLot.Services;

Console.WriteLine("Hello, World!");
//cars, motorcycle,truck
//should have multiple levels with every level certain number of spots

//Entities in models - 
    // 1. Parking level

    List<ParkingLevel> levels = new List<ParkingLevel>()
    {
        new ParkingLevel(1,50),
        new ParkingLevel(2,50)
    };

    var service = new ParkingService(levels);

    Vehicle car = new Vehicle(ParkingLot.Enums.VehicleType.Car, "TGW3876");

    var response = service.ParkVehicle(car);

    Ticket ticket = null;

    if(response.Error == null)
    {
        ticket = response.Response;
        Console.WriteLine($"Ticket number {ticket.TicketNumber} for car{car.VehicleNumber} parked in level {ticket.LeveLNumber}");
    }

    var remove = service.RemoveVehicle(ticket, DateTime.Now);

    Console.WriteLine(remove.Response);
