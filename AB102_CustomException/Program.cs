using AB102_CustomException.Exceptions;
using AB102_CustomException.Models;

namespace AB102_CustomException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room("test room", 30, 2);
            Room room2 = new Room("test room2", 34, 1);

            Hotel hotel = new Hotel("test hotel");
            hotel.AddRoom(room1);
            hotel.AddRoom(room2);
            try
            {
                hotel.MakeReservation(null);
                hotel.MakeReservation(1);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotAvailableException ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }
    }
}