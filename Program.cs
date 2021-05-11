using System;

namespace AirlineSeats
{
    class Program
    {
        public struct Seat{
            string seatNumber;
            SeatPosition seatPosition;
            bool isAvailable;
        }

        enum SeatPosition {
            Aisle,
            Window,
            Middle,
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
