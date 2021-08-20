using Microsoft.EntityFrameworkCore;
using ProyectoFinal1_desaAppsWeb.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal1_desaAppsWeb
{
    public class DBContext : DbContext
    {
        public DBContext(){}
        public List<SqlParameter> Parameters = new List<SqlParameter>();
        public SqlConnection conexion = new SqlConnection();

        public DataTable ExecuteMethodDataTable(List<SqlParameter> Parameters, string spNombre, string strConnection)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = ObtenerConexion(strConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = spNombre;
                if(null != Parameters)
                {
                    foreach(SqlParameter parameter in Parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }catch(Exception e)
            {
                AddErrorRow(dt, e.Message.ToString());
            }
            finally
            {
                DescargarConexion();
            }
            return dt;
        }

        public SqlConnection ObtenerConexion(string strConnection)
        {
            string connectionString = strConnection;
            conexion = new SqlConnection(connectionString);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public bool DescargarConexion()
        {
            conexion.Close();
            return true;
        }

        public void AddErrorRow(DataTable dt,string ErrorMEssage)
        {
            dt.Columns.Add("Error", typeof(string));
            dt.Rows.Add(ErrorMEssage);
        }
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

        public DbSet<ProyectoFinal1_desaAppsWeb.Models.BITACORA> BITACORA { get; set; }

        public DbSet<ProyectoFinal1_desaAppsWeb.Models.PARAMETROS> PARAMETROS { get; set; }

    }
}
