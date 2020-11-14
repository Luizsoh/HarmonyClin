using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidade.Notifications
{
    public class Notifies
    {
        public Notifies()
        {
            ListNotifies = new List<Notifies>();

        }

        [NotMapped]
        public string NomePropriedade { get; set; }

        [NotMapped]
        public string Mensagem { get; set; }

        [NotMapped]
        public List<Notifies> ListNotifies;        

        public bool ValidaString(string valor, string nomePropriedade)
        {
            if(string.IsNullOrEmpty(valor) || string.IsNullOrEmpty(nomePropriedade))
            {
                ListNotifies.Add(new Notifies
                {
                    Mensagem = "Campo Obrigatorio",
                    NomePropriedade = nomePropriedade
                });
                return false;
            }

            return true;
        }

        public bool ValidaInt(int valor, string nomePropriedade)
        {
            if (valor < 1 || string.IsNullOrEmpty(nomePropriedade))
            {
                ListNotifies.Add(new Notifies
                {
                    Mensagem = "Valor deve ser maior que 0",
                    NomePropriedade = nomePropriedade
                });
                return false;
            }

            return true;
        }
    }
}
