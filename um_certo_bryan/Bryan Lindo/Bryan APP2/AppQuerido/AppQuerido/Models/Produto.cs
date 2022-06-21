using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppQuerido.Models
{
    public class Produto
    {
        [Range(1,200)]
        [Required (ErrorMessage = "Insira os valores corretamente!")]
        [Display(Name = "Código")]
        public int      Codigo       { get; set; }

        [StringLength(50,MinimumLength =1)]
        [Required (ErrorMessage = "Insira os valores corretamente!")]
        public string   Nome         { get; set; }
      
        [Required (ErrorMessage = "Insira os valores corretamente!")]
        [Display(Name = "Preço")]
        public decimal  Preco       { get; set; }

        [DataType(DataType.Date)]
        [Required (ErrorMessage = "Insira os valores corretamente!")]
        [Display (Name = "Data de validade")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataVal     { get; set; }

        [Required(ErrorMessage = "Insira os valores corretamente!")]
        [RegularExpression(@"[a-zA-Z]{5,10}", ErrorMessage = "O Login deve ter entre 5 a 10 letras!")]
        [Remote("ValidaLogin","Produto", ErrorMessage = "Login já existente!")]
        public string Login         { get; set; }

        [Required(ErrorMessage = "Insira os valores corretamente!")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "O email deve estar na formatação comum de um email!")]
        public string Email         { get; set; }
            
        [Required(ErrorMessage = "Insira os valores corretamente!")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Insira os valores corretamente!")]
        [Display(Name = "Confirmar Senha")]
       
        [System.ComponentModel.DataAnnotations.Compare("Senha")]
        public string ConfirmaSenha { get; set; }
    }
}