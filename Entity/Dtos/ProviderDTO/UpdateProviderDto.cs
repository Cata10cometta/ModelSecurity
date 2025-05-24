using Entity.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.ProviderDTO
{
    public class UpdateProviderDto : BaseDto
    {
        public string CompanyName { get; set; }
        public string NIT { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
