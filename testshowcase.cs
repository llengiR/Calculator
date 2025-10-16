// pp  vv mc
//Bookingmanager.Instance
//bookseat

public class Program
{
    public static void Main()
    {
        var m1 = BookingManager.Instance;
        var m2 = BookingManager.Instance;

        var first = m2.Bookseat("Seat1");
        var second = m1.Bookseat("Seat1");

        Console.WriteLine(first);
        Console.WriteLine(second);
    }
}