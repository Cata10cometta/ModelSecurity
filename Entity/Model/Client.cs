using Entity.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class Client : BaseModel
    {
        public string Name { get; set; }
        public string DocumentIdentity { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }


        public int UserId { get; set; }
        public User User { get; set; }

        public int NeighborhoodId { get; set; }
        public Neighborhood Neighborhood { get; set; }

    }
}
