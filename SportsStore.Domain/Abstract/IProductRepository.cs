﻿using SportsStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        void SaveProduct(Product product);
        Product DeleteProduct(int productID);
    }
}
