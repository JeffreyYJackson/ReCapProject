using System;
using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }


        public Car GetById(int id)
        {
            return _carDal.Get(c=>c.Id == id);
        }

        public List<Car> GetCarByBrandId(int brandId)
        {
            return _carDal.GetAll(c=>c.BrandId == brandId);
        }

        public List<Car> GetCarByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }


        public List<Car> GetAll()
        {
            return _carDal.GetAll();

        }

        public void Add(Car car)
        {
            if (car.DailyPrice <= 0)
            {
                throw new Exception("Daily Price Should Be More Than 0");
            }
            if (car.Name.Length < 2)
            {
                throw new Exception("Car Name Should Be Longer Than Or Equal to 2");
            }

            if (car.Description.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
        }

        public void Update(Car car)
        { 
            _carDal.Update(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }
    }
}