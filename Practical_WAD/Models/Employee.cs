using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Practical_WAD.Models
{
    public class Employee
    {
        [Key]
        [Required]
        public string EmployeeId { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        [Required]
        [Range(1000, 100000)]
        public int Salary { get; set; }
    }
}