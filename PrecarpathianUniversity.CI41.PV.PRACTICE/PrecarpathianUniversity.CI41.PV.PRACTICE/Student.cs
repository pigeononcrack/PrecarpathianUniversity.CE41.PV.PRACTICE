namespace PrecarpathianUniversity.CI41.PV.PRACTICE
{
    public class Student
    {
        private int _currentId;

        public Student(string studentName, string birthdayDate, string dataAboutFormOfStudy)
        {
            StudentId = GetNextId();
            StudentName = studentName;
            BirthdayDate = birthdayDate;
            DataAboutFormOfStudy = dataAboutFormOfStudy;
        }


        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string DataAboutFormOfStudy { get; set; }
        public string BirthdayDate { get; set; }


        private int GetNextId()
        {
            return ++_currentId;
        }

        public override string ToString()
        {
            return string.Format("{0}  -  {1}  -  {2}  -  {3}", StudentId, StudentName,
                BirthdayDate, DataAboutFormOfStudy);
        }
    }
}