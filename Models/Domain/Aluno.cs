using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreBCC2.Models.Domain
{
    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo RA é obrigatório")]
        [Display(Name = "RA")]
        public int RA { get; set; }

        [StringLength(40, ErrorMessage = "Tamanho de Nome inválido", MinimumLength = 5)]
        [Required(ErrorMessage = "Campo Nome obrigatório")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Range(minimum: 12, maximum: 20, ErrorMessage = "Idade entre 12 e 20 anos")]
        [Required(ErrorMessage = "Campo Idade obrigatório")]
        [Display(Name = "Idade")]
        public int idade { get; set; }

        [StringLength(25, ErrorMessage = "Campo Cidade inválido")]
        [Required(ErrorMessage = "Campo Cidade obrigatório")]
        [Display(Name = "Cidade")]
        public string cidade { get; set; }

        [StringLength(25, ErrorMessage = "Campo Endereço inválido")]
        [Required(ErrorMessage = "Campo Endereço obrigatório")]
        [Display(Name = "Endereço")]
        public string endereco { get; set; }

        [Required(ErrorMessage = "Campo Telefone obrigatório")]
        [Display(Name = "Telefone")]
        public int contato { get; set; }

        [StringLength(35, ErrorMessage = "Campo E-Mail inválido")]
        [Display(Name = "E-Mail")]
        [RegularExpression("^[a-zA-Z0-9_+-]+[a-zA-Z0-9._+-]*[a-zA-Z0-9_+-]+@[a-zA-Z0-9_+-]+[a-zA-Z0-9._+-]*[.]{1,1}[a-zA-Z]{2,}$", ErrorMessage = "E-Mail inválido")]
        public string email { get; set; }

        public ICollection<Nota> notas { get; set; }
    }
}
