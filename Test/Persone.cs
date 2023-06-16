using System;
namespace Test
{
	public class Persone : Human
	{
		public Persone(string firstName, string lastName, DateTime dateOfBirth) : base(firstName,lastName,dateOfBirth)
		{

		}

		
		public override string ToString()
		{
			return $"   Person \nFirstName: {FirstName}\nLastname: {LastName}\nDateOfBirthday: {DateOfBirth}";
		}
	}
}

