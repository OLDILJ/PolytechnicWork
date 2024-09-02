using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace M1
{
    public static class Utils
    {
        public static List<Institution> SeedInstitutions()
        {
            List<Institution> InstituteList = new List<Institution>(3);
            InstituteList.Add(new Institution { Name = "FakeName1", Region = "FakeRegion1", Country = "FakeCountry1" });
            InstituteList.Add(new Institution { Name = "FakeName2", Region = "FakeRegion2", Country = "FakeCountry2" });
            InstituteList.Add(new Institution { Name = "FakeName3", Region = "FakeRegion3", Country = "FakeCountry3" });
            foreach (Institution institution in InstituteList)
            {
                Console.WriteLine(institution.Name);
                Console.WriteLine(institution.Region);
                Console.WriteLine(institution.Country);
            }



            return InstituteList;

        }
        public static List<Department> SeedDepartments()
        {

            List<Department> DepartmentList = new List<Department>(3);
            

            DepartmentList.Add(new Department{ Institute = new Institution { Name = "FakeName4", Region = "FakeRegion4", Country = "FakeCountry4" }, Name = "FakeDepartmentName1"});
            DepartmentList.Add(new Department{ Institute = new Institution { Name = "FakeName5", Region = "FakeRegion5", Country = "FakeCountry6" }, Name = "FakeDepartmentName2"});
            DepartmentList.Add(new Department{ Institute = new Institution { Name = "FakeName7", Region = "FakeRegion7", Country = "FakeCountry7" }, Name = "FakeDepartmentName3"});
            

            return DepartmentList;
            

        }
        public static List<Course> SeedCourses()
        {
            
            List<Course> CourseList = new List<Course>(3);
            
            CourseList.Add(new Course { Department = new Department { Institute = new Institution { Name = "FakeName5", Region = "FakeRegion5", Country = "FakeCountry5" }, Name = "FakeDepartmentName5" }, Code = "FakeCode1", Name = "FakeCourseName1", Description = "FakeDescription1", Credits = 23, Fees = 273.2 });
            CourseList.Add(new Course { Department = new Department { Institute = new Institution { Name = "FakeName6", Region = "FakeRegion6", Country = "FakeCountry6" }, Name = "FakeDepartmentName6" }, Code = "FakeCode2", Name = "FakeCourseName2", Description = "FakeDescription2", Credits = 24, Fees = 275.2 });
            CourseList.Add(new Course { Department = new Department { Institute = new Institution { Name = "FakeName7", Region = "FakeRegion7", Country = "FakeCountry7" }, Name = "FakeDepartmentName7" }, Code = "FakeCode3", Name = "FakeCourseName3", Description = "FakeDescription3", Credits = 25, Fees = 277.2 });

            
            return CourseList;
            

        }
    }
}
