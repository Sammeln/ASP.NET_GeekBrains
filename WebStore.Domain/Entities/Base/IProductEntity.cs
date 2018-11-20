using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Domain.Entities.Base
{
    public interface IProductEntity : IOrderedEntity
    {
        int SectionId { get; set; }
        int? BrandId { get; set; }
        string ImageUrl { get; set; }
        decimal Price { get; set; }
    }
}
