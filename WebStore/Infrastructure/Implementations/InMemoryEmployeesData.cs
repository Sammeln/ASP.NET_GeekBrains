using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;


namespace WebStore.Infrastructure.Implementations
{
    public class InMemoryEmployeesData : IEmployeesData 
    {
        #region private members

        private readonly List<EmployeeViewModel> employees;

        #endregion
        #region CTOR

        public InMemoryEmployeesData()
        {
            employees = new List<EmployeeViewModel>
            {
                new EmployeeViewModel{ Id = 1, FirstName =  "Иван",LastName = "Иванов",Patronymic = "Иванович",Departament = "Производство",Age = 25},
                new EmployeeViewModel{ Id = 2, FirstName =  "Сергей",LastName = "Петров",Patronymic = "Дмитриевич",Departament = "Продажи",Age = 32},
                new EmployeeViewModel{ Id = 3, FirstName =  "Владимир",LastName = "Родионов",Patronymic = "Петрович",Departament = "Бухгалтерия",Age = 22},
                new EmployeeViewModel{ Id = 4, FirstName =  "Дмитрий",LastName = "Трофимов",Patronymic = "Михайлович",Departament = "Снабжение",Age = 43}
            };
        }

        #endregion
        #region Public methods

        public void AddEmployee(EmployeeViewModel employee)
        {
            employee.Id = employees.Max(e => e.Id) + 1;
            employees.Add(employee);
        }

        public void DeleteEmployee(int id)
        {
            EmployeeViewModel employee = GetById(id);
            if (employee != null)
            {
                employees.Remove(employee);
            }
        }

        public IEnumerable<EmployeeViewModel> GetAll()
        {
            return employees;
        }

        public EmployeeViewModel GetById(int Id)
        {
            return employees.FirstOrDefault(e => e.Id.Equals(Id));
        }

        public void Save()
        {
        } 
        #endregion
    }
}
