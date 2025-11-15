namespace ParkingLot.DTO
{
    public class PageResponse<T>
    {
        public T Response {get;set;}
        public string Error {get;set;}
    }
}