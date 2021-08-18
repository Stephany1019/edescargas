using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal1_desaAppsWeb.Models
{
    public class BITACORA
    {
        [Key]
        public int Id_Bitacora { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Usuario")]
        [Required]
        public string Usuario { get; set; }

        //[DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        [DisplayName("Fecha Hora")]
        [Required]
        public DateTime Fecha_Hora { get; set; }

        [Column(TypeName = "varchar(30)")]
        [DisplayName("Id_registro")]
        [Required]
        public string Id_registro { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Tipo")]
        [Required]
        public string Tipo { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Descripcion")]
        [Required]
        public string Descripcion { get; set; }

        [Column(TypeName = "varchar(200)")]
        [DisplayName("Registro detalle")]
        [Required]
        public string Registro_detalle { get; set; }

    }
}
