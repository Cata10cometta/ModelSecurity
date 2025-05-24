using Entity.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.CityDTO
{
    public class UpdateCityDto : BaseDto
    {
        public string Name { get; set; }
        public int DeparmentId { get; set; }
    }
    
}
