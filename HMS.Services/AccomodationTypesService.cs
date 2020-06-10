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
        public bool SaveAccomodationType(AccomodationType accomodationType)
        {
            HMSContext dbContext = new HMSContext();

            dbContext.AccomodationTypes.Add(accomodationType);

            return dbContext.SaveChanges()>0;
        }


    }
}
