using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal1_desaAppsWeb
{
    public static class Utils
    {
        public static IConfiguration _configuration;
        public static bool encryp = false;
        public static string nombreUsuario = string.Empty;
        /// Encripta una cadena
        public static string Encriptar(this string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        /// Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
        public static string DesEncriptar(this string _cadenaAdesencriptar)
        {
            try
            {
                if(encryp)
                {
                    string result = string.Empty;
                    byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
                    //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
                    result = System.Text.Encoding.Unicode.GetString(decryted);
                    return result;
                }
                return _cadenaAdesencriptar;
            }
            catch (Exception e)
            {
                return _cadenaAdesencriptar;
            }
        }

        public static string insertarBitacora(string _connectionString, string Usuario, DateTime Fecha_Hora, string Id_registro, string Tipo, string Descripcion, string Registro_detalle)
        {
            string result = string.Empty;
            try
            {
                DBContext connect = new DBContext();
                string connectionString = _connectionString;// _configuration.GetConnectionString("DefaultConnection");
                DataTable dt = new DataTable();
                var listaParametros = connect.Parameters;

                listaParametros.Add(new SqlParameter("@Usuario", Usuario));
                listaParametros.Add(new SqlParameter("@Fecha_Hora", Fecha_Hora));
                listaParametros.Add(new SqlParameter("@Id_registro", Id_registro));
                listaParametros.Add(new SqlParameter("@Tipo", Tipo));
                listaParametros.Add(new SqlParameter("@Descripcion", Descripcion));
                listaParametros.Add(new SqlParameter("@Registro_detalle", Registro_detalle));

                dt = connect.ExecuteMethodDataTable(listaParametros, "SP_INSERTAR_BITACORA", connectionString);
                if (dt.Rows.Count > 0)
                    result = dt.Rows[0][0].ToString();
            }
            catch(Exception e)
            {
                result = e.ToString();
            }
            return result;
        }
    }
}

