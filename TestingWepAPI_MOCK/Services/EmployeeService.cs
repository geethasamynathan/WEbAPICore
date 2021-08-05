using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingWepAPI_MOCK.Models;

namespace TestingWepAPI_MOCK.Services
{
    public class EmployeeService:IEmployeeRepository
    {
        private readonly AppDbContext _appDbContext;
        public EmployeeService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<Employee> GetEmployeeDetails(int id)
        {
            Employee employee = await _appDbContext.Employees.FirstOrDefaultAsync(e => e.Id == id);
            return employee;
        }
        public async Task<string> GetEmployeeById(int id)
        {
          var emp = await _appDbContext.Employees.Where(e => e.Id == id).Select(n => n.Name).FirstOrDefaultAsync();
            return emp;
        }

        
    }
}
