using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Entities
{
   public class Booking
    {
        public int Id { get; set; } 
        public int AccomodationId { get; set; }
        public Accomodation Accomodation { get; set; }
        public DateTime FromDate { get; set; }


        /// <summary>
        /// No of Stay Nights
        /// </summary>
        public int Duration { get; set; }
    }
}
