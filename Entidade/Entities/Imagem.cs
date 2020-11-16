using Entidade.Notifications;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidade.Entities
{
    [Table("TB_CADASTRO_IMAGENS")]
    public class Imagem : Notifies
    {
        [Column("IMG_ID")]
        [Key]
        public int Img_Id { get; set; }

        [Column("IMG_NOME_ARQUIVO")]
        public string FileName { get; set; }

        [Column("IMG_CAMINHO_ARQUIVO")]
        public string FilePath { get; set; }

        [Column("IMG_TITULO")]
        public string Titulo { get; set; }

        [Column("IMG_LEGENDA")]
        public string Legenda { get; set; }

        [Column("IMG_LINK")]
        public string Link { get; set; }

        [Column("IMG_STATUS")]
        public bool Status { get; set; }
    }
}
