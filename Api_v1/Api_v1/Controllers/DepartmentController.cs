using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api_v1.Models;
using Api_v1.Repositories;

namespace Api_v1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Department>>> GetDepartments()
        {
            var departments = await _departmentRepository.GetDepartmentsAsync();
            return Ok(departments);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Department>> GetDepartmentById(short id)
        {
            var department = await _departmentRepository.GetDepartmentByIdAsync(id);
            if (department == null) return NotFound();
            return Ok(department);
        }

        //[HttpPost]
        //public async Task<IActionResult> AddDepartment([FromBody] Department department)
        //{
        //    await _departmentRepository.AddDepartmentAsync(department);
        //    return CreatedAtAction(nameof(GetDepartmentById), new { id = department.DepartmentID }, department);
        //}

        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateDepartment(short id, [FromBody] Department department)
        //{
        //    if (id != department.DepartmentID) return BadRequest();
        //    await _departmentRepository.UpdateDepartmentAsync(department);
        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteDepartment(short id)
        //{
        //    await _departmentRepository.DeleteDepartmentAsync(id);
        //    return NoContent();
        //}
    }
}
