using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNET_CORE.Models;

namespace ASPNET_CORE.DataBase {
    public class ApplicationDBContext : DbContext {

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }


        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseLazyLoadingProxies();
        }

        //para alterar as propriedades do banco
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Produto>().Property(p => p.Nome);
        }
    }
}
