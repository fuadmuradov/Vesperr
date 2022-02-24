using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vesperr.Models
{
    public class Mycontext : DbContext
    {
        public Mycontext(DbContextOptions<Mycontext> options) : base(options) { }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutCount> AboutCounts { get; set; }
        public DbSet<ClientSection> ClientSections { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Heroheader> Heroheaders { get; set; }
        public DbSet<MoreServiceSection> MoreServiceSections { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<ServiceSection> ServiceSections { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Testimional> Testimionals { get; set; }

    }
}
