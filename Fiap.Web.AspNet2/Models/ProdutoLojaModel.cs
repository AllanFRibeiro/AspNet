using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet2.Models
{
    [Table("ProdutoLoja")]
    public class ProdutoLojaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProdutoLojaId { get; set; }

        //FK Loja
     
        public int LojaId { get; set; }

        [ForeignKey("LojaId")]
        public LojaModel Loja { get; set; }

     
        public int ProdutoId { get; set; }
        //FK Produto
        [ForeignKey("ProdutoId")]
        public ProdutoModel Produto { get; set; }
    }
}
