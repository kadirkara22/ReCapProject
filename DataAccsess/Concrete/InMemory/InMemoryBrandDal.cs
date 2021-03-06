using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;
        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
            {
                new Brand{Id=1,BrandName="BMW"},
                new Brand{Id=2,BrandName="Mercedes"},
                new Brand{Id=3,BrandName="Toyota"},
                new Brand{Id=4,BrandName="Audi"},
                new Brand{Id=5,BrandName="Opel"},
            };
        }
        public void Add(Brand entity)
        {
            _brands.Add(entity);
        }

        public void Delete(Brand entity)
        {
          Brand deleteToBrand=_brands.SingleOrDefault(x => x.Id == entity.Id);
            _brands.Remove(deleteToBrand);
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            return _brands;
        }

        public void Update(Brand entity)
        {
           Brand updateToBrand=_brands.SingleOrDefault(x => x.Id == entity.Id);
            updateToBrand.BrandName = entity.BrandName;
        }
    }
}
