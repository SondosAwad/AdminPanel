using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace admin.Models
{
    public class AdminContext : DbContext
    {
      
        public AdminContext(DbContextOptions<AdminContext> options)
           : base(options)        
        {
        }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
 


    }

}
