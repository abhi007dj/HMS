using HMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMS.Areas.Dashboard.ViewModel
{
    public class AccomodationTypeViewModel
    {
        public IEnumerable<AccomodationType> AccomodationTypes { get; set; }
    }
}