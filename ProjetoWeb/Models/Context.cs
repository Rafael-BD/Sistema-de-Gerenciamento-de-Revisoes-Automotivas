using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoWeb.Models;

namespace ProjetoWeb.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options): base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Veiculo> Veiculo { get; set; }
        public DbSet<Agendamento> Agendamento { get; set; }
    }
}
