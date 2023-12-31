public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }
   public Motorcycle(string make, string model, int year, bool hasSidecar) : base(make, model, year)
    {
        HasSidecar = hasSidecar;
    }
    public override string GetInfo()
    {
        return $"{base.GetInfo()}, {HasSidecar}";
    }
}