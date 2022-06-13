using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCQRS.Model
{
    [Table("Carga")]
    public class Carga
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }

        [Column("NOME")]
        public string Nome { get; set; }

        [Column("status")]
        public char Status { get; set; }

        [Column("transporte")]
        public string Trasporte { get; set; }
    }
}