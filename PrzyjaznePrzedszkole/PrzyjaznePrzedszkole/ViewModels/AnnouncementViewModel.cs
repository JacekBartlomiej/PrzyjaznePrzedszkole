using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrzyjaznePrzedszkole.ViewModels
{
    public class AnnouncementViewModel
    {
        public string Title { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public string Audience { get; set; }
        
    }
}
