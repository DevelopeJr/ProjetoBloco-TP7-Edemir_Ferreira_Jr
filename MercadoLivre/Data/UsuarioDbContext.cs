using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MercadoLivre.Models;

namespace MercadoLivre.Data
{
    public class UsuarioDbContext : DbContext
    {
        public UsuarioDbContext (DbContextOptions<UsuarioDbContext> options)
            : base(options)
        {
        }

        public DbSet<MercadoLivre.Models.Usuario> Usuario { get; set; }
    }
}
