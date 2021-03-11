﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class Car:IEntity
    {
        public int Id { get; set; }
        public string BrandId { get; set; }
        public string ColorId { get; set; }
        public string ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }

    }
}
