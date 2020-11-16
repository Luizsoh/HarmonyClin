﻿using Entidade.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.Configuration
{
    public class ContextBase : IdentityDbContext<ApplicationUser>
    {
        public ContextBase(DbContextOptions<ContextBase> options):base(options)
        {
        }

        public DbSet<Relato> Relato { get; set; }
        public DbSet<Artigo> Artigo { get; set; }
        public DbSet<Imagem> Imagem { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConnectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }

        private string GetStringConnectionConfig()
        {
            //MUDAR PARA A STRING DO SEU BANCO ATÉ PUBLICARMOS EM ALGUM LUGAR (PROVAVELMENT HOSTINGER)
            string strCon = "Data Source=DESKTOP-I8A2FBU\\SQLEXPRESS;Initial Catalog=HarmonyClin;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            return strCon;
        }
    }
}
