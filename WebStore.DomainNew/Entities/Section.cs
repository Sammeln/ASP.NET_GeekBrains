using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebStore.Domain.Entities.Base;

namespace WebStore.Domain.Entities
{
    [Table("Sections")]
    public class Section : OrderedEntity
    {
        public int? ParentId { get; set; }
        [ForeignKey("ParentId")]
        public virtual Section ParentSection { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
