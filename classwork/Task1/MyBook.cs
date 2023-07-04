public class MyBook : Book
{
    public MyBook(string title, string author, double price) : base(title, author, price)
    {
    }
    public override void GetDetails()
    {
        System.Console.WriteLine($"{Name}, {Author}, {Price}");
    }
}