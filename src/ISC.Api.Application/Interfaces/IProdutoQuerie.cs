﻿using ISC.Api.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ISC.Api.Application.Interfaces
{
    public interface IProdutoQuerie
    {
        Task<bool> CadastrarProduto(Produto prod);
        IEnumerable<Produto> ListarProdutos(int EmpresaId);
    }
}
