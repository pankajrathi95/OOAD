using System;

public class RoomKey
{
    string keyId;
    DateTime issueDate;
    bool isMaster;

    public void AssignRoom(Room room)
    {
        room.GetKeys().Add(this);
    }
}