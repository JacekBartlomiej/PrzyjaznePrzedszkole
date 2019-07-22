using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrzyjaznePrzedszkole.Data.Entities
{
    public class Guardian
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<Pupil> Children { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
    }
}
