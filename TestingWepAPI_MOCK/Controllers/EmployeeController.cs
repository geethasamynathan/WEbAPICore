using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingWepAPI_MOCK.Models;
using TestingWepAPI_MOCK.Services;
namespace TestingWepAPI_MOCK.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        [HttpGet]
        public async Task<string> GetEmployeById(int empid)
        {
            var result = await _employeeRepository.GetEmployeeById(empid);
            return result;
        }
        [HttpGet]
        public async Task<Employee> GetEmployeeDetails(int id)
        {
            Employee employee = await _employeeRepository.GetEmployeeDetails(id);
            return employee;
        }
        
    }
}
