using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCoreBCC2.Models.Domain;

namespace WebCoreBCC2.Models.Mapping
{
    public class ProfessorMap : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).ValueGeneratedOnAdd();
            builder.Property(p => p.nome).HasMaxLength(40).IsRequired();
            builder.Property(p => p.idade).HasColumnType("Int").IsRequired();
            builder.Property(p => p.cidade).HasMaxLength(25).IsRequired();
            builder.Property(p => p.endereco).HasMaxLength(25).IsRequired();
            builder.Property(p => p.contato).HasColumnType("Int").HasMaxLength(12).IsRequired();
            builder.Property(p => p.email).HasMaxLength(35);

            builder.HasMany(p => p.disciplinasProfessor).WithOne(p => p.professor).HasForeignKey(p => p.professorID).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Professores");
        }
    }
}
