using Entidade.Entities.Enums;
using Entidade.Notifications;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidade.Entities
{
    [Table("TB_USUARIOS")]
    public class Usuario : Notifies
    {
        [Key]
        [Column("USR_ID")]
        public int User_ID { get; set; }

        [Column("USR_CPF")]
        public string CPF { get; set; }

        [Column("USR_STATUS")]
        public bool Status { get; set; } = true;

        [Column("USR_TIPO")]
        public TipoUsuario Tipo { get; set; } = TipoUsuario.Admnistrador;

        [Column("USR_SENHA")]
        public string Senha { get; set; }
    }
}
