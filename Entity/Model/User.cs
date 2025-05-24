using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Model.Base;

namespace Entity.Model
{
    public class User : BaseModel
    {
        public  string Email { get; set; }
        public  string Password { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
        public  IEnumerable<RolUser> RolUsers { get; set; }
        public IEnumerable<Provider> Providers { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<Client> Clients { get; set; }
    }
}
