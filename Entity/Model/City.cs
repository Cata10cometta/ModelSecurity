using Entity.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class City : BaseModel
    {
        public string Name { get; set; }
        public int DeparmentId { get; set; }
        public Deparment Deparment { get; set; }


        public IEnumerable<Neighborhood> Neighborhoods { get; set; }
        public IEnumerable<Provider> Providers { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
    }
}
