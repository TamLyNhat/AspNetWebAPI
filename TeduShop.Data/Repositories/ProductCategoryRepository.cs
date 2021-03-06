﻿using System.Collections.Generic;
using System.Linq;
using TeduShop.Model.Models;

namespace TeduShop.Data.Infastructure
{
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>
    {
        public ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.GetProductCategories.Where(x => x.Alias == alias);
        }
    }

    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
}