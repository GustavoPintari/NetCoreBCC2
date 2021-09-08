using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreBCC2.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Serie> Series { get; set; }

    }
}
