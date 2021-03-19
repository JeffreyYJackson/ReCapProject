using System.Collections.Generic;
using Core.Utilities.Result;
using Core.Utilities.Result.DataResult;
using Entities.Concrete;


namespace Business.Abstract
{
    public interface IColorService
    {
        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);
        IDataResult<Color> GetById(int id);
        IDataResult<List<Color>> GetAll();
    }
}