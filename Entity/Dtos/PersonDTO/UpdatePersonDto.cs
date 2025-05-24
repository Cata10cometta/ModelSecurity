using Entity.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.PersonDTO
{
    public class UpdatePersonDto : BaseDto
    {
        public string FirstName { get; set; } = null!;
        public string? SecondName { get; set; } = null!;
        public string FirstSurName { get; set; } = null!;
        public string? SecondSurName { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Address { get; set; } = null!;
    }
}
