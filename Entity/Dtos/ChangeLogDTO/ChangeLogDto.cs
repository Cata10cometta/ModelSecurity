using Entity.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.ChangeLogDTO
{
    public class ChangeLogDto : BaseDto
    {
        public int UserId { get; set; }
        public string Action { get; set; } // Create, Update, Delete
        public string EntityType { get; set; } // Module, Form, etc.
        public string EntityName { get; set; } // Name of the entity (e.g., Module, Form)
        public string EntityId { get; set; }
        public string OldValues { get; set; }
        public string NewValues { get; set; }
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
    }
   
}
