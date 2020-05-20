using HMS.Data;
using HMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Services
{
   public class AccomodationTypesService
    {
        public IEnumerable<AccomodationType> GetAllAccomodationType()
        {
            HMSContext Context = new HMSContext();

            var  data = Context.AccomodationTypes.ToList();

            return data;
        }


    }
}
