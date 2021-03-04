using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(x => x.ModelYear).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.DailyPrice).GreaterThan(0);
            RuleFor(x => x.DailyPrice).NotEmpty();
            RuleFor(x => x.ColorId).NotEmpty();
            RuleFor(x => x.BrandId).NotEmpty();
            

            //başka örnekler
            //RuleFor(x => x.CarName).Must(StartWithA).WithMessage("ürünler A ile başlamalı");
            //RuleFor(x => x.DailyPrice).GreaterThan(10).When(x => x.BrandId == 1);

        }

        //private bool StartWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
