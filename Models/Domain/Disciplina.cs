using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreBCC2.Models.Domain
{
    [Table("Disciplinas")]
    public class Disciplina
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Nome da Disciplina")]
        [Required(ErrorMessage = "Campo Nome da Disciplina é obrigatório")]
        public string descricao { get; set; }

        [Display(Name = "Série")]
        public Serie serie { get; set; }
        [ForeignKey("Serie")]
        public int serieID { get; set; }

        [Display(Name = "Professor")]
        public Professor professor { get; set; }
        [ForeignKey("Professor")]
        public int professorID { get; set; }

        public ICollection<Nota> notas { get; set; }


    }
}
