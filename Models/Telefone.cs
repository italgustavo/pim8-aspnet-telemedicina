using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PIM_8_CRUD.Models
{
    [Table("Telefone")]
    public class Telefone
    {
        [Display(Name = "Codigo")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Numero")]
        [Column("Numero")]
        public int Numero { get; set; }

        [Display(Name = "DDD")]
        [Column("DDD")]
        public int DDD { get; set; }

        [Display(Name = "TipoTelefone")]
        [Column("TipoTelefone")]
        public string TipoTelefone { get; set; }

        [Display(Name = "PessoaId")]
        [Column("PessoaId")]
        public int PessoaId { set; get; }

        [Display(Name = "Pessoa")]
        [Column("Pessoa")]
        public Pessoas Pessoa { get; set; }


    }
}
