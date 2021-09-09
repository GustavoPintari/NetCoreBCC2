using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreBCC2.Models.Domain
{
    public class Serie
    {
        public int ID { get; set; }
        public string descricao { get; set; }
        public ICollection<Aluno> alunos { get; set; }
        public ICollection<Disciplina> disciplinasSerie { get; set; }
    }
}
