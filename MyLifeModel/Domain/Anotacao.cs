using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLifeModel.Domain
{
    public class Anotacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(100)]
        public string Descricao { get; set; }

        [Column(TypeName = "text")]
        public string Texto { get; set; }
    }
}
