using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using WebAtividadeEntrevista.CustomValidationAttributes;

namespace WebAtividadeEntrevista.Models
{
    /// <summary>
    /// Classe de Modelo de Cliente
    /// </summary>
    public class BeneficiariosModel
    {
        private string _cpf;

        public long? Id { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
        [Required]
        public string Nome { get; set; }

        /// <summary>
        /// CPF
        /// </summary>
        [CPFValidation(ErrorMessage = "O CPF do benefici�rio n�o � v�lido")]
        [Required]
        public string CPF
        {
            get => _cpf;
            set => _cpf = Regex.Replace(value, @"\D", "");
        }
    }
}