//Create common instance with singleton pattern _instance
//Create lock for thread safety _lock 
//Change list to HashSet for O(1) complexity 
//Create nullcheck for seatnumber 
//Make list and booking manager private. Which is a part of singleton pattern

public class BookingManager
{
    private static BookingManager _instance;
    private static readonly object _lock = new object();
    private HashSet<string> AvailableSeats { get; private set; }

    private BookingManager()
    {
        // Assume the theater always starts with 100 seats
        AvailableSeats = new HashSet<string>();
        for (int i = 1; i <= 100; i++)
        {
            AvailableSeats.Add("Seat" + i);
        }
    }

    //AH(PGLI IR)LOCK
    public static BookingManager Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new BookingManager();
                }
                return _instance;
            } 
        }
    }



    public bool BookSeat(string seatNumber)
    {
        if(string.IsNullOrEmpty(seatNumber))
        {
            return false;
        }
        lock (_lock)
        {
            if (AvailableSeats.Contains(seatNumber))
            {
                AvailableSeats.Remove(seatNumber);
                return true;
            }
            return false;
        }
    }

    public void ResetSeats()
    {
        lock (_lock)
        {
            // Reset seats to the original 100 available
            AvailableSeats.Clear();
            for (int i = 1; i <= 100; i++)
            {
                AvailableSeats.Add("Seat" + i);
            }
        }
    }
}