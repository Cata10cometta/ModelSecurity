using Entity.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class Permission : BaseModel
    {
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string Type { get; set; } = null!;

        public IEnumerable<RolFormPermission> RolFormPermissions { get; set; }

    }
}
