using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces;
using ProjetoDDD.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace ProjetoDDD.Infra.Data.Repositories {
    public interface IProdutoRepository: IRepositoryBase<Produto> {

        IEnumerable<Produto> BuscaPorNome ( string nome );
    }
}
