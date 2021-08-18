using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal1_desaAppsWeb.Models
{
    public class PARAMETROS
    {
        [Key]
        public int Id_Parametro { get; set; }

        [Column(TypeName = "varchar(200)")]
        [DisplayName("Ruta previsualización libros")]
        [Required]
        public string Ruta_previsual_libros { get; set; }

        [Column(TypeName = "varchar(200)")]
        [DisplayName("Ruta almacenar libros")]
        [Required]
        public string Ruta_almacen_libros { get; set; }

        [Column(TypeName = "varchar(200)")]
        [DisplayName("Ruta previsualización peliculas")]
        [Required]
        public string Ruta_previsual_peliculas { get; set; }

        [Column(TypeName = "varchar(200)")]
        [DisplayName("Ruta almacenar peliculas")]
        [Required]
        public string Ruta_almacen_peliculas { get; set; }

        [Column(TypeName = "varchar(200)")]
        [DisplayName("Ruta previsualización musica")]
        [Required]
        public string Ruta_previsual_musica { get; set; }

        [Column(TypeName = "varchar(200)")]
        [DisplayName("Ruta almacenar musica")]
        [Required]
        public string Ruta_almacen_musica { get; set; }

    }
}
