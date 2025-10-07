using Microsoft.EntityFrameworkCore;
using AutoSchool.Models;

namespace AutoSchool.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        /* referencia das classes que representam as tabelas de dados

               logo após criar uma classe de dados, insira abaixo:  */

        public DbSet<Empresa> Empresas { get; set; }

    }
}
