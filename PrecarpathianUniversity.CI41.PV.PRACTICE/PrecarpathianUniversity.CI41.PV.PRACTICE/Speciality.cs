using System;
using System.Collections.Generic;
using System.Linq;

namespace PrecarpathianUniversity.CI41.PV.PRACTICE
{
    public class Speciality
    {
        private int _currentId;
        public List<Group> SpecialityGroups = new List<Group>();

        public Speciality(string specialityName)
        {
            SpecialityId = GetNextId();
            SpecialityName = specialityName;
        }


        public int SpecialityId { get; set; }
        public string SpecialityName { get; set; }

        private int GetNextId()
        {
            return ++_currentId;
        }

        public void CreateGroup()
        {
            Console.WriteLine("Type in name of a group");
            var groupName = Console.ReadLine();
            Console.WriteLine("Type in year of study");
            var yearOfStudy = Convert.ToInt32(Console.ReadLine());
            var group = new Group(groupName, yearOfStudy);
            SpecialityGroups.Add(group);
        }

        public void UpdateGroup(int groupId)
        {
            foreach (var grp in SpecialityGroups.Where(grp => grp.GroupId == groupId).ToArray())
            {
                Console.WriteLine("Type in name of a group");
                var groupName = Console.ReadLine();
                grp.GroupName = groupName;
                Console.WriteLine("Type in year of study");
                var yearOfStudy = Convert.ToInt32(Console.ReadLine());
                grp.YearOfStudy = yearOfStudy;
            }
        }

        public void ShowGroups()
        {
            foreach (var group in SpecialityGroups) Console.WriteLine(group.ToString());
        }

        public void RemoveGroup(int groupId)
        {
            foreach (var grp in SpecialityGroups.Where(grp => grp.GroupId == groupId).ToArray())
                SpecialityGroups.Remove(grp);
        }

        public void ShowDepartment(int groupId)
        {
            foreach (var grp in SpecialityGroups.Where(grp => grp.GroupId == groupId).ToArray()) Console.WriteLine(grp);
        }

        public override string ToString()
        {
            return string.Format("{0}  -  {1}", SpecialityId, SpecialityName);
        }
    }
}