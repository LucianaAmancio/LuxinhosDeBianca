using LuxinhosDeBianca.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuxinhosDeBianca.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        //public DbSet<ListaDeDesejoItem> ListaDeDesejoItens { get; set; }

        //public DbSet<PedidoOrcamento> PedidosOrcamentos { get; set; }
        //public DbSet<PedidoOrcamentoDetalhe> PedidosOrcamentosDetalhes { get; set; }

    }
}
