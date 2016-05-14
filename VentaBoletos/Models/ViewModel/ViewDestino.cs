using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VentaBoletos.Models.ViewModel
{
    public class ViewDestino
    {
        public int DestinoId { get; set; }
        public virtual List<Trayecto> Trayectos { get; set; }
    }

    public class SearchDestino
    {
        [Required]
        public string NameOrigen { get; set; }
        [Required]
        public string NameDestino { get; set; }
        public DateTime HoraSalida { get; set; }
        public DateTime HoraLlegada { get; set; }
    }
}