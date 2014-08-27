using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SeedApp.Models
{
    public class SampleData:DropCreateDatabaseIfModelChanges<DepartmentContext>
    {
        protected override void Seed(DepartmentContext context)
        {
            var departments = new List<departmentEntry>
            {
                new departmentEntry {DepartmentName = "cse", DepartmentCode = "123"},
                new departmentEntry {DepartmentName = "cse", DepartmentCode = "456"},
                new departmentEntry {DepartmentName = "cse", DepartmentCode = "965"},
                new departmentEntry {DepartmentName = "cse", DepartmentCode = "789"},
            };

            new List<SectionEntry>
            {
                new SectionEntry
                {
                    SectionCode = "4875",
                    Departments = departments[0],
                    Description = "khalid vai is a good man"
                },
                new SectionEntry
                {
                    SectionCode = "4876",
                    Departments = departments[1],
                    Description = "khalid vai is a good man"
                },
                new SectionEntry
                {
                    SectionCode = "4877",
                    Departments = departments[2],
                    Description = "khalid vai is a good man"
                },
                new SectionEntry
                {
                    SectionCode = "48773",
                    Departments = departments[3],
                    Description = "khalid vai is a good man"
                }

            }.ForEach(section=>context.SectionEntries.Add(section));
        }

    }
}