using Entity.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.PermissionDTO
{
    class DeleteLogiPermissionDto : BaseDto
    {
        /// <summary>
        /// Constructor para inicializar el estado del permiso a falso (eliminado lógicamente)
        /// </summary>
        public DeleteLogiPermissionDto()
        {
            Status = false;
        }

        // Aquí puedes agregar más propiedades específicas si es necesario
    }
}
