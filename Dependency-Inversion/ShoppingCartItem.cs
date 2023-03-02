﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    public class ShoppingCartItem
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string? Title { get; set; }
        public double Price { get; set; }
    }
}