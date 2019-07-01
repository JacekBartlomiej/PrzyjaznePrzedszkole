using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PrzyjaznePrzedszkole.Data.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PrzyjaznePrzedszkole.Data
{
    public class KDSeeder
    {
        private readonly KDContext _ctx;
        private readonly IHostingEnvironment _hosting;

        public KDSeeder(KDContext ctx, IHostingEnvironment hosting)
        {
            _ctx = ctx;
            _hosting = hosting;
        }

        public void Seed()
        {
            _ctx.Database.EnsureCreated();

            if (!_ctx.Announcements.Any())
            {
                var filepath = Path.Combine(_hosting.ContentRootPath, "Data/announcements.json");
                var json = File.ReadAllText(filepath);
                var announcements = JsonConvert.DeserializeObject<IEnumerable<Announcement>>(json, new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" });

                _ctx.Announcements.AddRange(announcements);
                _ctx.SaveChanges();
            }
        }
    }
}
