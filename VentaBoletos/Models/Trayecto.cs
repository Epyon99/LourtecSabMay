using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VentaBoletos.Models
{
    public class Trayecto
    {
        [Key]
        public virtual int TrayectoId { get; set; }

        public int DestinoId { get; set; } // ComboBox
        public int OrigenId { get; set; } //Input

        public virtual Destino Origen { get; set; }
        public virtual Destino Destino { get; set; }

    }
}