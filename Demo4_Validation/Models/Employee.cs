using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Demo4_Validation.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(12)]
        public string Name { get; set; }

        [Range(10, 20)]
        public int Age { get; set; }
    }
}