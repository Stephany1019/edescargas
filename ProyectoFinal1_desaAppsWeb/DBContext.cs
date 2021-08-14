using Microsoft.EntityFrameworkCore;
using ProyectoFinal1_desaAppsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal1_desaAppsWeb
{
    public class DBContext : DbContext
    {
        public DBContext(){}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<USUARIO>().HasKey(s => new { s.Id_usuario });
        }

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        public DbSet<ProyectoFinal1_desaAppsWeb.Models.USUARIO> USUARIO { get; set; }

        public DbSet<ProyectoFinal1_desaAppsWeb.Models.PELICULAS> PELICULAS { get; set; }

        public DbSet<ProyectoFinal1_desaAppsWeb.Models.LIBROS> LIBROS { get; set; }

        public DbSet<ProyectoFinal1_desaAppsWeb.Models.MUSICA> MUSICA { get; set; }

        public DbSet<ProyectoFinal1_desaAppsWeb.Models.CONSECUTIVOS> CONSECUTIVOS { get; set; }

        public DbSet<ProyectoFinal1_desaAppsWeb.Models.AppAdmin> AppAdmin { get; set; }

        public DbSet<ProyectoFinal1_desaAppsWeb.Models.AppCliente> AppCliente { get; set; }

    }
}
