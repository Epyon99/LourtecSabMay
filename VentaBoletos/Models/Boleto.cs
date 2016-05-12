using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VentaBoletos.Models
{
    public class Boleto
    {
        // Colocar los datos del viaje en la clase viaje, de forma que sea la plantilla que
        // Genera el boleto para imprimir los datos y asignar un usuario(Pasajero) al mismo.
        [System.ComponentModel.DataAnnotations.Key]
        public int BoletoID { get; set; }



        public int ViajeID { get; set; } // ComboBox

        public int UsuarioID { get; set; } // Necesario en la compra.

        public string NumeroBoleto { get; set; } // Input
        public string Puesto { get; set; }//Input
        public int CategoriaID { get; set; } //ComboBox
        public string PuertaSalida { get { return Viaje.PuertaSalida; } }
        public int VendedorID { get; set; } //Necesario en la compra.

        
        public virtual Usuario Vendedor { get; set; }
        public virtual Categoria Categoria { get; set; }


        public virtual Usuario Usuario { get; set; }

        public virtual Viaje Viaje { get; set; } 

    }
}