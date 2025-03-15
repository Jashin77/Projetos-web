using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizCarros.Models
{
    [Table("perguntas")]
    public class Perguntas
    {
        [Key]
        public int PerguntasId { get; set; }
        [StringLength(255)]
        [Required]
        [Display(Name = "Enunciado")]
        public string Enunciado { get; set; }
        [StringLength(100)]
        [Required]
        [Display(Name = "Alternativa 1:")]
        public string Alternativa1 { get; set; }
        [StringLength(100)]
        [Required]
        [Display(Name = "Alternativa 2:")]
        public string Alternativa2 { get; set; }
        [StringLength(100)]
        [Required]
        [Display(Name = "Alternativa 3:")]
        public string Alternativa3 { get; set; }
        [StringLength(100)]
        [Required]
        [Display(Name = "Alternativa 4:")]
        public string Alternativa4 { get; set; }
        [Required]
        [Range(0,3)]
        public int RespostaCorreta { get; set; }  
    }
}
