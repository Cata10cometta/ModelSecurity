using Entity.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.PermissionDTO
{
    class UpdatePermissionDto : BaseDto
    {
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string Type { get; set; } = null!;
    }
}
