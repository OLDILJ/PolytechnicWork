using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1
{
    public static class Utils
    {
        public static List<Institution> SeedInstitutions()
        {
            List<Institution> InstituteList = new List<Institution>(3);
            InstituteList.Add (new Institution("FakeName","FakeRegion","FakeCountry"));
            InstituteList.Add (new Institution("FakeName", "FakeRegion", "FakeCountry"));
            InstituteList.Add (new Institution("FakeName", "FakeRegion", "FakeCountry"));


            return InstituteList;

        }
        public static List<Department> SeedDepartments()
        {
            List<Department> DepartmentList = new List<Department>(3);
            DepartmentList.Add(new Department(new Institution("FakeName", "FakeRegion", "FakeCountry"), ("FakeDepartmentName")));
            DepartmentList.Add(new Department(new Institution("FakeName", "FakeRegion", "FakeCountry"), ("FakeDepartmentName")));
            DepartmentList.Add(new Department(new Institution("FakeName", "FakeRegion", "FakeCountry"), ("FakeDepartmentName")));


            return DepartmentList;

        }
        public static List<Course> SeedCourses()
        {
            List<Course> CourseList = new List<Course>(3);
            CourseList.Add(new Course(new Department(new Institution("FakeName", "FakeRegion", "FakeCountry"), ("FakeDepartmentName")),("FakeCode"),("FakeCourseName"),("FakeDescription"),(23),(271.2)));
            CourseList.Add(new Course(new Department(new Institution("FakeName", "FakeRegion", "FakeCountry"), ("FakeDepartmentName")), ("FakeCode"), ("FakeCourseName"), ("FakeDescription"), (23), (271.2)));
            CourseList.Add(new Course(new Department(new Institution("FakeName", "FakeRegion", "FakeCountry"), ("FakeDepartmentName")), ("FakeCode"), ("FakeCourseName"), ("FakeDescription"), (23), (271.2)));


            return CourseList;

        }
    }
}
