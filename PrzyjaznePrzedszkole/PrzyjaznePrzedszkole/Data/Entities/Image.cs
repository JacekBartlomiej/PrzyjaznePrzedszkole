using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrzyjaznePrzedszkole.Data.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public byte[] File { get; set; }
        public string Caption { get; set; }
    }
}
