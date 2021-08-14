using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal1_desaAppsWeb.Models
{
    public class MUSICA
    {

        [Key]
        [Column(TypeName = "varchar(20)")]
        public string Id_musica { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Nombre musica")]
        [Required]
        public string Nombre_musica { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Tipo interpretacion")]
        [Required]
        public string Tipo_interpretacion { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Idioma")]
        [Required]
        public string Idioma { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Pais")]
        [Required]
        public string Pais { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Disquera")]
        [Required]
        public string Disquera { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Nombre_disco")]
        [Required]
        public string Nombre_disco { get; set; }

        
        [DisplayName("Año")]
        [Required]
        public int Annio { get; set; }

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
