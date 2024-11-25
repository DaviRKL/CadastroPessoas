using System.ComponentModel.DataAnnotations;

namespace CadastroPessoas.Models
{
    public class Cliente
    {
        [Key]

        public int id { get; set; }
        [Required]

        public string nome { get; set; }
    }
}
