using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrzyjaznePrzedszkole.Data.Entities
{
    public class Gallery
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public Teacher Author { get; set; }
        public ICollection<Group> Audience { get; set; }
        public ICollection<Image> Images { get; set; }
    }
}
