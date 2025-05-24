using Entity.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.ClientDTO
{
    public class UpdateClientDto : BaseDto
    {
        public string Name { get; set; }
        public string DocumentIdentity { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int UserId { get; set; }
        public int NeighborhoodId { get; set; }
    
    }
}
