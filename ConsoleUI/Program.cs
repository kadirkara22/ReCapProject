using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddNew();
            CarTest();
        }

        private static void AddNew()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

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
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarName + " / " + car.BrandName);
            }

            Console.ReadLine();
        }
        
    }
}
