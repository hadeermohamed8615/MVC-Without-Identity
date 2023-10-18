using CUR2Demo.Validators;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CUR2Demo.MetaData
{
    public class EmployeeMetaData
    {
       
        [MinLength(3, ErrorMessage = "Name must be more than 3 char.")]
        [MaxLength(20, ErrorMessage = "Name must be less than 3 char.")]
        [Unique]
        public string Name { get; set; }
        [RegularExpression("[a-zA-Z]{5,10}", ErrorMessage = "Address must be only char. and range char between 5 and 10")]
        public string Address { get; set; }
        [Range(22, 35)]
        // [Remote("")]
        public int Age { get; set; }
        [DisplayName("Emp Salary")]
        [Range(2500, 5000)]
        [Remote("TestSalary", "Employee", ErrorMessage = "Salary must be divid by 5",
            AdditionalFields = "DeptId")]
        // [Remote("Range","Em")] xxxxx
        public int Salary { get; set; }
        [RegularExpression(@"\w*\.(jpg|png)", ErrorMessage = "Image must end with .png OR .jpg")]
        public string Image { get; set; }
        public int DeptId { get; set; }
    }
}
