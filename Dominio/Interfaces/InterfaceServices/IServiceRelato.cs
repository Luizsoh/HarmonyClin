﻿using Entidade.Entities;
using System.Threading.Tasks;

namespace Dominio.Interfaces.InterfaceServices
{
    public interface IServiceRelato
    {
        Task AddRelato(Relato relato);
        Task UpdateRelato(Relato relato);
    }
}
