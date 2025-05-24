using Entity.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.RolFormPermission
{
    public class RolFormPermissonDTO : BaseDto
    {
        public int FormId { get; set; }
        public int PermissionId { get; set; }
    }
}
