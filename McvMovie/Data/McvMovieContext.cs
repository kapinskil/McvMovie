using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace McvMovie.Models
{
    public class McvMovieContext : DbContext
    {
        public McvMovieContext (DbContextOptions<McvMovieContext> options)
            : base(options)
        {
        }

        public DbSet<McvMovie.Models.Movie> Movie { get; set; }
    }
}
