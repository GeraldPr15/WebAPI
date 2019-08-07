using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    public class SistemaDePago
    {
        [Key]
        public int Pago_ID { get; set; }
        public string Nombre_Tarjeta { get; set; }
        public string Numero_Tajerta { get; set; }
        public string Dia_Expiracion { get; set; }
        public string CVV { get; set; }
    }
}
