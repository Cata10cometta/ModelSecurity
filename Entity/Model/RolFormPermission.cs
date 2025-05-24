using Entity.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class RolFormPermission : BaseModel
    {
        public int RolId { get; set; }
        public Rol Rol { get; set; } = new Rol();

        public int PermissionId { get; set; }
        public int FormId { get; set; }
        public Permission Permission { get; set; } = new Permission();
        public Form Form { get; set; } = new Form();
    }
}
