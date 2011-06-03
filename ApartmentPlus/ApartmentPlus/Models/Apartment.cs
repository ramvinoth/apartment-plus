using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApartmentPlus.Models
{
    public class Apartment
    {
        public int ApartmentID { get; set; }
        public string Name { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public virtual Owner Owner { get; set; }
        public int Storey { get; set; }
    }
}