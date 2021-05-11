using System;
using System.Collections.Generic;

namespace AirlineSeats
{
    class Program
    {
        public struct Seat{
            string seatNumber;
            SeatPosition seatPosition;
            public bool isAvailable {get;}

            public Seat(string seatNumber, SeatPosition seatPosition, bool isAvailable){
                this.seatNumber = seatNumber;
                this.seatPosition = seatPosition;
                this.isAvailable = isAvailable;
            }

            public string getSeat() {
                return this.seatNumber + " - " + this.seatPosition.ToString();
            }
            
        }

        public enum SeatPosition {
            Aisle,
            Window,
            Middle,
        }
        
        public class Plane {
            string TailNumber;
            string FlightNumber;
            
            List<Seat> Seats = new List<Seat>();

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

            public void printAvailable() {
                foreach (var seat in Seats) {
                    if (seat.isAvailable) {
                        Console.WriteLine(seat.getSeat());
                    }  
                }

            }

        }

        static void Main(string[] args)
        {
            var plane = new Plane("1", "2");

            plane.printAvailable();
        }
    }
}
