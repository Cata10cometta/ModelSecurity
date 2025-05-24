using Entity.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.Form
{
    public class FormDTO : BaseDto
    {
        public string Name { get; set; } = null!;
        public string Url { get; set; } = null!;
        public string Code { get; set; } = null!;
        
    }
}
