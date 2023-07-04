public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public Car(string make, string model, int year, int numberOfDoor) : base(make, model, year)
    {
        NumberOfDoors = numberOfDoor;
    }
    public override string GetInfo()
    {
        return $"{base.GetInfo()}, {NumberOfDoors}";
    }
}