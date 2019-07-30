using ProjetoDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoDDD.Infra.Data.Repositories {
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository {

        public IEnumerable<Produto> BuscaPorNome ( string nome ) {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
