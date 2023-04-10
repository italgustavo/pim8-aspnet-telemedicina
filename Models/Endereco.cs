using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PIM_8_CRUD.Models
{
    [Table("Endereco")]
    public class Endereco
    {
        [Display(Name = "Codigo")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Logradouro")]
        [Column("Logradouro")]
        public string Logradouro { get; set; }

        [Display(Name = "Numero")]
        [Column("Numero")]
        public int Numero { get; set; }

        [Display(Name = "Cep")]
        [Column("Cep")]
        public int Cep { get; set; }

        [Display(Name = "Bairro")]
        [Column("Bairro")]
        public string Bairro { get; set; }

        [Display(Name = "Cidade")]
        [Column("Cidade")]
        public string Cidade { get; set; }

        [Display(Name = "Estado")]
        [Column("Estado")]
        public string Estado { get; set; }

        [Display(Name = "IdPessoa")]
        [Column("PessoaId")]
        public int PessoaId { get; set; }

        [Display(Name = "Pessoa")]
        [Column("Pessoa")]
        public Pessoas Pessoa { get; set; }
    }
}
