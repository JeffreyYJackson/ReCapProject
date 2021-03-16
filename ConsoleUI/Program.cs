using System;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            
            carManager.Add(new Car(){Id = 1, BrandId = 1, ColorId = 2, DailyPrice = 100.50, ModelYear = 2008, Name = "Sorento", Description = "200.000 Kilometers"});
            carManager.Add(new Car(){Id = 2, BrandId = 1, ColorId = 1, DailyPrice = 150.50, ModelYear = 2011, Name = "Sorento", Description = "100.000 Kilometers"});
            
            // carManager.Delete(carManager.GetById(1));
            // carManager.Delete(carManager.GetById(2));

            foreach (var car in carManager.GetCarByColorId(2))
            {
                Console.WriteLine(car.Name + " " + car.Description);
            }
        }
    }
}