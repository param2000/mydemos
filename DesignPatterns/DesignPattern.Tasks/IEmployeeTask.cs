using System.Collections.Generic;

namespace DesignPattern.Tasks
{
    public interface IEmployeeTask
    {
        IList<IEmployee> GetAllEmployees();
    }
}