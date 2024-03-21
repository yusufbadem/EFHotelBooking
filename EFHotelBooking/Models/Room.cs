﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFHotelBooking.Models;
public class Room:BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Capacity { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; } = true;
}
