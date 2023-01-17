using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ControlMovie.Models;

namespace ControlMovie.Data
{
    public class ControlMovieContext : DbContext
    {
        public ControlMovieContext (DbContextOptions<ControlMovieContext> options)
            : base(options)
        {
        }

        public DbSet<ControlMovie.Models.Movie> Movie { get; set; } = default!;

        public DbSet<ControlMovie.Models.Aluno> Aluno { get; set; }
    }
}
