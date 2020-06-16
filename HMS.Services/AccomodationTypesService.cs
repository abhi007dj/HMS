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
            var dbContext = new HMSContext();

            var data = dbContext.AccomodationTypes.ToList();

            return data;
        }

        public AccomodationType GeAccomodationTypeById(int Id)
        {
            var dbContext = new HMSContext();

            var data = dbContext.AccomodationTypes.Find(Id);

            return data;
        }
        public bool SaveAccomodationType(AccomodationType accomodationType)
        {
            var dbContext = new HMSContext();

            dbContext.AccomodationTypes.Add(accomodationType);

            return dbContext.SaveChanges()>0;
        }

        public bool UpdateAccomodationType(AccomodationType accomodationType)
        {
            var dbContext = new HMSContext();

            dbContext.Entry(accomodationType).State = System.Data.Entity.EntityState.Modified;

            return dbContext.SaveChanges()>0;
        }


        public bool DeleteAccomodationType(AccomodationType accomodationType)
        {
            var dbContext = new HMSContext();

            dbContext.Entry(accomodationType).State = System.Data.Entity.EntityState.Deleted;

            return dbContext.SaveChanges() > 0;
        }

    }
}
