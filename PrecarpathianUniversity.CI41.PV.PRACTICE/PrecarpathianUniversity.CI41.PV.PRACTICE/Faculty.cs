using System;
using System.Collections.Generic;
using System.Linq;

namespace PrecarpathianUniversity.CI41.PV.PRACTICE
{
    public class Faculty
    {
        public static int CurrentId;
        public List<Department> FacultyDepartments = new List<Department>();

        public Faculty(string facultyName, string facultyHead, string facultyLocation)
        {
            FacultyId = GetNextId();
            FacultyName = facultyName;
            FacultyHead = facultyHead;
            FacultyLocation = facultyLocation;
        }

        public int FacultyId { get; set; }
        public string FacultyName { get; set; }
        public string FacultyHead { get; set; }
        public string FacultyLocation { get; set; }

        public int GetNextId()
        {
            return ++CurrentId;
        }

        public void CreateDepartment()
        {
            Console.WriteLine("Type in name of a department");
            var departmentName = Console.ReadLine();
            Console.WriteLine("Type in head of a department");
            var departmentHead = Console.ReadLine();
            Console.WriteLine("Type in location of a department");
            var departmentLocation = Console.ReadLine();
            var department = new Department(departmentName, departmentHead, departmentLocation);
            FacultyDepartments.Add(department);
        }

        public void UpdateDepartment(int departmentId)
        {
            foreach (var dep in FacultyDepartments.Where(dep => dep.DepartmentId == departmentId).ToArray())
            {
                Console.WriteLine("Type in new name of a department");
                var departmentName = Console.ReadLine();
                dep.DepartmentName = departmentName;
                Console.WriteLine("Type in new head of a department");
                var departmentHead = Console.ReadLine();
                dep.DepartmentHead = departmentHead;
                Console.WriteLine("Type in  new location of a department");
                var departmentLocation = Console.ReadLine();
                dep.DepartmentLocation = departmentLocation;
            }
        }

        public void ShowDepartments()
        {
            foreach (var department in FacultyDepartments) Console.WriteLine(department.ToString());
        }

        public void RemoveDepartment(int departmentId)
        {
            foreach (var dep in FacultyDepartments.Where(dep => dep.DepartmentId == departmentId).ToArray())
                FacultyDepartments.Remove(dep);
        }

        public void ShowDepartment(int departmentId)
        {
            foreach (var dep in FacultyDepartments.Where(dep => dep.DepartmentId == departmentId).ToArray())
                Console.WriteLine(dep);
        }

        public override string ToString()
        {
            return string.Format("{0}  -  {1}  -  {2}  -  {3} ", FacultyId, FacultyName, FacultyHead, FacultyLocation);
        }
    }
}