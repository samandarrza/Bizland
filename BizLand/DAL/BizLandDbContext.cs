using BizLand.Models;
using Microsoft.EntityFrameworkCore;

namespace BizLand.DAL
{
    public class BizLandDbContext : DbContext
    {
        public BizLandDbContext(DbContextOptions<BizLandDbContext> options) : base(options)
        {

        }
        public DbSet<Feature> Features { set; get; }
        public DbSet<Service> Services { set; get; }
        public DbSet<Testimonial> Testimonials { set; get; }  
    }
}
