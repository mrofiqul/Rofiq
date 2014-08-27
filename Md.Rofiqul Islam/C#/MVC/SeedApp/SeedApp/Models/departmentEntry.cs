using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeedApp.Models
{
    public class departmentEntry
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName{ get; set; }

        public virtual List<SectionEntry>SectionEntries { get; set; } 


    }
}