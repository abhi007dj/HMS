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
            HMSContext dbContext = new HMSContext();

            var  data = dbContext.AccomodationTypes.ToList();

            return data;
        }


    }
}
