using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Entities.Base;

namespace WebStore.Domain.Entities
{
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
    }
}
