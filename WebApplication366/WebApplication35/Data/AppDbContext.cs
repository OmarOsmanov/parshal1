using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<About> Abouts  { get; set; }
        public DbSet<HomeAbout> HomeAbouts { get; set; }

        public DbSet<OurData> OurDatas { get; set; }

        public DbSet<OurCustemrs> OurCustemrs { get; set; }

        public DbSet<OurSosial> OurSosials { get; set; }

        public DbSet<OurTeams> OurTeams { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<Prodcts> Prodcts { get; set; }

        public DbSet<Rewies> Rewies { get; set; }

        public DbSet<SendMessage> SendMessages { get; set; }

        public DbSet<Services> Services { get; set; }
        public DbSet<Sosial> Sosials { get; set; }




    }
}
