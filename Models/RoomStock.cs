﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HotelBookingSystem.Models;

public partial class RoomStock
{
    public int Id { get; set; }

    public DateTime Day { get; set; }

    public int NumOfAvailableRooms { get; set; }

    public int RoomTypeId { get; set; }
}