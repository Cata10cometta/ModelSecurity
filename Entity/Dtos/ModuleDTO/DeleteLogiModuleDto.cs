using Entity.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.ModuleDTO
{
    public class DeleteLogiModuleDto : BaseDto
    {
        /// <summary>
        /// Constructor para inicializar el estado del módulo a inactivo
        /// </summary>
        public DeleteLogiModuleDto()
        {
            Status = false; // Marca el módulo como inactivo
        }

        // Aquí puedes agregar más propiedades específicas si es necesario
    }
}
