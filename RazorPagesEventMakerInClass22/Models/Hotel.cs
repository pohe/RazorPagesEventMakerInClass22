﻿namespace RazorPagesEventMakerInClass22.Models
{
    public class Hotel
    {
        public Hotel(int id, string name, string address )
        {
            Id = id;
            Name = name;
            Address = address;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

       
    }
}
