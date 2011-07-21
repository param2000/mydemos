using System;

namespace DesignPattern.Tasks
{
    public interface IEmployee
    {
        string FirstName{get;}
        string LastName { get; }                    
        DateTime Birthdate { get; }
    }
}
