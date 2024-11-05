using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IFSPStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStoreRepository.Mapping
{
    internal class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder) 
        {
            builder.ToTable("Produto");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(255);
            builder.Property(x => x.Preco);
            builder.Property(x => x.Quantidade);
            builder.Property(x => x.DataCompra);
            builder.Property(x=> x.UnidadeVenda)
                .HasMaxLength(255);

        }
    }
}
