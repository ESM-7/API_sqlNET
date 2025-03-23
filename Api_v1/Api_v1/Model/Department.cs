using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_v1.Models
{
    [Table("Department", Schema = "HumanResources")]
    public class Department
    {
        [Key]
        public short DepartmentID { get; set; } // Clave primaria

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } // Nombre del departamento

        [Required]
        [MaxLength(50)]
        public string GroupName { get; set; } // Nombre del grupo

        [Required]
        public DateTime ModifiedDate { get; set; } // Fecha de última modificación
    }
}
