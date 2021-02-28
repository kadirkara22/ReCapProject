using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            CarImageManager carImageManager = new CarImageManager(new EfCarImageDal());
            

            //AddNewCar(carManager);
            //CarTest();
            //CustomerAdded(customerManager);
            //UserAdded(userManager);
            RentAdd(rentalManager);
        }

      

        private static void AddNewCar(CarManager carManager)
        {


            Console.WriteLine("arabanın markasını giriniz");
            string marka = Console.ReadLine();
            Console.WriteLine("girmek istediğiniz arabanın model yılını giriniz.");
            int modelYili = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("girmiş olduğunuz arabanın fiyatını giriniz");
            decimal fiyat = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("açıklama giriniz");
            string aciklama = Console.ReadLine();
            Console.WriteLine("brand ID giriniz");
            int brandId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("color ID giriniz");
            int colorId = Convert.ToInt32(Console.ReadLine());

            carManager.Add(new Car
            {
                DailyPrice = fiyat,
                ModelYear = modelYili,
                CarName = marka,
                Description = aciklama,
                BrandId = brandId,
                ColorId = colorId
            });

            foreach (Car car in carManager.GetAll().Data)
            {
                Console.WriteLine((car.Id,car.BrandId, car.ColorId, car.CarName, car.DailyPrice, car.ModelYear, car.Description));

            }
        }

        private static void CarTest(CarManager carManager)
        {

            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarName + " / " + car.BrandName);
            }


        }


        private static void CustomerAdded(CustomerManager customerManager)
        {

            customerManager.Add(new Customer { UserId = 1, CompanyName = "Türktelekom" });
            customerManager.Add(new Customer { UserId = 2, CompanyName = "Türkcell" });
            customerManager.Add(new Customer { UserId = 3, CompanyName = "Vodafone" });
            customerManager.Add(new Customer { UserId = 4, CompanyName = "Yemeksepeti" });

            foreach (Customer customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.CompanyName);
            }
        }
        private static void UserAdded(UserManager userManager)
        {
            userManager.Add(new User { FirstName = "kerem", LastName = "arif", Email = "keremarif@gmail.com", Password = "12345" });
            foreach (User user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName,user.LastName,user.Email,user.Password);
            }
        }
        private static void RentAdd(RentalManager rentalManager)
        {
            List<Rental> rentals = new List<Rental>
            {
                new Rental { CarId=5,CustomerId=1,RentDate=new DateTime(2021,02,13),ReturnDate=new DateTime(2021,02,15)},
                new Rental { CarId=3,CustomerId=5,RentDate=new DateTime(2021,02,10),ReturnDate=new DateTime(2021,02,17) },
                new Rental { CarId=4,CustomerId=2,RentDate=new DateTime(2021,02,13),ReturnDate=new DateTime(2021,02,20) }
            };
            foreach (Rental rental in rentals)
            {
                rentalManager.Add(rental);
                if (rental.ReturnDate<=DateTime.Now)
                {
                    Console.WriteLine($"Araç {rental.ReturnDate} geri teslim edilmiştir");
                }
                else
                {
                    Console.WriteLine($"Araç {rental.ReturnDate} geri teslim edilecek");
                }
            }
        }
    }
}
