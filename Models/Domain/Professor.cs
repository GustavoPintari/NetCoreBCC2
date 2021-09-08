using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreBCC2.Models.Domain
{
    public class Professor
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public Disciplina disciplina { get; set; }
        public int disciplinaID { get; set; }
        public string cidade { get; set; }
        public string endereco { get; set; }
        public int contato { get; set; }
        public string email { get; set; }

        public ICollection<Disciplina> disciplinas { get; set; }
    }
}
