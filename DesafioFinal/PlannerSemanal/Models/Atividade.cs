using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlannerSemanal.Models
{
    public class Atividade
    {
        [Key]
        public int AtividadeId { get; set; }

        [Required(ErrorMessage = "{0} é um campo obrigatório!")]
        [StringLength(50, ErrorMessage = "O nome da atividade deve conter, no máximo, 50 caracteres!")]
        public string Nome { get; set; }

        public string Data { get; set; }

        [Required(ErrorMessage = "{0} é um campo obrigatório!")]
        [DataType(DataType.Time)]
        public string Horario { get; set; }
    }
}
