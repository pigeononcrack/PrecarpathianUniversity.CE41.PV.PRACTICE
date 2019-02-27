using System;

namespace PrecarpathianUniversity.CI41.PV.PRACTICE
{
    internal class Program
    {
        private static void Main()
        {
            var pnu = new University();
            var mai = new Faculty("Faculty of Mathematics and Informatics", "Pylypiv Volodymyr",
                "Shevchenka, 57, Main campus");
            mai.CreateDepartment();
            mai.ShowDepartments();

            var ftf = new Faculty("Faculty of Physics and Technology", "Gasiuk Ivan", "Shevchenka, 57, Main campus");
            var cee = new Department("The department of Computer Engineering and Electronics", "Kogut Igor",
                "Shevchenka, 57, Main campus");
            ftf.FacultyDepartments.Add(cee);
            var ce = new Speciality("Computer Engineering");
            cee.DepartmentSpecialities.Add(ce);
            var ce41 = new Group("CE41", 4);
            var pv = new Student("Pentsak Victor", "1998-05-02", "full time");
            ce41.GroupStudents.Add(pv);
            ce41.ShowStudents();

            Console.Read();
        }
    }
}