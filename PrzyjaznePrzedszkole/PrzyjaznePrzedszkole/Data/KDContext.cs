using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrzyjaznePrzedszkole.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace PrzyjaznePrzedszkole.Data
{
    public class KDContext: DbContext
    {
        public KDContext(DbContextOptions<KDContext> options): base(options) { }

        public DbSet<Announcement> Announcements { get; set; }
    }
}
