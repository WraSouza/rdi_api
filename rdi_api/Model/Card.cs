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
        public int CustomerId { get; set; }

        [Required(ErrorMessage ="Campo Obrigatório")]
        [MaxLength(16, ErrorMessage = "Campo Deve Possuir 3 Dígitos no Máximo")]
        public string CardNumber { get; set; }

        [Required(ErrorMessage ="Campo Obrigatório")]
        [Range(1,999,ErrorMessage ="O Campo Deve Ter 3 Dígitos no Máximo")]
        public int CVV { get; set; }

    }
}
