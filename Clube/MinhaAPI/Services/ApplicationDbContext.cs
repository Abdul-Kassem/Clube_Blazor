using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using MinhaAPI.Controllers;
using MinhaAPI.Models;

namespace MinhaAPI.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Associado> Associado { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Dependente> Dependente { get; set; }
        public DbSet<Convidado> Convidado { get; set; }
        public DbSet<EspacoLocavel> EspacoLocavel { get; set; }
        public DbSet<Evento> Evento { get; set; }
    }
}
