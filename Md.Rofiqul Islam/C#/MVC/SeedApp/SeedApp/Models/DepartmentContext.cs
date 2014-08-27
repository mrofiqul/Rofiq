using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SeedApp.Models
{
    public class DepartmentContext:DbContext

{

        public DbSet<departmentEntry>DepartmentEntries{ get; set; }
        public DbSet<SectionEntry>SectionEntries{ get; set; }
}
}