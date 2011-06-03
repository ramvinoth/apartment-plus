using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;

namespace ApartmentPlus.Models
{
    public class Owner :Person
    {
        public virtual ICollection<Apartment> Apartments { get; set; }
    }
}