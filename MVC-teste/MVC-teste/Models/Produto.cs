using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_teste.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage ="O campo descrição é obrigatório !")]
        public string Descricao { get; set; }
        [Range(1,100, ErrorMessage = "Valor fora da faixa !")]
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public List<Produto> produtos { get; set; }
    }
}
