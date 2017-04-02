using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeMgr.Models
{
    public class Organization
    {
        public Organization()
        {
            branchList = new List<Branch>();
        }
        [Key]
        public int orgId { get; set; }
        public int orgParentId { get; set; }
        public string orgName { get; set; }
        public virtual ICollection<Branch> branchList { get; set; }
    }
}