using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmployeeMgr.Models
{
    public class Branch
    {
        public Branch()
        {
            depts = new List<Dept>();
        }
        [Key]
        public int branchId { get; set; }
        public string branchPhone { get; set; }
        [Required]
        public string location { get; set; }
        public virtual ICollection<Dept> depts { get; set; }
        public int OrgId { get; set; }
        [ForeignKey("OrgId")]
        public virtual Organization branchOrg { get; set; }

    }
}