using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VentaBoletos.Models
{
    public class Viaje
    {
        // Colocar los datos del viaje en la clase viaje, de forma que sea la plantilla que
        // Genera el boleto para imprimir los datos y asignar un usuario(Pasajero) al mismo.
        [Key]
        public  int ViajeId { get; set; }

        public int VendedorId { get; set; }
        public int CategoriaId { get; set; }
        public string Puesto { get; set; }
        public  string PuertaSalida { get; set; } //Input

        public  DateTime HoraSalida { get; set; } //Input
        public  DateTime HoraEstimadaLlegada { get; set; }//Input
        public string Unidad { get; set; }
        public decimal Precio { get; set; }
        public string NumeroViaje { get; set; }
        public int TrayectoId { get; set; }
        public virtual Trayecto Trayecto { get; set; }




    }
}