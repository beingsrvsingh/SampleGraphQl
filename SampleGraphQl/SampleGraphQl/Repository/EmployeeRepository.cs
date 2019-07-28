using Microsoft.EntityFrameworkCore;
using SampleGraphQl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleGraphQl.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly TestdbContext _context;
        public EmployeeRepository(TestdbContext context)
        {
            _context = context;
        }

        public Task<List<Employee>> GetEmployees()
        {
            return _context.Employee.ToListAsync();
        }
    }
}
