using System;
using System.Collections.Generic;
using System.Linq;

namespace PrecarpathianUniversity.CI41.PV.PRACTICE
{
    public class University
    {
        public static List<Faculty> UniversityFaculties = new List<Faculty>();

        public void CreateFaculty()
        {
            Console.WriteLine("Type in name of a faculty");
            var facultyName = Console.ReadLine();
            Console.WriteLine("Type in head of a faculty");
            var facultyHead = Console.ReadLine();
            Console.WriteLine("Type in location of a faculty");
            var facultyLocation = Console.ReadLine();
            var fac = new Faculty(facultyName, facultyHead, facultyLocation);
            UniversityFaculties.Add(fac);
        }

        public void UpdateFaculty(int facultyId)
        {
            foreach (var fac in UniversityFaculties.Where(faculty => faculty.FacultyId == facultyId).ToArray())
            {
                Console.WriteLine("Type in new name of a faculty");
                var facultyName = Console.ReadLine();
                fac.FacultyName = facultyName;
                Console.WriteLine("Type in new head of a faculty");
                var facultyHead = Console.ReadLine();
                fac.FacultyHead = facultyHead;
                Console.WriteLine("Type in  new location of a faculty");
                var facultyLocation = Console.ReadLine();
                fac.FacultyLocation = facultyLocation;
            }
        }

        public void ShowFaculties()
        {
            foreach (var faculty in UniversityFaculties) Console.WriteLine(faculty.ToString());
        }

        public void RemoveFaculty(int facultyId)
        {
            foreach (var faculty in UniversityFaculties.Where(faculty => faculty.FacultyId == facultyId).ToArray())
                UniversityFaculties.Remove(faculty);
        }

        public void ShowFaculty(int facultyId)
        {
            foreach (var faculty in UniversityFaculties.Where(faculty => faculty.FacultyId == facultyId).ToArray())
                Console.WriteLine(faculty);
        }
    }
}