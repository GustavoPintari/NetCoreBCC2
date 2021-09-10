using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreBCC2.Models.Domain
{
    [Table("Series")]
    public class Serie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [StringLength(10, ErrorMessage = "Campo Série inválido")]
        [Required(ErrorMessage = "Campo Série obrigatório")]
        [Display(Name = "Série")]
        public string descricao { get; set; }

        public ICollection<Aluno> alunos { get; set; }
        public ICollection<Disciplina> disciplinasSerie { get; set; }
    }
}
