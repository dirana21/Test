using System;
namespace Test
{
	public class Student : Human
	{
		public int _studentID { get; set; }
        public Student(string firstName, string lastName, DateTime dateOfBirth,int id) : base(firstName, lastName, dateOfBirth)
        {
            _studentID = id;
        }
        public override string ToString()
        {
            return $"   Student \nFirstName: {FirstName}\nLastname: {LastName}\nDateOfBirthday: {DateOfBirth}\nID: {_studentID}";
        }
    }
}

