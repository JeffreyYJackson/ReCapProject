using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManagerTest();

            //BrandManagerTest();


            //ColorManagerTest();
            
            
            
            
            
        }

        private static void ColorManagerTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            colorManager.Add(new Color() {ColorId = 1, ColorName = "Dark Gray"});
            colorManager.Add(new Color() {ColorId = 2, ColorName = "Light Gray"});
            colorManager.Add(new Color() {ColorId = 3, ColorName = "Black"});
        }

        private static void BrandManagerTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            brandManager.Add(new Brand() {BrandId = 1, BrandName = "Kia"});
        }

        private static void CarManagerTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //carManager.Update(new Car(){Id = 3, BrandId = 1, ColorId = 3, ModelYear = 2011, DailyPrice = 150.50, Description = "150.000 Kilometers", Name = "Sorento"});
            // carManager.Delete(carManager.GetById(1));
            // carManager.Delete(carManager.GetByIColorManagerTd(2));

            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("{0} {1} {2} {3}", car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
            }
        }
    }
}