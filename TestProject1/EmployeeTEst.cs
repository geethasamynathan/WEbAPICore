using System;
using Xunit;
using Moq;
using TestingWepAPI_MOCK.Models;
using TestingWepAPI_MOCK.Services;
using TestingWepAPI_MOCK.Controllers;
namespace TestProject1
{
    public class EmployeeTEst
    {
        public Mock<IEmployeeRepository> mock = new Mock<IEmployeeRepository>();
        [Fact]
        public async void GetEmployeeById()
        {
            mock.Setup(p => p.GetEmployeeById(1)).ReturnsAsync("JM");
            EmployeeController emp = new EmployeeController(mock.Object);
            string result =await emp.GetEmployeById(1);
            Assert.Equal("JM", result);

        }
        [Fact]
        public async void GetEmployeedetails()
        {
            var emptemp = new Employee()
            {
                Id = 1,
                Name = "Jonathan",
                Desgination = "Sr.DEv"

            };
            mock.Setup(p => p.GetEmployeeDetails(1)).ReturnsAsync(emptemp);
            EmployeeController employee = new EmployeeController(mock.Object);
            var resultobj =await employee.GetEmployeeDetails(1);
            Assert.True(emptemp.Equals(resultobj));
        }
    }
}
