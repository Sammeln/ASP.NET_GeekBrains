using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Infrastructure.Interfaces
{
    public interface IEmployeesData
    {
        IEnumerable<EmployeeViewModel> GetAll();
        EmployeeViewModel GetById(int Id);
        void AddEmployee(EmployeeViewModel employee);
        void DeleteEmployee(int id);
    }
}
