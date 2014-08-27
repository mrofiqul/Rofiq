using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeedApp.Models
{
    public class SectionEntry
    {
        [Key]
        public int SectionId { get; set; }
        public string SectionCode { get; set; }
        public string Description { get; set; }
        public int DepartmentId { get; set; }
        public virtual departmentEntry  Departments { get; set; }
    }
}