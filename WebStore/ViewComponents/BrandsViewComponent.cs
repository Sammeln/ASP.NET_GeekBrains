using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;
using WebStore.Domain.Entities;

namespace WebStore.ViewComponents
{
    public class BrandsViewComponent : ViewComponent
    {
        private readonly IProductData productData;
        public BrandsViewComponent(IProductData productData)
        {
            this.productData = productData;
        }
        public IViewComponentResult Invoke()
        {
            var brands = GetBrands();
            return View(brands);
        }
        private IEnumerable<BrandViewModel> GetBrands()
        {
            var dbBrands = productData.GetBrands();
            List<BrandViewModel> brandsList = new List<BrandViewModel>();
            brandsList = dbBrands.Select(b => new BrandViewModel
            {
                Id = b.Id,
                Name = b.Name,
                Order = b.Order,
                ProductCount = productData.GetProductsCount(b.Id)
            }).OrderBy(b => b.Order).ToList();
            return brandsList;
        }
    }
}
