using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreBCC2.Models.Domain
{
    public class Disciplina
    {
        public int ID { get; set; }
        public Serie serie { get; set; }
        public int serieID { get; set; }
        public Professor professor { get; set; }
        public int professorID { get; set; }
        public string descricao { get; set; }

        public ICollection<Nota> notas { get; set; }


    }
}
