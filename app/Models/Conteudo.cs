using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models {
    [Table("conteudo")]
    public class Conteudo {
        [Column("id")]
        public int Id { get; set; }
        [Column("palavra")]
        public string Palavra { get; set; }

    }
}