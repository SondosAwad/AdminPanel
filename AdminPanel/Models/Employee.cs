using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace admin.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(maximumLength: 100, MinimumLength = 3)]
      
        public string EmployeeName { get; set; }


        [StringLength(maximumLength: 50, MinimumLength = 10)]

        [RegularExpression("^[a-zA-Z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$", ErrorMessage = "Invalid email format")]


        public string EmployeeEmail { get; set; }

        [ForeignKey("Company")]
        public int CompanyID { get; set; }

        public Company Company { get; set; }



    }
}
