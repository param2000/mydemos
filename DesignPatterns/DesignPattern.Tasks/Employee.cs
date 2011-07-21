using System;

namespace DesignPattern.Tasks
{
    public class Employee:IEmployee
    {
        private string _firstName;
        private string _lastName;
        private DateTime _birthdate;

        public Employee(string firstName, string lastName, DateTime birthdate)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthdate = birthdate;
        }

        public string FirstName
        {
            get { return _firstName; }
        }

        public string LastName
        {
            get { return _lastName; }
        }

        public DateTime Birthdate
        {
            get { return _birthdate; }
        }
    }
}