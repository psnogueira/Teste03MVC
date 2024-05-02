using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mini_Mundo.Models;

namespace Mini_Mundo.Data
{
    public class LojaImpactaContext : DbContext
    {
        public LojaImpactaContext (DbContextOptions<LojaImpactaContext> options)
            : base(options)
        {
        }

        public DbSet<Mini_Mundo.Models.Produto> Produto { get; set; } = default!;
        public DbSet<Mini_Mundo.Models.Funcionario> Funcionario { get; set; } = default!;
    }
}
