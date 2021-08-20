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

        private string _us;
        private string _Email;
        private string _Pregunta_seguridad;
        private string _Respuesta_seguridad;

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Usuario")]
        [Required]
        public string Usuario
        {
            
            get => Utils.DesEncriptar(_us);
            set => _us = value;

        }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Contraseña")]
        [Required]
        public string Contrasena { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Email")]
        [Required]
        public string Email
        {

            get => Utils.DesEncriptar(_Email);
            set => _Email = value;

        }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Pregunta de seguridad")]
        public string Pregunta_seguridad
        {

            get => Utils.DesEncriptar(_Pregunta_seguridad);
            set => _Pregunta_seguridad = value;

        }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Respuesta de seguridad")]
        [Required]
        public string Respuesta_seguridad
        {

            get => Utils.DesEncriptar(_Respuesta_seguridad);
            set => _Respuesta_seguridad = value;

        }

    }
}
