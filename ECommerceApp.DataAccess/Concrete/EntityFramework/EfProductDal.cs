using ECommerceApp.Core.DataAccess.Concrete.EntityFramework;
using ECommerceApp.DataAccess.Abstract;
using ECommerceApp.DataAccess.Concrete.EntityFramework.Contexts;
using ECommerceApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, ECommerceContext>, IProductDal
    {
        public List<Product> GetSearchResult(string searchString)
        {
            using (var context = new ECommerceContext())
            {
                var products = context
                    .Products
                    .Where(i => i.ProductName.Contains(searchString))
                    .AsQueryable();
                return products.ToList();
            };
        }
    }
}