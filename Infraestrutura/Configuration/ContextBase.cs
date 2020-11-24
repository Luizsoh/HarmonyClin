using Entidade.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.Configuration
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
        }

        public DbSet<Relato> Relato { get; set; }
        public DbSet<Artigo> Artigo { get; set; }
        public DbSet<Imagem> Imagem { get; set; }
        public DbSet<Usuario> Usuario {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConnectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        private string GetStringConnectionConfig()
        {
            //MUDAR PARA A STRING DO SEU BANCO ATÉ PUBLICARMOS EM ALGUM LUGAR (PROVAVELMENT HOSTINGER)
            string strCon = "Data Source=DESKTOP-I8A2FBU\\SQLEXPRESS;Initial Catalog=HarmonyClin;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            return strCon;
        }
    }
}
