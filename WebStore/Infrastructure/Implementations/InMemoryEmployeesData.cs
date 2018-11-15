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
                new EmployeeViewModel(1,"Иван","Иванов","Иванович","Производство",new DateTime(1989,3,25),new DateTime(2012,9,10)),
                new EmployeeViewModel(2,"Сергей","Петров","Дмитриевич","Продажи",new DateTime(1975,5,2),new DateTime(2011,2,1)),
                new EmployeeViewModel(3,"Владимир","Родионов","Петрович","Бухгалтерия",new DateTime(1983,10,17),new DateTime(2008,5,30)),
                new EmployeeViewModel(4,"Дмитрий","Трофимов","Михайлович","Снабжение",new DateTime(1992,4,23),new DateTime(2005,11,26)),
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
