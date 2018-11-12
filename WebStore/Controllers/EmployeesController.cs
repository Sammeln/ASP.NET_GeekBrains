using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.controllers
{
    public class EmployeesController : Controller
    {
        private readonly List<EmployeeViewModel> employees = new List<EmployeeViewModel>
            {
                new EmployeeViewModel(1,"Иван","Иванов","Иванович","Продажи",new DateTime(1989,3,25),new DateTime(2012,9,10)),
                new EmployeeViewModel(2,"Сергей","Петров","Дмитриевич","Производство",new DateTime(1975,5,2),new DateTime(2011,2,1)),
                new EmployeeViewModel(3,"Владимир","Родионов","Петрович","Бухгалтерия",new DateTime(1983,10,17),new DateTime(2008,5,30)),
                new EmployeeViewModel(4,"Дмитрий","Трофимов","Михайлович","Снабжение",new DateTime(1992,4,23),new DateTime(2005,11,26)),
            };
        public IActionResult Index()
        {
            return View(employees);
        }

        public IActionResult Details(int id)
        {
            EmployeeViewModel employee = employees.FirstOrDefault(e => e.Id == id);
            if (ReferenceEquals(employee, null))
            {
                return NotFound();
            }
            return View(employee);
        }
    }
}