using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;

namespace WebStore.ViewComponents
{
    public class SectionsViewComponent : ViewComponent
    {
        private readonly IProductData productData;

        public SectionsViewComponent(IProductData productData)
        {
            this.productData = productData;
        }
        public IViewComponentResult Invoke()
        {
            var sections = GetSections();
            return View(sections);
        }
        private List<SectionViewModel> GetSections()
        {
            var categories = productData.GetSections();
            var parentCategories = categories.Where(c => !c.ParentId.HasValue).ToArray();
            List<SectionViewModel> parentSections = new List<SectionViewModel>();

            foreach (var item in parentCategories)
            {
                parentSections.Add(new SectionViewModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Order = item.Order,
                    ParentSection = null
                });
            }
            foreach (var itemParent in parentSections)
            {
                var childSection = categories.Where(c => c.ParentId.Equals(itemParent.Id));
                foreach (var itemChild in childSection)
                {
                    itemParent.ChildSections.Add(new SectionViewModel()
                    {
                        Id = itemChild.Id,
                        Name = itemChild.Name,
                        Order = itemChild.Order,
                        ParentSection = itemParent
                    });
                }
                itemParent.ChildSections = itemParent.ChildSections.OrderBy(c => c.Order).ToList();
            }
            parentSections = parentSections.OrderBy(p => p.Order).ToList();
            return parentSections;
        }
    }
}
