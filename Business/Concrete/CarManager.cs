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

        public Car GetById(int id, bool access)
        {
            if (access)
            {
                return _carDal.GetById(id);
            }

            throw new Exception("Access not granted");
        }

        public List<Car> GetByBrandId(int brandId, bool access)
        {
            if (access)
            {
                return _carDal.GetByBrandId(brandId);
            }

            throw new Exception("Access not granted");
            
        }

        public List<Car> GetAll(bool access)
        {
            if (access)
            {
                return _carDal.GetAll();
            }

            throw new Exception("Access not granted");
        }

        public void Add(Car car, bool access)
        {
            if (access)
            {
                _carDal.Add(car);
                return;
            }

            throw new Exception("Access not granted");
        }

        public void Update(Car car, bool access)
        {
            if (access)
            {
                _carDal.Update(car);
                return;
            }

            throw new Exception("Access not granted");
            
        }

        public void Delete(Car car, bool access)
        {
            if (access)
            {
                _carDal.Delete(car);
                return;
            }

            throw new Exception("Access not granted");
        }
    }
}