using System;

public class RoomKeeping
{
    DateTime startDateTime;
    DateTime endDateTime;

    string description;

    public void AddRoomKeeping(Room room)
    {
        room.GetRoomKeepingLogs().Add(this);
    }
}