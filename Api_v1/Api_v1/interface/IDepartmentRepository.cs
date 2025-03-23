using System.Collections.Generic;
using System.Threading.Tasks;
using Api_v1.Models;

namespace Api_v1.Repositories
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartmentsAsync();
        Task<Department> GetDepartmentByIdAsync(short departmentId);
        //Task AddDepartmentAsync(Department department);
        //Task UpdateDepartmentAsync(Department department);
        //Task DeleteDepartmentAsync(short departmentId);
    }
}
