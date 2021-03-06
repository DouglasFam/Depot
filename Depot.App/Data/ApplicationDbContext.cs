﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Depot.App.ViewModels;

namespace Depot.App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FornecedorViewModel> FornecedorViewModel { get; set; }
        public DbSet<ProdutoViewModel> ProdutoViewModel { get; set; }
        public DbSet<EnderecoViewModel> EnderecoViewModels { get; set; }
    }
}
