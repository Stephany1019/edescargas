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

        private string _Ruta_previsual_libros;
        private string _Ruta_almacen_libros;
        private string _Ruta_previsual_peliculas;
        private string _Ruta_almacen_peliculas;
        private string _Ruta_previsual_musica;
        private string _Ruta_almacen_musica;

        [Column(TypeName = "varchar(200)")]
        [DisplayName("Ruta previsualización libros")]
        [Required]
        public string Ruta_previsual_libros
        {

            get => Utils.DesEncriptar(_Ruta_previsual_libros);
            set => _Ruta_previsual_libros = value;

        }

        [Column(TypeName = "varchar(200)")]
        [DisplayName("Ruta almacenar libros")]
        [Required]
        public string Ruta_almacen_libros
        {

            get => Utils.DesEncriptar(_Ruta_almacen_libros);
            set => _Ruta_almacen_libros = value;

        }

        [Column(TypeName = "varchar(200)")]
        [DisplayName("Ruta previsualización peliculas")]
        [Required]
        public string Ruta_previsual_peliculas
        {

            get => Utils.DesEncriptar(_Ruta_previsual_peliculas);
            set => _Ruta_previsual_peliculas = value;

        }

        [Column(TypeName = "varchar(200)")]
        [DisplayName("Ruta almacenar peliculas")]
        [Required]
        public string Ruta_almacen_peliculas {

            get => Utils.DesEncriptar(_Ruta_almacen_peliculas);
            set => _Ruta_almacen_peliculas = value;

        }
        [Column(TypeName = "varchar(200)")]
        [DisplayName("Ruta previsualización musica")]
        [Required]
        public string Ruta_previsual_musica
        {

            get => Utils.DesEncriptar(_Ruta_previsual_musica);
            set => _Ruta_previsual_musica = value;

        }

        [Column(TypeName = "varchar(200)")]
        [DisplayName("Ruta almacenar musica")]
        [Required]
        public string Ruta_almacen_musica
        {

            get => Utils.DesEncriptar(_Ruta_almacen_musica);
            set => _Ruta_almacen_musica = value;

        }

    }
}
