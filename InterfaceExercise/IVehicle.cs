namespace InterfaceExercise;

public interface IVehicle
{
    /* Create 4 members that Car, Truck, & SUV all have in common.
     * Example: public int NumberOfWheels { get; set; }
     */
    public string EnergyType {get; set;}
    public string Year {get; set;}
    public string Model {get; set;}
    public string Make {get; set;}
    public int SeatCount {get; set;}
    public int MilesToEmpty { get; set;}

    public void Drive();
    public void Reverse();
    public void Park();
    public void DisplayDetails();
}