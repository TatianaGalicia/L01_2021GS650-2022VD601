using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace L01_2021GS650_2022VD601.models
{
    public class blogDBContext: DbContext
    {
        public blogDBContext(DbContextOptions<blogDBContext> options) : base(options)
        {

        }
        public DbSet<usuarios> usuarios { get; set; }
        public DbSet<comentarios> comentarios { get; set; }
        public DbSet<calificaciones> calificaciones { get; set; }

    }
  
    
  

}

