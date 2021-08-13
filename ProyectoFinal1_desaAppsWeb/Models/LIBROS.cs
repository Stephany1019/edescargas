using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal1_desaAppsWeb.Models
{
    public class LIBROS
    {
        [Key]
        [Column(TypeName = "varchar(20)")]
        public string Id_libro { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Nombre libro")]
        [Required]
        public string Nombre_libro { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Autor")]
        [Required]
        public int Autor { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Idioma")]
        [Required]
        public string Idioma { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Editorial")]
        [Required]
        public string Editorial { get; set; }

        [Column(TypeName = "int")]
        [DisplayName("Año publicacion")]
        [Required]
        public int Annio_publicacion { get; set; }

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
