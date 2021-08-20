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

        private string _Usuario;
        private string _Id_registro;
        private string _Tipo;
        private string _Descripcion;
        private string _Registro_detalle;

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Usuario")]
        [Required]
        public string Usuario
        {

            get => Utils.DesEncriptar(_Usuario);
            set => _Usuario = value;

        }

        //[DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        [DisplayName("Fecha Hora")]
        [Required]
        public DateTime Fecha_Hora { get; set; }

        [Column(TypeName = "varchar(30)")]
        [DisplayName("Id_registro")]
        [Required]
        public string Id_registro
        {

            get => Utils.DesEncriptar(_Id_registro);
            set => _Id_registro = value;

        }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Tipo")]
        [Required]
        public string Tipo
        {

            get => Utils.DesEncriptar(_Tipo);
            set => _Tipo = value;

        }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Descripcion")]
        [Required]
        public string Descripcion
        {

            get => Utils.DesEncriptar(_Descripcion);
            set => _Descripcion = value;

        }

        [Column(TypeName = "varchar(200)")]
        [DisplayName("Registro detalle")]
        [Required]
        public string Registro_detalle
        {

            get => Utils.DesEncriptar(_Registro_detalle);
            set => _Registro_detalle = value;

        }

    }
}
