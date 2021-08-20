using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal1_desaAppsWeb.Models
{
    public class PELICULAS
    {
        [Key]
        [Column(TypeName = "varchar(20)")]
        public string Id_Pelicula { get; set; }

        private string _Nombre;
        private string _Idioma;
        private string _Actores;
        private string _Archivo_descarga;
        private string _Archivo_previsual;

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Nombre")]
        [Required]
        public string Nombre
        {

            get => Utils.DesEncriptar(_Nombre);
            set => _Nombre = value;

        }


        [DisplayName("Año")]
        [Required]
        public int Annio { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Idioma")]
        [Required]
        public string Idioma
        {

            get => Utils.DesEncriptar(_Idioma);
            set => _Idioma = value;

        }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Actores")]
        [Required]
        public string Actores
        {

            get => Utils.DesEncriptar(_Actores);
            set => _Actores = value;

        }

        [Column(TypeName = "varchar(200)")]
        [DisplayName("Archivo descarga")]
        [Required]
        public string Archivo_descarga
        {

            get => Utils.DesEncriptar(_Archivo_descarga);
            set => _Archivo_descarga = value;

        }

        [Column(TypeName = "varchar(200)")]
        [DisplayName("Archivo previsualización")]
        [Required]
        public string Archivo_previsual
        {

            get => Utils.DesEncriptar(_Archivo_previsual);
            set => _Archivo_previsual = value;

        }

    }
}
