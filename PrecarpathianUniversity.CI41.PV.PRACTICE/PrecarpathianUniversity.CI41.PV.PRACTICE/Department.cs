using System;
using System.Collections.Generic;
using System.Linq;

namespace PrecarpathianUniversity.CI41.PV.PRACTICE

{
    public class Department
    {
        private int _currentId;
        public List<Speciality> DepartmentSpecialities = new List<Speciality>();

        public Department(string departmentName, string departmentHead, string departmentLocation)
        {
            DepartmentId = GetNextId();
            DepartmentName = departmentName;
            DepartmentHead = departmentHead;
            DepartmentLocation = departmentLocation;
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentHead { get; set; }
        public string DepartmentLocation { get; set; }

        private int GetNextId()
        {
            return ++_currentId;
        }

        public void CreateSpeciality()
        {
            Console.WriteLine("Type in name of a speciality");
            var specialityName = Console.ReadLine();
            var speciality = new Speciality(specialityName);
            DepartmentSpecialities.Add(speciality);
        }

        public void UpdateSpeciality(int specialityId)
        {
            foreach (var spec in DepartmentSpecialities.Where(dep => dep.SpecialityId == specialityId).ToArray())
            {
                Console.WriteLine("Type in new name of a speciality");
                var specialityName = Console.ReadLine();
                spec.SpecialityName = specialityName;
            }
        }

        public void ShowSpecialities()
        {
            foreach (var speciality in DepartmentSpecialities) Console.WriteLine(speciality.ToString());
        }

        public void RemoveSpeciality(int specialityId)
        {
            //UniversityFaculties.Remove(UniversityFaculties[facultyId - 1]);
            foreach (var spec in DepartmentSpecialities.Where(dep => dep.SpecialityId == specialityId).ToArray())
                DepartmentSpecialities.Remove(spec);
        }

        public void ShowFaculty(int specialityId)
        {
            foreach (var spec in DepartmentSpecialities.Where(dep => dep.SpecialityId == specialityId).ToArray())
                Console.WriteLine(spec);
        }

        public override string ToString()
        {
            return string.Format("{0}  -  {1}  -  {2}  -  {3}", DepartmentId, DepartmentName, DepartmentHead,
                DepartmentLocation);
        }
    }
}