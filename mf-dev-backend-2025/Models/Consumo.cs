using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2025.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatória a descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatória a data")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatória o valor abastecido")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a quilometragem do veiculo")]
        public int Km { get; set; }

        [Display(Name ="Tipo de combustível")]
        [Required(ErrorMessage = "Obrigatório informar o tipo de combustível")]
        public TipoCombustivel Tipo { get; set; }

        [Display(Name ="Veículo")]
        [Required(ErrorMessage = "Obrigatório informar o veículo")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }

       

    }

    public enum TipoCombustivel
    {
        Gasolina,
        Alcool,
        Diesel,
    }

}
