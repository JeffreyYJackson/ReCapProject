using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car(){Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 50, ModelYear = 2005, Description = "An okey car"}, 
                new Car(){Id = 2, BrandId = 1, ColorId = 1, DailyPrice = 150, ModelYear = 2013, Description = "4x4 Jeep"},
                new Car(){Id = 3, BrandId = 2, ColorId = 2, DailyPrice = 40, ModelYear = 2003, Description = "A questionable car"},
                new Car(){Id = 4, BrandId = 2, ColorId = 3, DailyPrice = 500, ModelYear = 2020, Description = "A luxurious"},
                
            };
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c=>c.Id == id);
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _cars.Where(p => p.BrandId == brandId).ToList();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(carToDelete);
        }
    }
}