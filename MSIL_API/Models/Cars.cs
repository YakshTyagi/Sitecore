﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSIL_API.Models
{
    public class Car
    {
        public Guid Id { get; set; }
     
        public string Name { get; set; }
        public List<CarsVariant> Variants { get; set; }
    }
}
