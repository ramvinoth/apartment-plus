using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApartmentPlus.Models
{
    public class Room
    {
        public int RoomID { get; set; }
        public string Name { get; set; }
        public int Stoney { get; set; }
        public int Position { get; set; }
        public decimal? DailyPrice { get; set; }
        public decimal? MonthlyPrice { get; set; }
        public virtual Apartment Apartment { get; set; }
    }
}