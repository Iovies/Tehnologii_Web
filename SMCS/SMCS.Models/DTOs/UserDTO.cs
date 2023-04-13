using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.Models.DTOs
{
    public class UserDTO
    {
        public Guid ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string IDNP { get; set; }
        public string Faculty { get; set; }
        public string Specialty { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
