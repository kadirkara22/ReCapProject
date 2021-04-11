﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Payment : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public int SecurityCode { get; set; }
      
    }
}
