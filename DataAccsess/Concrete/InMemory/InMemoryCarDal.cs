using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=150000,ModelYear=2017,Description="Bayandan satılık"},
            new Car{Id=2,BrandId=2,ColorId=2,DailyPrice=250000,ModelYear=2019,Description="Temiz kullanılmış"},
            new Car{Id=3,BrandId=3,ColorId=3,DailyPrice=350000,ModelYear=2018,Description="Doktordan satılık"},
            new Car{Id=4,BrandId=4,ColorId=4,DailyPrice=150000,ModelYear=2015,Description="Aile arabası"},
            new Car{Id=5,BrandId=5,ColorId=5,DailyPrice=200000,ModelYear=2018,Description="Kazasız, parça değişimi yok"},
            new Car{Id=6,BrandId=6,ColorId=6,DailyPrice=300000,ModelYear=2020,Description="Orjinal renginde acil satılık"}
            
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
          Car cartoDelete=_cars.SingleOrDefault(x => x.Id == car.Id);
            _cars.Remove(cartoDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
          return _cars.Where(x => x.Id == id).ToList();
        }
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car cartoUpdate = _cars.SingleOrDefault(x => x.Id == car.Id);
            cartoUpdate.BrandId = car.BrandId;
            cartoUpdate.ColorId = car.ColorId;
            cartoUpdate.DailyPrice = car.DailyPrice;
            cartoUpdate.Description = car.Description;
            cartoUpdate.ModelYear = car.ModelYear;
        }
    }
}
