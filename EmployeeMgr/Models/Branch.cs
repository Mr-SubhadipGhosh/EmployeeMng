using System;
using System.Collections.Generic;
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
        public int branchId { get; set; }
        public string branchPhone { get; set; }
        public string location { get; set; }

        public virtual ICollection<Dept> depts { get; set; }

    }
}