using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
        Car GetById(int id, bool access);
        List<Car> GetByBrandId(int brandId, bool access);
        List<Car> GetAll(bool access);
        void Add(Car car, bool access);
        void Update(Car car, bool access);
        void Delete(Car car, bool access);
    }
}