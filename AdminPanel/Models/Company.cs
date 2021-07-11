using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace admin.Models
{
    [Table(name: "Company")]
    public class Company
    {
        public Company()
        {
        }

        [Key]
        public int CompanyID { get; set; }
        [Column(TypeName = "varchar(100)")]
        [StringLength(maximumLength: 100, MinimumLength = 3)]
        [Required(ErrorMessage = "Company name is required")]
        public string CompanyName { get; set; }

        //public static bool IsWellFormedUriString(string? uriString, UriKind uriKind);
        [Column(TypeName = "varchar(200)")]
        [StringLength(maximumLength: 200, MinimumLength = 10)]
        [Required(ErrorMessage = "Company Website is required")]
       [RegularExpression("^(http(s?):\\/\\/)?([\\w-]+\\.)+[\\w-]+(/[\\w- ./?%&=]*)?$", ErrorMessage = "Invalid website URL")]
       
        public string CompanyWebsite { get; set; }

        [Column(TypeName = "varchar(300)")]
        [StringLength(maximumLength: 300, MinimumLength = 3)]
        public string CompAddress { get; set; }

        public List<Employee> Employees {get; set;}



    }
}
