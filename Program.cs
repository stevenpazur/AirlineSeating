using System;

namespace AirlineSeats
{
    class Program
    {
        public struct Seat{
            string seatNumber;
            SeatPosition seatPosition;
            bool isAvailable;

            public Seat(string seatNumber, SeatPosition seatPosition, bool isAvailable){
                seatNumber = seatNumber;
                seatPosition = seatPosition;
                isAvailable = isAvailable;
            }
            
        }

        enum SeatPosition {
            Aisle,
            Window,
            Middle,
        }
        
        class Plane {
            string TailNumber;
            string FlightNumber;
            Seat Seats;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
