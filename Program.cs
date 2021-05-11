using System;
using System.Collections.Generic;

namespace AirlineSeats
{
    class Program
    {
        public struct Seat {
            string SeatNumber;
            SeatPosition seatPosition;
            bool isAvailable;

            public Seat(string seatNum, SeatPosition seatPos, bool isAvail){
                this.SeatNumber = seatNum;
                this.seatPosition = seatPos;
                this.isAvailable = isAvail;
            }
        }

        class Plane {
            string TailNumber;
            string FlightNumber;
            List<Seat> Seats;

            public Plane(string tailNum, string flightNum){
                this.TailNumber = tailNum;
                this.FlightNumber = flightNum;

                string[] characterLiterals = {"a", "b", "c", "d", "e", "f"};

                for(int x = 1; x <= 10; x++){
                    for(int y = 0; y <= characterLiterals.Length; y++){
                        if(y == 0 || y == 5){
                            Seats.Add(new Seat(x.ToString() + characterLiterals[y], SeatPosition.Window, true));
                        }
                        else if(y == 1 || y == 4){
                            Seats.Add(new Seat(x.ToString() + characterLiterals[y], SeatPosition.Middle, true));
                        }
                        else if(y == 2 || y == 3){
                            Seats.Add(new Seat(x.ToString() + characterLiterals[y], SeatPosition.Aisle, false));
                        }
                    }
                }
            }
        }
        
        public enum SeatPosition {
            Aisle,
            Middle,
            Window,
        }
        
        static void Main(string[] args)
        {
            
        }
    }
}
