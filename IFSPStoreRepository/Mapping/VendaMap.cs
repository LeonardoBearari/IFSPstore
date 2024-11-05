using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IFSPStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IFSPStoreRepository.Mapping
{
    internal class VendaMap
    {
        public void Configure(EntityTypeBuilder<VendaItem> builder) {
            builder.ToTable("VendaItem");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id);
            builder.Property(x => x.Quantidade)
                .IsRequired();

            builder.Property(x => x.ValorTotal)
                .IsRequired();
            
            builder.Property(x => x.ValorUnitario)
                .IsRequired();

            builder.HasOne(x => x.Produto);
        }
    }
}
