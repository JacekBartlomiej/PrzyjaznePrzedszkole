using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrzyjaznePrzedszkole.Data.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Pupil> Pupils { get; set; }
    }
}
