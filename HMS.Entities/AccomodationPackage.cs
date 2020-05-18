using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Entities
{
    public class AccomodationPackage
    {
        public int Id { get; set; } 
        public int AccomodationTypeId { get; set; }
        public  AccomodationType AccomodationType { get; set; }

        public int NoOfRooms { get; set; }
        public decimal ChargesPerNight { get; set; }

    }
}
