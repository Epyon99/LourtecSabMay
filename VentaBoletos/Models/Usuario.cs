using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VentaBoletos.Models
{
    public class Usuario
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int UsuarioId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        /// <summary>
        /// Coleccion de Roles asociados.
        /// </summary>
        public virtual ICollection<Rol> Roles { get;set;}
    }
}