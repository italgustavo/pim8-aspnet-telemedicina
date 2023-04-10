using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace PIM_8_CRUD.Models
{
    [Table("Pessoa")]
    public class Pessoas
    {

        [Display(Name = "Codigo")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Display(Name = "Cpf")]
        [Column("Cpf")]
        public long CPF { get; set; }

        [Display(Name = "Endereco")]
        [Column("Endereco_id")]
        public Endereco Endereco { get; set; }

        [Display(Name = "Telefone")]
        [Column("Telefone")]
        public Telefone Telefone { get; set; }
    }
}