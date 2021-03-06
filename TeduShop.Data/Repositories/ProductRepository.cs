﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }

    public interface IProductRepository
    {
    }
}
