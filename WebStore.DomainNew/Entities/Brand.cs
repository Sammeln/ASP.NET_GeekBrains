using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebStore.Domain.Entities.Base;

namespace WebStore.Domain.Entities
{
    [Table("Brands")]
    public class Brand : OrderedEntity
    {
        public Brand()
        {

        }
        public Brand(int id, string name, int order)
        {
            Id = id;
            Name = name;
            Order = order;
        }
        public virtual ICollection<Product> Products { get; set; }
    }
}
