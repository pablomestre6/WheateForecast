using System;
using System.ComponentModel.DataAnnotations;


namespace WheateForecast.Models
{
    public class AlmoxarifatoModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Por favor Cadastre o Produto")]
        public string? NameProduct { get; set; }

        [Required(ErrorMessage = "Por favor o Numero da Sua Matricula")]
        public int Matricula { get; set; }

        [Required(ErrorMessage = "Qual foi o fornecedor")]
        public string? Forncedor { get; set; }


        [MinLength(25, ErrorMessage = "Informe o valor do Produto")]
        [MaxLength(255, ErrorMessage = "O máximo um caractere {1}")]
        [Required(ErrorMessage = "Por favor informe o valor da compra")]
        public string? Valor  { get; set; }

        [Required(ErrorMessage = "Digite o numero da nota")]
        public int NumeroNota { get; set; }


        public DateTime Data { get; set; }


    }
}
