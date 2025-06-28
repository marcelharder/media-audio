using data.models;
using Microsoft.EntityFrameworkCore;

namespace media_audio.Interfaces;

 public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<AlbumDetails> Albums { get; set; }
        public DbSet<CDDetails> CDS { get; set; }
        public DbSet<TrackDetails> Tracks { get; set; }
      

        protected override void OnModelCreating(ModelBuilder builder)
        {
           
        }


    }
