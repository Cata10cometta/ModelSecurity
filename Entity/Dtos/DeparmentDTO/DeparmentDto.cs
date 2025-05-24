using Entity.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.DeparmentDTO
{
    public class DeparmentDTO : BaseDto
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
    }
    
}
