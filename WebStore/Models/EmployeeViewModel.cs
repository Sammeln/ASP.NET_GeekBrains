using System;
using System.ComponentModel.DataAnnotations;
namespace WebStore.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false,ErrorMessage = "Обязательное поле")]
        [Display(Name = "Имя")]
        [StringLength(maximumLength:200, MinimumLength = 2, ErrorMessage = "Не более 200 и не менее 2 символов")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Обязательное поле")]
        [Display(Name = "Фамилия")]
        [StringLength(maximumLength: 200, MinimumLength = 2, ErrorMessage = "Не более 200 и не менее 2 символов")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Обязательное поле")]
        [Display(Name = "Отчество")]
        [StringLength(maximumLength: 200, MinimumLength = 2, ErrorMessage = "Не более 200 и не менее 2 символов")]
        public string Patronymic { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Обязательное поле")]
        [Display(Name = "Отдел")]
        [StringLength(maximumLength: 200, MinimumLength = 2, ErrorMessage = "Не более 200 и не менее 2 символов")]
        public string Departament { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Обязательное поле")]
        [Display(Name = "Возраст")]
        public int Age { get; set; }
    }
}
