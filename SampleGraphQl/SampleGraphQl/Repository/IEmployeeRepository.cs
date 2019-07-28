using SampleGraphQl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleGraphQl.Repository
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetEmployees();
    }
}
