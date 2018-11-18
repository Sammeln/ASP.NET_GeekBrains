using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;
using WebStore.Infrastructure.Interfaces;
namespace WebStore.controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeesData employees;
        public EmployeesController(IEmployeesData employees)
        {
            this.employees = employees;
        }

        public IActionResult Index()
        {
            return View(employees.GetAll());
        }

        public IActionResult Details(int id)
        {
            EmployeeViewModel employee = employees.GetById(id);
            if (ReferenceEquals(employee, null))
            {
                return NotFound();
            }
            return View(employee);
        }
        [Route("edit/{id?}")]
        public IActionResult Edit(int? id)
        {
            EmployeeViewModel employee;
            if (id.HasValue)
            {
                employee = employees.GetById(id.Value);
                if (ReferenceEquals(employee, null))
                {
                    return NotFound();
                }
            }
            else
            {
                employee = new EmployeeViewModel();
            }
            return View(employee);
        }
        [HttpPost]
        [Route("edit/{id?}")]
        public IActionResult Edit(EmployeeViewModel employee)
        {
            if (employee.Age < 18 || employee.Age > 65)
            {
                ModelState.AddModelError("Age", "Не менее 18 и не более 65 лет");
            }
            if (ModelState.IsValid)
            {

                if (employee.Id > 0)
                {
                    var dbItem = employees.GetById(employee.Id);
                    if (ReferenceEquals(dbItem, null))
                    {
                        return NotFound();

                    }
                    dbItem.FirstName = employee.FirstName;
                    dbItem.LastName = employee.LastName;
                    dbItem.Age = employee.Age;
                    dbItem.Patronymic = employee.Patronymic;
                    dbItem.Departament = dbItem.Departament;
                }
                else
                {
                    employees.AddEmployee(employee);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            employees.DeleteEmployee(id);
            return RedirectToAction(nameof(Index));
        }
    }
}