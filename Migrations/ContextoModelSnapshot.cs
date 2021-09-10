﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebCoreBCC2.Models;

namespace WebCoreBCC2.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebCoreBCC2.Models.Domain.Aluno", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RA")
                        .HasMaxLength(7)
                        .HasColumnType("int");

                    b.Property<int?>("SerieID")
                        .HasColumnType("int");

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("contato")
                        .HasMaxLength(12)
                        .HasColumnType("Int");

                    b.Property<string>("email")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("endereco")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("idade")
                        .HasColumnType("Int");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("ID");

                    b.HasIndex("SerieID");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("WebCoreBCC2.Models.Domain.Disciplina", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("professorID")
                        .HasColumnType("int");

                    b.Property<int>("serieID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("professorID");

                    b.HasIndex("serieID");

                    b.ToTable("Disciplinas");
                });

            modelBuilder.Entity("WebCoreBCC2.Models.Domain.Nota", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("alunoID")
                        .HasColumnType("int");

                    b.Property<int>("disciplinaID")
                        .HasColumnType("int");

                    b.Property<float>("valor")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.HasIndex("alunoID");

                    b.HasIndex("disciplinaID");

                    b.ToTable("Notas");
                });

            modelBuilder.Entity("WebCoreBCC2.Models.Domain.Professor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("contato")
                        .HasMaxLength(12)
                        .HasColumnType("Int");

                    b.Property<string>("email")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("endereco")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("idade")
                        .HasColumnType("Int");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("ID");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("WebCoreBCC2.Models.Domain.Serie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("WebCoreBCC2.Models.Domain.Aluno", b =>
                {
                    b.HasOne("WebCoreBCC2.Models.Domain.Serie", null)
                        .WithMany("alunos")
                        .HasForeignKey("SerieID");
                });

            modelBuilder.Entity("WebCoreBCC2.Models.Domain.Disciplina", b =>
                {
                    b.HasOne("WebCoreBCC2.Models.Domain.Professor", "professor")
                        .WithMany("disciplinasProfessor")
                        .HasForeignKey("professorID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("WebCoreBCC2.Models.Domain.Serie", "serie")
                        .WithMany("disciplinasSerie")
                        .HasForeignKey("serieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("professor");

                    b.Navigation("serie");
                });

            modelBuilder.Entity("WebCoreBCC2.Models.Domain.Nota", b =>
                {
                    b.HasOne("WebCoreBCC2.Models.Domain.Aluno", "aluno")
                        .WithMany("notas")
                        .HasForeignKey("alunoID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("WebCoreBCC2.Models.Domain.Disciplina", "disciplina")
                        .WithMany("notas")
                        .HasForeignKey("disciplinaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("aluno");

                    b.Navigation("disciplina");
                });

            modelBuilder.Entity("WebCoreBCC2.Models.Domain.Aluno", b =>
                {
                    b.Navigation("notas");
                });

            modelBuilder.Entity("WebCoreBCC2.Models.Domain.Disciplina", b =>
                {
                    b.Navigation("notas");
                });

            modelBuilder.Entity("WebCoreBCC2.Models.Domain.Professor", b =>
                {
                    b.Navigation("disciplinasProfessor");
                });

            modelBuilder.Entity("WebCoreBCC2.Models.Domain.Serie", b =>
                {
                    b.Navigation("alunos");

                    b.Navigation("disciplinasSerie");
                });
#pragma warning restore 612, 618
        }
    }
}
