using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeMgr.Models
{
    public class Organization
    {
       
        [Key]
        public int orgId { get; set; }
        public int orgParentId { get; set; }
        [Required]
        public string orgName { get; set; }
    }
}