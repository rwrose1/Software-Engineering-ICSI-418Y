using Microsoft.EntityFrameworkCore;

namespace NazdaqSearch.Models
{
    public class NazdaqDataContext : DbContext
    {
        public NazdaqDataContext (DbContextOptions<NazdaqDataContext> options)
            : base(options)
        {
        }

        public DbSet<NazdaqSearch.Models.NazdaqData> NazdaqData { get; set; }
    }
}