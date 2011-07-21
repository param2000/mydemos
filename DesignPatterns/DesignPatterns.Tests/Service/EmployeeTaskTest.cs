using System;
using System.Collections.Generic;
using DesignPattern.Tasks;
using MbUnit.Framework;

namespace DesignPatterns.Tests.Service
{
    [TestFixture]
    public class EmployeeTaskTest
    {
        [Test]
        public void GetAllEmployees_ShouldGetAllEmployees()
        {
            IEmployeeTask task = new EmployeeTask();
            IList<IEmployee> list = task.GetAllEmployees();
            Assert.IsTrue(list.Count > 0);

            foreach (Employee employee in list)
            {
                Console.WriteLine(employee.FirstName);
                
            }
        }        
    }
}