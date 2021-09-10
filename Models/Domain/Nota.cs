using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreBCC2.Models.Domain
{
    [Table("Notas")]
    public class Nota
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [DisplayFormat(DataFormatString = "0:F2", ApplyFormatInEditMode = true)]
        [Display(Name = "Valor da Nota")]
        [Required(ErrorMessage = "Campo Nota é obrigatório")]
        [Range(minimum: 0, maximum: 10, ErrorMessage = "A Nota deve estar com o valor entre 0 e 10")]
        public float valor { get; set; }

        [Display(Name = "Disciplina")]
        public Disciplina disciplina { get; set; }
        [ForeignKey("Disciplina")]
        public int disciplinaID { get; set; }

        [Display(Name = "Aluno")]
        public Aluno aluno { get; set; }
        [ForeignKey("Aluno")]
        public int alunoID { get; set; }

    }
}
