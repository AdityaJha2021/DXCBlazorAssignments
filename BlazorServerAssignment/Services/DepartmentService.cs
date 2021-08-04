using BlazorServerAssignment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerAssignment.Services
{
    public class DepartmentService : IService<Department, int>
    {
        private readonly DXCCompanyBlazorContext context;

        public DepartmentService(DXCCompanyBlazorContext context)
        {
            this.context = context;
        }
        public async Task<Department> CreateAsync(Department entity)
        {
            try
            {
                var result = await context.Departments.AddAsync(entity);
                await context.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                var result = await context.Departments.FindAsync(id);
                if (result == null) throw new Exception("Delete Failed as Department not found");
                context.Departments.Remove(result);
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Department>> GetAsync()
        {
            try
            {
                return await context.Departments.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Department> GetAsync(int id)
        {
            try
            {
                var result = await context.Departments.FindAsync(id);
                if (result == null) throw new Exception("Department not found");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Department> UpdateAsync(int id, Department entity)
        {
            try
            {
                var result = await context.Departments.FindAsync(id);
                if (result == null) throw new Exception("Update Failed as Department not found");
                result.DeptName = entity.DeptName;
                result.Location = entity.Location;
                await context.SaveChangesAsync();
                return entity;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
