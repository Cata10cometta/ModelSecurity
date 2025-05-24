using Entity.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.EmployeeDTO
{
    public class DeleteLogiEmployeeDto : BaseDto
    {
        /// <summary>
        /// Constructor para inicializar el estado del empleado a falso (eliminado lógicamente)
        /// </summary>
        public DeleteLogiEmployeeDto()
        {
            Status = false; // Indica que el empleado está eliminado lógicamente
        }
        /// <summary>
        /// Identificador del empleado a eliminar
        /// </summary>
        public int EmployeeId { get; set; }
    }
}
