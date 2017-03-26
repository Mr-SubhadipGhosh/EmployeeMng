using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmployeeMgr.Models
{
    public class Employee
    {
        [Key]
        public int empId { get; set; }
        public string empName { get; set; }
        [ForeignKey("Dept")]
        public int deptId { get; set; }

        public virtual Dept deptOfEmp { get; set; }
    }
}