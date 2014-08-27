using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentApp.Models
{
    public class StudentDb:DbContext
    {
        public DbSet<Student> Students { get; set; }


    }
}