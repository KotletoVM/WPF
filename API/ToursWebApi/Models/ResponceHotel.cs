using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToursWebApi.Entities;

namespace ToursWebApi.Models
{
    public class ResponceHotel
    {
        public ResponceHotel(Hotel hotel)
        {
            Id = hotel.Id;
            Name = hotel.Name;
            CountOfStars = hotel.CountOfStars;
            CountryName = hotel.CountryCode;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountOfStars { get; set; }
        public string CountryName { get; set; }

    }
}