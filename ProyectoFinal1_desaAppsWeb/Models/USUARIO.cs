using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal1_desaAppsWeb.Models
{
    public class USUARIO
    {

        [Key]
        public int Id_usuario { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Usuario")]
        [Required]
        public string Usuario { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Contraseña")]
        [Required]
        public string Contrasena { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Email")]
        [Required]
        public string Email { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Pregunta de seguridad")]
        [Required]
        public string Pregunta_seguridad { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Respuesta de seguridad")]
        [Required]
        public string Respuesta_seguridad { get; set; }

    }
}
