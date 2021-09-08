using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreBCC2.Models.Domain
{
    public class Nota
    {
        public int ID { get; set; }
        public float valor { get; set; }
        public Disciplina disciplina { get; set; }
        public int disciplinaID { get; set; }
        public Aluno aluno { get; set; }
        public int alunoID { get; set; }

    }
}
