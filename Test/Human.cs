using System;
namespace Test
{
	public abstract class Human
	{
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime DateOfBirth { get; }

        protected Human(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        public static Human Create(string firstName, string lastName, DateTime dateOfBirth, int? studentID = null,int? teacherID = null)
        {
            if (studentID.HasValue)
            {
                return new Student(firstName, lastName, dateOfBirth, studentID.Value);
            }
            else if (teacherID.HasValue && studentID == null)
            {
                return new Teacher(firstName, lastName, dateOfBirth, teacherID.Value);
            }
            else
            {
                return new Persone(firstName, lastName, dateOfBirth);
            }
        }
    }
}

