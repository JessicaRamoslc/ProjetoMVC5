using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoDDD.Application.Interface {
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService ( IProdutoService produtoService ) : base(produtoService) 
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarPorNome ( string nome ) 
        {
            return _produtoService.BuscarPorNome(nome);
        }
    }
}
