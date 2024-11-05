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
    internal class GrupoMap : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            builder.ToTable("Lasanha");
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .HasColumnName("EquipeCÃO")
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
