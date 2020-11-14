using Entidade.Notifications;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidade.Entities
{
    [Table("TB_RELATOS_CLIENTES")]
    public class Relato : Notifies
    {
        [Column("REL_ID")]
        public int Relato_Id { get; set; }

        [Column("REL_NOME_ARQUIVO")]
        public string FileName { get; set; } 

        [Column("REL_CAMINHO_ARQUIVO")]
        public string FilePath { get; set; }

        [Column("REL_DEPOIMENTO")]
        public string Depoimento { get; set; }

        [Column("REL_STATUS")]
        public bool Status { get; set; }
    }
}
