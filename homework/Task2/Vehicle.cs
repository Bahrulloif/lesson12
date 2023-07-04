public abstract class Vehicle
{
    public string Make { get; set; }

    public string Model
    {
        get; set;
    }
    public int Year
    {
        get; set;
    }

    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }
    public virtual string GetInfo(){
return$"{Make}, {Model}, {Year}";
    }
}