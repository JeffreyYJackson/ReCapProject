using System.Collections.Generic;
using Core.Utilities.Result;
using Core.Utilities.Result.DataResult;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IResult Add(Brand brand);
        IResult Update(Brand brand);
        IResult Delete(Brand brand);
        IDataResult<Brand> GetById(int id);
        IDataResult<List<Brand>> GetAll();

    }
}