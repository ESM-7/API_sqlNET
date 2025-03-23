using Microsoft.EntityFrameworkCore;
using Api_v1.Models;
using Api_v1.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_v1.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _context;

        public DepartmentRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Department>> GetDepartmentsAsync()
        {
            return await _context.Departments.AsNoTracking().ToListAsync();
        }

        public async Task<Department> GetDepartmentByIdAsync(short departmentId)
        {
            return await _context.Departments.FindAsync(departmentId);
        }

        //public async Task AddDepartmentAsync(Department department)
        //{
        //    await _context.Departments.AddAsync(department);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task UpdateDepartmentAsync(Department department)
        //{
        //    _context.Departments.Update(department);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task DeleteDepartmentAsync(short departmentId)
        //{
        //    var department = await GetDepartmentByIdAsync(departmentId);
        //    if (department != null)
        //    {
        //        _context.Departments.Remove(department);
        //        await _context.SaveChangesAsync();
        //    }

        //}
    }
}

