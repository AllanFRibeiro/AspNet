using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet2.Models
{
    [Table("Produto")]
    public class ProdutoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProdutoId { get; set; }
        public String NomeProduto { get; set; }
        public  ICollection< ProdutoLojaModel> ProdutoLojas { get; set; }
    }
}
