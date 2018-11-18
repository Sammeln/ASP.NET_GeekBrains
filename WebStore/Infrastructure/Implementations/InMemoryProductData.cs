using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Entities;
using WebStore.Infrastructure.Interfaces;

namespace WebStore.Infrastructure.Implementations
{
    public class InMemoryProductData : IProductData
    {
        private readonly List<Section> sections;
        private readonly List<Brand> brands;
        private readonly List<Product> products;
        public InMemoryProductData()
        {
            sections = new List<Section>
            {
                new Section{Id = 1, Name = "Sportswear",Order = 0, ParentId = null},
                    new Section{Id = 2, Name = "Nike",Order = 0, ParentId = 1},
                    new Section{Id = 3, Name = "Under Armour",Order = 1, ParentId = 1},
                    new Section{Id = 4, Name = "Adidas",Order = 2, ParentId = 1},
                    new Section{Id = 5, Name = "Puma",Order = 3, ParentId = 1},
                    new Section{Id = 6, Name = "ASICS",Order = 4, ParentId = 1},
                new Section{Id = 7, Name = "Mens",Order = 1, ParentId = null},
                    new Section{Id = 8, Name = "Fendi",Order = 0, ParentId = 7},
                    new Section{Id = 9, Name = "Guess",Order = 1, ParentId = 7},
                    new Section{Id = 10, Name = "Valentino",Order = 2, ParentId = 7},
                    new Section{Id = 12, Name = "Dior",Order = 3, ParentId = 7},
                    new Section{Id = 12, Name = "Versace",Order = 4, ParentId = 7},
                    new Section{Id = 13, Name = "Armani",Order = 5, ParentId = 7},
                    new Section{Id = 14, Name = "Prada",Order = 6, ParentId = 7},
                    new Section{Id = 15, Name = "Dolce and Gabbana",Order = 7, ParentId = 7},
                    new Section{Id = 16, Name = "Chanel",Order = 8, ParentId = 7},
                    new Section{Id = 17, Name = "Gucci",Order = 1, ParentId = 7},
                new Section{Id = 18, Name = "Womens",Order = 2, ParentId = null},
                    new Section{Id = 8, Name = "Fendi",Order = 0, ParentId = 18},
                    new Section{Id = 9, Name = "Guess",Order = 1, ParentId = 18},
                    new Section{Id = 10, Name = "Valentino",Order = 2, ParentId = 18},
                    new Section{Id = 12, Name = "Dior",Order = 3, ParentId = 18},
                    new Section{Id = 12, Name = "Versace",Order = 4, ParentId = 18},
                    new Section{Id = 13, Name = "Armani",Order = 5, ParentId = 18},
                    new Section{Id = 14, Name = "Prada",Order = 6, ParentId = 18},
                    new Section{Id = 15, Name = "Dolce and Gabbana",Order = 7, ParentId = 18},
                    new Section{Id = 16, Name = "Chanel",Order = 8, ParentId = 18},
                    new Section{Id = 17, Name = "Gucci",Order = 1, ParentId = 18},
                new Section{Id = 18, Name = "Kids",Order = 3, ParentId = null},
                new Section{Id = 19, Name = "Fashion",Order = 4, ParentId = null},
                new Section{Id = 20, Name = "Households",Order = 5, ParentId = null},
                new Section{Id = 21, Name = "Interiors",Order = 6, ParentId = null},
                new Section{Id = 22, Name = "Clothing",Order = 7, ParentId = null},
                new Section{Id = 23, Name = "Bags",Order = 8, ParentId = null},
                new Section{Id = 24, Name = "Shoes",Order = 9, ParentId = null}
            };
            brands = new List<Brand>
            {
                new Brand(1,"Acne",0),
                new Brand(2,"Grüne Erde",1),
                new Brand(3,"Albiro",2),
                new Brand(4,"Ronhill",3),
                new Brand(5,"Oddmolly",4),
                new Brand(6,"Boudestijn",5),
                new Brand(7,"Rösch creative culture",6)
            };
            products = new List<Product>
            {
                new Product()
                {
                    Id = 1,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product1.jpg",
                    Order = 0,
                    SectionId = 2,
                    BrandId = 1
                },
                 new Product()
                {
                    Id = 2,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product2.jpg",
                    Order = 1,
                    SectionId = 2,
                    BrandId = 1
                },
                new Product()
                {
                    Id = 3,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product3.jpg",
                    Order = 2,
                    SectionId = 2,
                    BrandId = 1
                },
                new Product()
                {
                    Id = 4,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product4.jpg",
                    Order = 3,
                    SectionId = 2,
                    BrandId = 1
                },
                new Product()
                {
                    Id = 5,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product5.jpg",
                    Order = 4,
                    SectionId = 2,
                    BrandId = 2
                },
                new Product()
                {
                    Id = 6,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product6.jpg",
                    Order = 5,
                    SectionId = 2,
                    BrandId = 2
                },
                new Product()
                {
                    Id = 7,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product7.jpg",
                    Order = 6,
                    SectionId = 2,
                    BrandId = 2
                },
                new Product()
                {
                    Id = 8,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product8.jpg",
                    Order = 7,
                    SectionId = 25,
                    BrandId = 2
                },
                new Product()
                {
                    Id = 9,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product9.jpg",
                    Order = 8,
                    SectionId = 25,
                    BrandId = 2
                },
                new Product()
                {
                    Id = 10,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product10.jpg",
                    Order = 9,
                    SectionId = 25,
                    BrandId = 3
                },
                new Product()
                {
                    Id = 11,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product11.jpg",
                    Order = 10,
                    SectionId = 25,
                    BrandId = 3
                },
                new Product()
                {
                    Id = 12,
                     Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product12.jpg",
                    Order = 11,
                    SectionId = 25,
                    BrandId = 3
                },
            };
        }

        public IEnumerable<Brand> GetBrands()
        {
            return brands;
        }

        public IEnumerable<Section> GetSections()
        {
            return sections;
        }
        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
        public IEnumerable<Product> GetProducts(ProductFilter filter)
        {
            var products = this.products;
            if (filter.SectionId.HasValue)
            {
                products = products.Where(p => p.SectionId.Equals(filter.SectionId)).ToList();
            }
            if (filter.BrandId.HasValue)
            {
                products = products.Where(p => p.BrandId.Equals(filter.BrandId)).ToList();
            }
            return products;
        }

    }
}
