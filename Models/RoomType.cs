﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HotelBookingSystem.Models;

public partial class RoomType
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public int MaxAdults { get; set; }

    public int MaxChildren { get; set; }

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}