using Microsoft.EntityFrameworkCore;
using IFSPStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFSPStoreRepository.Mapping;

namespace IFSPStoreRepository.Context
{
    internal class MySqlContext : DbContext
    {
        public MySqlContext (DbContextOptions<MySqlContext> options): base(options) { 
            Database.EnsureCreated();
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<VendaItem> VendaItens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Grupo>(new GrupoMap().Configure);
            modelBuilder.Entity<Produto>(new ProdutoMap().Configure);
            modelBuilder.Entity<VendaItem>(new VendaMap().Configure);



        }

    }
}
