using Entidade.Entities.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidade.Entities
{
    public class ApplicationUser : IdentityUser<string>
    {
        [Column("USR_CPF")]
        [MaxLength(50)]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Column("USR_STATUS")]
        public bool Status { get; set; } = true;

        [Column("USR_TIPO")]
        [Display(Name = "Tipo")]
        public TipoUsuario Tipo { get; set; }
    }
}
