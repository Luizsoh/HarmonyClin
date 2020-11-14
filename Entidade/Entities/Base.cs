using Entidade.Notifications;
using System.ComponentModel.DataAnnotations;

namespace Entidade.Entities
{
    public class Base : Notifies
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

    }
}
