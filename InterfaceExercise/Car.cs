using System;

namespace InterfaceExercise;

public class Car : ICompany, IVehicle
{
        public Car( string year, string make, string model, int seatCount, int milesToEmpty, 
                string energyType, string yearEstablished, string slogan )
        {
                Year  = year;
                Make  = make;
                Model = model;
                SeatCount = seatCount;
                MilesToEmpty = milesToEmpty;
                EnergyType = energyType;
                YearEstablished = yearEstablished; 
                Slogan = slogan;
        }

        public string EnergyType { get; set; }
        public string Year { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int SeatCount { get; set; }
        public string YearEstablished { get; set; }
        public string Slogan { get; set; }
        public int MilesToEmpty { get; set; }
        public bool HasChangedGears { get; set; }

        public void DisplayDetails()
        {
                Console.WriteLine($"{Year} {Make} {Model} {EnergyType}");
                Console.WriteLine($"{GetType().Name} has driven 50 miles");
                Console.WriteLine($"Distance to empty = {MilesToEmpty-50}");
        }

        public void Drive()
        {
                throw new NotImplementedException("The MyMethod method is not yet implemented.");
        }

        public void Reverse()
        {
                if (HasChangedGears == true) {
                        
                        Console.WriteLine($"{GetType().Name} now reversing");
                        HasChangedGears = false;
                }
                else
                {
                        Console.WriteLine("Can't reverse until we change gears");
                }
        }

        public void Park()
        {
                if (HasChangedGears == true) {
                        
                        Console.WriteLine($"{GetType().Name} now in park");
                        HasChangedGears = false;
                }
                else
                {
                        Console.WriteLine("Can't park until we change gears");
                }
                
        }

        /*public bool ChangeGears(bool isChanged)
        {
                HasChangedGears = isChanged;
        } */
}