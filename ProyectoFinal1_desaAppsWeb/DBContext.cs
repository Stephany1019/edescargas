﻿using Microsoft.EntityFrameworkCore;
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
            modelBuilder.Entity<USUARIO>().HasKey(s => new { s.Id_usuario });
        }

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        public DbSet<ProyectoFinal1_desaAppsWeb.Models.USUARIO> USUARIO { get; set; }

    }
}
