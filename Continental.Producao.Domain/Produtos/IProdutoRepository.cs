﻿using System;
using System.Threading.Tasks;

namespace Continental.Producao.Domain.Produtos
{
    public interface IProdutoRepository
    {
        Produto Obter(Guid id);
        Task Criar(Produto produto);
        void Atualizar(Produto entity);
        void Excluir(Produto entity);
    }
}
