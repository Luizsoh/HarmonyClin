using Entidade.Notifications;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidade.Entities
{
    [Table("TB_ARTIGO")]
    public class Artigo : Notifies
    {
        [Column("ART_ID")]
        [Key]
        public int Artigo_Id { get; set; }

        [Column("ART_CATEGORIA")]
        public int Categoria { get; set; } //CONVERTER ISSO PARA ENUM

        [Column("ART_CONTEUDO")]
        public string Conteudo { get; set; }
    }
}
