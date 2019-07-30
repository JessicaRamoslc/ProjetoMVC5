using ProjetoDDD.Domain.Entities;
using System.Collections;
using System.Collections.Generic;

namespace ProjetoDDD.Domain.Interfaces.Services 
{
    public interface IClienteService: IServiceBase<Cliente> 
    {
        IEnumerable<Cliente> ObterClientesEspeciais ( IEnumerable<Cliente> clientes );
    }
}
