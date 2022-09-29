using ControleDeCadastros.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace ControleDeCadastros.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> option) : base(option)
        {

        }

        public DbSet<ContatoModel> Contatos { get; set; }

    }
}
