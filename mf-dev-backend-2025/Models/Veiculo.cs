using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2025.Models
{

    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [Display(Name = "Ano de Fabricação do Veículo")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [Display(Name = "Ano do Modelo do Veículo")]   
        public int AnoModelo { get; set; }
    }
}
