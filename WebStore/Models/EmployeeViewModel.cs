using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class EmployeeViewModel
    {
        public EmployeeViewModel(int id,string firstName, string lastName, string patronymic, string departament, DateTime dateBirth, DateTime empplymentDate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            Departament = departament;
            Age = DateTime.Now.Year - dateBirth.Year;
            EmploymentDate = empplymentDate.Date.ToShortDateString() ;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Departament { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmploymentDate { get; set; }


    }
}
