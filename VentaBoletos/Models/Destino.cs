using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VentaBoletos.Models
{
    public class Destino
    {

        [System.ComponentModel.DataAnnotations.Key]
        public int DestinoId { get; set; }
        public virtual ICollection<Trayecto> Trayectos { get; set; }
    }
}