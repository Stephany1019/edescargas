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

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Nombre")]
        [Required]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Año")]
        [Required]
        public int Annio { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Idioma")]
        [Required]
        public string Idioma { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Actores")]
        [Required]
        public string Actores { get; set; }

        [Column(TypeName = "varchar(200)")]
        [DisplayName("Archivo descarga")]
        [Required]
        public string Archivo_descarga { get; set; }

        [Column(TypeName = "varchar(200)")]
        [DisplayName("Archivo previsualización")]
        [Required]
        public string Archivo_previsual { get; set; }

    }
}
