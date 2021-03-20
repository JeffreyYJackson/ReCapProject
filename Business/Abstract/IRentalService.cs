using System.Collections.Generic;
using Core.Utilities.Result;
using Core.Utilities.Result.DataResult;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Remove(Rental rental);
        IDataResult<Rental> GetById(int id);
        IDataResult<List<Rental>> GetAll();
        IResult ReturnCar(int rentalId);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
    }
}