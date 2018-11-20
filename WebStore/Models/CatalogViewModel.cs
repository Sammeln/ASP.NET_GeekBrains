﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Entities;

namespace WebStore.Models
{
    public class CatalogViewModel : ProductFilter
    {
        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}
