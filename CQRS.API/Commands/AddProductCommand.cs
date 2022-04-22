﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.API.Commands
{
    public class AddProductCommand
    {
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
