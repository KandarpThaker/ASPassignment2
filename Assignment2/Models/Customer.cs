using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(40)")]
        [Required]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(40)")]
        [Required]
        public string LastName { get; set; }
        [Column(TypeName = "nvarchar(40)")]
        [Required]
        public string City { get; set; }
        [Column(TypeName = "nvarchar(40)")]
        [Required]
        public string Country { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        [Required]
        public string Phone { get; set; }

    }
}
