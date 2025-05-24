using Entity.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class Employee : BaseModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string DocumentIdentity { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }

    }
}
