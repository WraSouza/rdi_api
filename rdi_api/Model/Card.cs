using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace rdi_api.Model
{
    public class Card
    {
        [Key]
        public string CustomerId { get; set; }

        [Required(ErrorMessage ="Campo Obrigatório")]
        [MaxLength(16,ErrorMessage =("Campo Deve Possuir 16 Caracteres"))]
        [MinLength(16, ErrorMessage = "Campo Deve Possuir 16 Caracteres")]
        public string CardNumber { get; set; }

        [Required(ErrorMessage ="Campo Obrigatório")]
        [MaxLength(5,ErrorMessage ="Campo Deve Possuir 5 Caracteres")]
        [MinLength(1,ErrorMessage ="Campo Deve Possuir no Mínimo 1 Caracter")]
        public string CVV { get; set; }

    }
}
