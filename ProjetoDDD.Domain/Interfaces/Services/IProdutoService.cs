﻿using ProjetoDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoDDD.Domain.Interfaces.Services 
{

    public interface IProdutoService: IServiceBase<Produto> 
    {
        IEnumerable<Produto> BuscarPorNome ( string nome );
    }
}
