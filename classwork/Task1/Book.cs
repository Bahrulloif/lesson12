public abstract class Book
{
    private string _name;
    private string _author;
    private double _price;
    public string Name {get{
    return _name; }}
    public string Author { get{
        return _author;
    } }
    public double Price { get{
        return _price;
    } }

    public Book(string name, string author, double price)
    {
        _name = name;
        _author = author;
        _price = price;
    }
    public abstract void GetDetails();
}