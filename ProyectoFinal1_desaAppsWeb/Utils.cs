using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal1_desaAppsWeb
{
    public static class Utils
    {
        public static bool encryp = false;
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
    }
}

