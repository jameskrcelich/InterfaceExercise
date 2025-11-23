using System;

namespace InterfaceExercise;

public class Truck : ICompany, IVehicle
{
    public Truck(string year, string make, string model, int seatCount, int milesToEmpty, 
                    string energyType, string yearEstablished, string slogan)
    {
        Year = year;
        Make = make;
        Model = model;
        SeatCount = seatCount;
        MilesToEmpty = milesToEmpty;
        EnergyType = energyType;
        YearEstablished = yearEstablished; 
        Slogan = slogan;
        MilesToEmpty = milesToEmpty;
    }

    public string EnergyType { get; set; }
    public string Year { get; set; }
    public string Model { get; set; }
    public string Make { get; set; }
    public int SeatCount { get; set; }
    public int MilesToEmpty { get; set; }
    public string YearEstablished { get; set; }
    public string Slogan { get; set; }

    public void Drive()
    {
        throw new NotImplementedException("The MyMethod method is not yet implemented.");
    }

    public void Reverse()
    {
        Console.WriteLine("Truck reversing...");
    }

    public void Park()
    {
        Console.WriteLine("Truck in park...");
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"{Year} {Make} {Model} {EnergyType}");
        Console.WriteLine($"{GetType().Name} has driven 100 miles");
        Console.WriteLine($"Distance to empty = {MilesToEmpty-100}");
    }
}