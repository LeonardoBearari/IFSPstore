using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStoreRepository.Mapping
{
    public class CidadeMap : IEntityTypeConfiguration<Cidade>
    {
        public void Configure()
        {

        }

        void IEntityTypeConfiguration<Cidade>.Configure(EntityTypeBuilder<Cidade> builder)
        {
            throw new NotImplementedException();
        }
    }
}
