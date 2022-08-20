using System.ComponentModel.DataAnnotations;

namespace Entra21.CSharp.ClinicaVeterinaria.Servico.ViewModels
{
    public class RacaViewModel
    {
        [Display(Name = nameof(Nome))]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [MinLength(4, ErrorMessage = "{0} deve conter no mínimo {1} caracteres")]
        [MaxLength(50, ErrorMessage = "{0} deve conter no máximo {1} caracteres")]
        public string Nome { get; set; }

        //[Display(Name = "Espécie")]
        [Display(Name = nameof(Especie))]
        [Required(ErrorMessage = "{0} deve ser escolhido")]
        public string Especie { get; set; }
    }
}