using CUR2Demo.Entities;
using CUR2Demo.Models.Day2;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace CUR2Demo.Validators
{
    public class UniqueAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string str = value.ToString();
            CUR2Company Db = new CUR2Company();
            Employee empFromDB = Db.Employees.FirstOrDefault(x => x.Name == str) ;
         
            if(empFromDB == null)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Name Already Exist");
            }
          
        }
    }
}
