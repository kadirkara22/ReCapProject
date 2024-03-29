﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfRentalDal:EfEntityRepositoryBase<Rental, RentACarContext>,IRentalDal
    {
      
        public List<RentalDetailDto> GetCarDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (RentACarContext context =new RentACarContext())
            {
				var result = from r in filter == null ? context.Rentals : context.Rentals.Where(filter)
							 join c in context.Cars
							 on r.CarId equals c.Id
							 join b in context.Brands
							 on c.BrandId equals b.BrandId
							 join co in context.Colors
							 on c.ColorId equals co.ColorId
							 join cu in context.Customers
							 on r.CustomerId equals cu.Id
                             join u in context.Users
                             on cu.UserId equals u.Id
                             select new RentalDetailDto
							 {
								RentalId=r.Id,
								CarId=r.CarId,
								BrandName=b.BrandName,
								ColorName=co.ColorName,
								CompanyName=cu.CompanyName,
                                CustomerName=u.FirstName+" "+u.LastName,
                                RentDate =r.RentDate,
								ReturnDate=r.ReturnDate,
								Decription=c.Description,
								ModelYear=c.ModelYear,
								DailyPrice=c.DailyPrice
							 };
				return result.ToList();
			}
        }
    }
}
