using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace FilmesAPI.Data
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> opt) : base(opt)
        {

        }

        public DbSet<Filme> Filmes { get; set; }

        internal Filme FirstOrDefault(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
