using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VentaBoletos.Models
{
    public class Categoria
    {
        [Key]
        public virtual int CategoriaId { get; set; }


        public virtual string Nombre { get; set; }
        public virtual  string Descripcion { get; set; }
        public virtual int Tipo { get; set; }
        public virtual int estatus { get; set; }

        public virtual ICollection<Unidad> Unidades { get; set; }
    }
}