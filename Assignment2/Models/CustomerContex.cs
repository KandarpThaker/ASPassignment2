using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment2.Models
{
    public class CustomerContex : DbContext
    {
        public CustomerContex(DbContextOptions<CustomerContex> options) : base(options) 
        { 
        
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
