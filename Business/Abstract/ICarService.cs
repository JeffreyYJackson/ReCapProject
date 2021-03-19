using System.Collections.Generic;
using Core.Utilities.Result;
using Core.Utilities.Result.DataResult;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<Car> GetById(int id);
        IDataResult<List<Car>> GetCarByBrandId(int brandId);
        IDataResult<List<Car>> GetCarByColorId(int colorId);
        IDataResult<List<Car>> GetAll();
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetails();

    }
}