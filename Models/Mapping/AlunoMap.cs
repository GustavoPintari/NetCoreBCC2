using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCoreBCC2.Models.Domain;

namespace WebCoreBCC2.Models.Mapping
{
    public class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).ValueGeneratedOnAdd();
            builder.Property(p => p.RA).HasMaxLength(7).IsRequired();
            builder.HasIndex(p => p.RA).IsUnique();
            builder.Property(p => p.nome).HasMaxLength(40).IsRequired();
            builder.Property(p => p.idade).HasColumnType("Int").IsRequired();
            builder.Property(p => p.cidade).HasMaxLength(25).IsRequired();
            builder.Property(p => p.endereco).HasMaxLength(25).IsRequired();
            builder.Property(p => p.contato).HasColumnType("Int").HasMaxLength(12).IsRequired();
            builder.Property(p => p.email).HasMaxLength(35);

            builder.HasMany(p => p.notas).WithOne(p => p.aluno).HasForeignKey(p => p.alunoID).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Alunos");
        }
    }
}
