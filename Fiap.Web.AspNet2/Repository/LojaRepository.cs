﻿using Fiap.Web.AspNet2.Data;
using Fiap.Web.AspNet2.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace Fiap.Web.AspNet2.Repository
{
    public class LojaRepository
    {
        private readonly DataContext context;
        public LojaRepository(DataContext dataContext)
        {
            context = dataContext;
        }
        public LojaModel FindById(int id)
        {
            return context.Lojas // SELECT FROM tabela
                    .Include(l => l.ProdutoLojas) // INNER JOIN Produtos da Loja
                        .ThenInclude(pl => pl.Produto) // INNER JOIN -- Detalhes do Produto
                            .SingleOrDefault(l => l.LojaId == id); // WHERE 
        }
    }
}