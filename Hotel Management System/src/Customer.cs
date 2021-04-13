using System.Collections.Generic;

public class Customer : Person
{
    List<Booking> bookingList = new List<Booking>();

    public bool CreateBooking(Room room)
    {
        //TODO
        return true;
    }

    public List<Room> SearchRooms()
    {
        //TODO
        return null;
    }

    public bool CancelBooking(Booking booking)
    {
        //Only if cancelled before 24hrs of checkin date
        return true;
    }
}