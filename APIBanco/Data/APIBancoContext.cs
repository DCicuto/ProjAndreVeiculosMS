﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace APIBanco.Data
{
    public class APIBancoContext : DbContext
    {
        public APIBancoContext (DbContextOptions<APIBancoContext> options)
            : base(options)
        {
        }
        public DbSet<Models.Banco> Banco { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
        public DbSet<Models.Message>? Message { get; set; }
    }
}
