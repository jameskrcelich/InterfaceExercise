using System;

namespace InterfaceExercise;

public class Suv : ICompany, IVehicle
{
    public Suv( string year, string make, string model, int seatCount, int milesToEmpty, 
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
    
    public string EnergyType {get; set;}
    public string Year {get; set;}
    public string Model {get; set;}
    public string Make {get; set;}
    public int MilesToEmpty {get; set;}
    public int SeatCount {get; set;}
    public string YearEstablished {get; set;}
    public string Slogan {get; set;}

    public void Drive()
    {
        Console.WriteLine("Drive");
    }

    public void Reverse()
    {
        Console.WriteLine("Reverse");
    }

    public void Park()
    {
        Console.WriteLine("Park");
    }
    
    public void DisplayDetails()
    {
        Console.WriteLine($"{Year} {Make} {Model} {EnergyType}");
        Console.WriteLine($"{GetType().Name} has driven 75 miles");
        Console.WriteLine($"Distance to empty = {MilesToEmpty-75}");
    }

    public void SetEnergyType()
    {
        throw new System.NotImplementedException();
    }
}