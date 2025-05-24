using Entity.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class Country : BaseModel
    {
        public string Name { get; set; }
        public IEnumerable<Deparment> Deparments { get; set; }

    }
}
