﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HotelBookingSystem.Models;

public partial class DailyRoomAvailablity
{
    public int Id { get; set; }

    public int RoomNumber { get; set; }

    public DateTime Day { get; set; }

    public bool IsAvailable { get; set; }

    public virtual Room Room { get; set; }
}