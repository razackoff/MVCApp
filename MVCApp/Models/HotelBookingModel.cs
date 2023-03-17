﻿namespace MVCApp.Models
{
    public class HotelBookingModel
    {
        public int Id { get; set; }
        public string GuestName { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
