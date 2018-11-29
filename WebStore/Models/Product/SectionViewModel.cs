using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Entities.Base;

namespace WebStore.Models
{
    public class SectionViewModel : OrderedEntity
    {
        public SectionViewModel()
        {
            ChildSections = new List<SectionViewModel>();
        }
        public List<SectionViewModel> ChildSections { get; set; }
        public SectionViewModel ParentSection { get; set; }


    }
}
