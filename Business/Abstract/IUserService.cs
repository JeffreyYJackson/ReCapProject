using System.Collections.Generic;
using Core.Utilities.Result;
using Core.Utilities.Result.DataResult;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IResult Remove(User user);
        IDataResult<User> GetById(int id);
        IDataResult<List<User>> GetAll();
    }
}