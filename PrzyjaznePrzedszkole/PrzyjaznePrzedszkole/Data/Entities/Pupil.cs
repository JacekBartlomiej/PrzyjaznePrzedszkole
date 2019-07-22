using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrzyjaznePrzedszkole.Data.Entities
{
    public class Pupil
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<Guardian> Guardians { get; set; }
        public Group Group { get; set; }
    }
}
