using Business.Concrete;
using DataAccsess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Id:{0},brandId : {1},colorId: {2}, modelYear: {3}, DailyPrice :{4}, Description :{5}",car.Id,car.BrandId,car.ColorId,car.ModelYear,car.DailyPrice,car.Description);
            }
            Console.ReadLine();
        }
    }
}
