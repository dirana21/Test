using System;
namespace Test
{
	public class Student : Human
	{
		public int _ID { get; set; }
        public Student(string firstName, string lastName, DateTime dateOfBirth,int id) : base(firstName, lastName, dateOfBirth)
        {
            _ID = id;
        }
        public override string ToString()
        {
            return $"\nFirstName: {FirstName}\nLastname: {LastName}\nDateOfBirthday: {DateOfBirth}\nID: {_ID}";
        }
    }
}

