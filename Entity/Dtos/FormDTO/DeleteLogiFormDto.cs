using Entity.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.FormDTO
{
    public class DeleteLogiFormDto : BaseDto
    {
        /// <summary>
        /// Constructor para inicializar el estado del formulario a falso (eliminado lógicamente)
        /// </summary>
        public DeleteLogiFormDto()
        {
            Status = false; // Indica que el formulario está eliminado lógicamente
        }
        /// <summary>
        /// Identificador del formulario a eliminar
        /// </summary>
        public int FormId { get; set; }
    }
}
