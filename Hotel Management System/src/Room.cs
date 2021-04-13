using System;
using System.Collections.Generic;

public class Room : ISearch
{
    RoomType type;
    int roomNumber;
    RoomStatus status;
    int bookingPrice;
    bool isSmoking;

    List<RoomKey> keys = new List<RoomKey>();
    List<RoomKeeping> roomKeepingLogs = new List<RoomKeeping>();

    public List<RoomKey> GetKeys()
    {
        return keys;
    }

    public List<RoomKeeping> GetRoomKeepingLogs()
    {
        return roomKeepingLogs;
    }

    public bool IsRoomAvailable()
    {
        return status == RoomStatus.AVAILABLE;
    }

    public List<Room> Search(RoomType roomType, DateTime startDate, int duration)
    {
        //TODO
        throw new NotImplementedException();
    }
}