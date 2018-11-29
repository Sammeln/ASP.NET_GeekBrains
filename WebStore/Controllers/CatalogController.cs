using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Interfaces;
using WebStore.Domain.Entities;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IProductData productData;
        public CatalogController(IProductData productData)
        {
            this.productData = productData;
        }
        public IActionResult Shop(int? sectionId, int? brandId)
        {
            var products = productData.GetProducts(new ProductFilter { SectionId = sectionId, BrandId = brandId });
            var catalog = new CatalogViewModel()
            {
                BrandId = brandId,
                SectionId = sectionId,
                Products = products.Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    ImageUrl = p.ImageUrl,
                    Name = p.Name,
                    Order = p.Order,
                    Price = p.Price,
                    Brand = p.Brand != null ? p.Brand.Name : string.Empty
                }).OrderBy(p => p.Order).ToList()
            };
            return View(catalog);
        }
        public IActionResult ProductDetails(int id)
        {
            var product = productData.GetProductByID(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(new ProductViewModel
            {
                Id = product.Id,
                ImageUrl = product.ImageUrl,
                Name = product.Name,
                Order = product.Order,
                Price = product.Price,
                Brand = product.Brand != null ? product.Brand.Name : string.Empty
            });
        }
    }
}