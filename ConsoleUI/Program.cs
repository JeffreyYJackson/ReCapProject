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
            //CarManagerTest();

            BrandManagerTest();


            //ColorManagerTest();

            //UserManagerTest();

            //CustomerManagerTest();


            //RentalManagerTest();
        }

        private static void RentalManagerTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //Console.WriteLine(rentalManager.ReturnCar(2).Message);

            //Console.WriteLine(rentalManager.Add(new Rental(){Id = 4, CustomerId = 1, CarId = 1, RentDate = DateTime.Now}).Message);
            foreach (var rental in rentalManager.GetRentalDetails().Data)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} ", rental.Id, rental.CustomerName, rental.CarName, rental.RentDate,
                    rental.IsReturned);
                //Console.WriteLine(rental.CarId);
            }
        }

        private static void CustomerManagerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer() {Id = 1, UserId = 1, CompanyName = "Jacson Inc."});

            foreach (var user in customerManager.GetCustomerDetails().Data)
            {
                Console.WriteLine("{0} {1} {2} ", user.Id, user.UserName, user.CompanyName);
            }
        }

        private static void UserManagerTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            //userManager.Add(new User(){Id = 1, FirstName = "Jeffrey", LastName = "Jackson", Email = "jeffrey.y.jackson@gmail.com", Password = "12345"});

            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName);
            }
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

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
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