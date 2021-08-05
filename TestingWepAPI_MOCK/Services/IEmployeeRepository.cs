using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingWepAPI_MOCK.Models;

namespace TestingWepAPI_MOCK.Services
{
    public interface IEmployeeRepository
    {
        Task<string> GetEmployeeById(int id);
        Task<Employee> GetEmployeeDetails(int empid);
    }
}
