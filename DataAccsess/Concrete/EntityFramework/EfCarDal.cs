﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)   
        {
            using (RentACarContext context =new RentACarContext())
            {
                var result = from c in filter == null ? context.Cars : context.Cars.Where(filter)
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join ci in context.CarImages
                             on c.Id equals ci.CarId
                             select new CarDetailDto { 
                                CarId=c.Id,
                                ColorId=co.ColorId,
                                BrandId=b.BrandId,
                                BrandName=b.BrandName,
                                ColorName=co.ColorName,
                                DailyPrice=c.DailyPrice,
                                Description=c.Description,
                                ModelYear=c.ModelYear,
                                CarImageDate = ci.Date,
                                ImagePath = ci.ImagePath,
                                 Findeks = c.Findeks,
                             };

                return result.ToList();
            }
        }
    }
}
