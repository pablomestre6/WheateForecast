using System.ComponentModel.DataAnnotations;

namespace WheateForecast.Models
{
    public class CadastroFuncionarioModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome do Funcionario")]
        public string? Nome  { get; set; }

        [Required(ErrorMessage = "Por favor o Numero da Sua Matricula")]
        public string? Setor { get; set; }

       
        [Required(ErrorMessage = "Digite o numero do CPF do colaborador")]
        public int CPF { get; set; }

        [Required(ErrorMessage = "Digite o numero da Identidade")]
        public int Identidade { get; set; }


        public int NumeroTelefone { get; set; }

       
        [Required(ErrorMessage = "Por favor digite o endereço do colabirador")]
        public string? Endereco { get; set; }

        [Required(ErrorMessage = "Digite o CEP do colaborador")]
        public int CEP { get; set; }

        public DateTime DataAdmicao { get; set; }

        [Required(ErrorMessage = "Data de Nascmento e Obrigatorio")]
        public DateTime DataNacimento { get; set; }
    }
}
