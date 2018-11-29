using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.DAL.Context;
using WebStore.Domain.Entities;
using WebStore.Infrastructure.Interfaces;

namespace WebStore.Infrastructure.Implementations.SQL
{
    public class SQLProductData : IProductData
    {
        private readonly WebStoreContext context;

        public SQLProductData(WebStoreContext context)
        {
            this.context = context;
        }

        public IEnumerable<Section> GetSections()
        {
            return context.Sections.ToList();
        }

        public IEnumerable<Brand> GetBrands()
        {
            return context.Brands.ToList();
        }

        public IEnumerable<Product> GetProducts(ProductFilter filter)
        {
            var query = context.Products.AsQueryable();
            if (filter.BrandId.HasValue)
            {
                query = query.Where(p => p.BrandId.HasValue && p.BrandId.Equals(filter.BrandId.Value));
            }
            if (filter.SectionId.HasValue)
            {
                query = query.Where(p => p.SectionId.Equals(filter.SectionId.Value));
            }

            return query.ToList();
        }

        public IEnumerable<Product> GetProducts()
        {
            return context.Products.Include(p => p.Brand).Include(p => p.Section).AsQueryable();
        }

        public int GetProductsCount(int brandId)
        {
            return context.Products.Count(p => p.BrandId.Equals(brandId));
        }
        public Product GetProductByID(int id)
        {
            return context.Products.Include(p => p.Brand).Include(p => p.Section).FirstOrDefault(p => p.Id.Equals(id));
        }
    }
}
