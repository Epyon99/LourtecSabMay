using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VentaBoletos.Models
{
    public class Rol
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int RolId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Tipo { get; set; }
        public int estatus { get; set; }


        /// <summary>
        /// Coleccion de Usuarios asociados.
        /// </summary>
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}