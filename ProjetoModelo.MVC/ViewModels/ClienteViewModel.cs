using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModelo.MVC.ViewModels {
    public class ClienteViewModel {

        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Preecha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]

        public string Nome { get; set; }

        [Required(ErrorMessage = "Preecha o campo Sobrenome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]

        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Preecha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Insira e-mail válido")]
        [DisplayName("E-mail")]

        public string Email { get; set; }

        [ScaffoldColumn(false)]

        public DateTime DataCadastro { get; set; }

        //[MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        //[MinLength(11, ErrorMessage = "Mínimo de {0} caracteres")]
        //public int NumeroCPF { get; set; }

        public bool Ativo { get; set; }

        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}