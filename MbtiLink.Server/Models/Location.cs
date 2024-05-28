﻿namespace MbtiLink.Server.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
