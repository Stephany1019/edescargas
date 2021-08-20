using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal1_desaAppsWeb.Models
{
    public class CONSECUTIVOS
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Id_TipoProducto")]
        [Required]
        public int Id_TipoProducto { get; set; }

        [DisplayName("Consecutivo")]
        [Required]
        public int Consecutivo { get; set; }

        [Column(TypeName = "bit")]
        [DisplayName("Posee prefijo")]
        [Required]
        public bool Posee_prefijo { get; set; }

        [Column(TypeName = "varchar(5)")]
        [DisplayName("Prefijo")]
        
        public string Prefijo { get; set; }

        [Column(TypeName = "bit")]
        [DisplayName("Posee rango")]
        [Required]
        public bool Posee_rango { get; set; }

        [DisplayName("Rango inicial")]
        public int Rango_inicial { get; set; }

        [DisplayName("Rango final")]
        public int Rango_final { get; set; }

    }
}
