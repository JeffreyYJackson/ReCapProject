using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal:EfEntityRepositoryBase<Rental, CarRentalContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from r in context.Rentals
                    join cr in context.Cars on r.CarId equals cr.Id
                    join c in context.Customers on r.CustomerId equals c.Id
                    join u in context.Users on c.UserId equals u.Id
                    select new RentalDetailDto()
                    {
                        Id = r.Id,
                        CarName = cr.Name,
                        CustomerName = u.FirstName + " " + u.LastName,
                        RentDate = r.RentDate,
                        IsReturned = r.ReturnDate != null
                    };
                return result.ToList();
            }
            
        }
    }
}