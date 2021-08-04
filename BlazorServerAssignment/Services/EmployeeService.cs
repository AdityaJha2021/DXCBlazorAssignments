using BlazorServerAssignment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerAssignment.Services
{
    public class EmployeeService : IService<Employee, int>
    {
        private readonly DXCCompanyBlazorContext context;

        public EmployeeService(DXCCompanyBlazorContext context)
        {
            this.context = context;
        }
        public Task<Employee> CreateAsync(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetAsync()
        {
            return await context.Employees.ToListAsync();
        }

        public Task<Employee> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> UpdateAsync(int id, Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
