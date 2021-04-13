using System;
using System.Collections.Generic;

public interface ISearch
{
    List<Room> Search(RoomType roomType, DateTime startDate, int duration);
}