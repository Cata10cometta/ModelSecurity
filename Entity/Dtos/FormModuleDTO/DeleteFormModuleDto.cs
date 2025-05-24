using Entity.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.FormModuleDTO
{
    public class DeleteFormModuleDto : BaseDto
    {
        /// <summary>
        /// Constructor para inicializar el estado del módulo a falso (eliminado lógicamente)
        /// </summary>
        public DeleteFormModuleDto()
        {
            Status = false; // Indica que el módulo está eliminado lógicamente
        }

        /// <summary>
        /// Identificador del módulo de formulario a eliminar
        /// </summary>
        public int FormModuleId { get; set; }
    }
}
