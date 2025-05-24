using Entity.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class FormModule : BaseModel
    {
        public int FormId { get; set; }
        public int ModuleId { get; set; }
        public Form Form { get; set; } = new Form();
        public Module Module { get; set; } = new Module();


    }
}
