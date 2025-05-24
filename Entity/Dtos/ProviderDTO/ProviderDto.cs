using Entity.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.ProviderDTO
{
    public class ProviderDTO : BaseDto
    {
        public string CompanyName { get; set; }
        public string NIT { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public int UserId { get; set; }


    }
}
