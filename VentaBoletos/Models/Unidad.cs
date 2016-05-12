using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VentaBoletos.Models
{
    public class Unidad
    {
        public int UnidadId { get; set; }

        public virtual ICollection<Categoria> Categoria { get; set; }
        
    }
}