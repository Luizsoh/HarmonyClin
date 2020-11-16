using Entidade.Entities.Enums;
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
        [Display(Name = "Categoria")]
        public CategoriaArtigo Categoria { get; set; }

        [Column("ART_CONTEUDO")]
        [Display(Name = "Conteudo")]
        public string Conteudo { get; set; }
    }
}
