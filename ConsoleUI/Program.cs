using System;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());


            Console.WriteLine("Get All---------------");
            
            
            foreach (var car in carManager.GetAll(true))
            {
                Console.WriteLine(car.ModelYear);
            }
            
            
            Console.WriteLine("Add---------------");

            carManager.Add(new Car(){Id = 5, BrandId = 2, ColorId = 3, DailyPrice = 80, ModelYear = 2008, Description = "A good car"}, true);

            foreach (var car in carManager.GetAll(true))
            {
                Console.WriteLine(car.ModelYear);
            }
            
            Console.WriteLine("Update---------------");
            
            carManager.Update(new Car(){Id = 5, BrandId = 2, ColorId = 3, DailyPrice = 80, ModelYear = 2009, Description = "A good car"}, true);
            foreach (var car in carManager.GetAll(true))
            {
                Console.WriteLine(car.ModelYear);
            }

            Console.WriteLine("Remove---------------");
            
            carManager.Delete(new Car(){Id = 5, BrandId = 2, ColorId = 3, DailyPrice = 80, ModelYear = 2009, Description = "A good car"}, true);
            foreach (var car in carManager.GetAll(true))
            {
                Console.WriteLine(car.ModelYear);
            }
            
            Console.WriteLine("Get By Id---------------");

            Console.WriteLine(carManager.GetById(1, true).ModelYear);
            
            
            Console.WriteLine("Get By Brand Id---------------");

            foreach (var car in carManager.GetByBrandId(2, true))
            {
                Console.WriteLine(car.ModelYear);
                
            }
            
            
        }
    }
}