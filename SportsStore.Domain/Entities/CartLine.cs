using SportsStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.Domain.Entities
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
