using System;
namespace Test
{
	public class Teacher : Human, IPrintable
    {
        public int _teacherID { get; set; }
        public Teacher(string firstName, string lastName, DateTime dateOfBirth, int id) : base(firstName, lastName, dateOfBirth)
        {
            _teacherID = id;
        }
        public override string ToString()
        {
            return $"    Teacher \nFirstName: {FirstName}\nLastname: {LastName}\nDateOfBirthday: {DateOfBirth}\nID: {_teacherID}";
        }
        string IPrintable.ToString()
        {
            return ToString();
        }
    }
}

