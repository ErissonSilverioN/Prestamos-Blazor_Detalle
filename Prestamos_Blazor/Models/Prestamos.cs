using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace Prestamos_Blazor.Models
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }

        [Required(ErrorMessage = "DEBE INGRESAR UNA PERSONA")]
        public int PersonaId { get; set; } 

        [Required (ErrorMessage ="DEBE INGRESAR EL CONCEPTO ")]
        public string Concepto { get; set; }

        [Required(ErrorMessage = "DEBE INGRESAR EL MONTO")]
        public decimal Monto { get; set; }
        public decimal Balance { get; set; }
        public DateTime Fecha { get; set; }

        public Prestamos()
        {
            PrestamoId = 0;
            PersonaId = 0;
            Concepto = string.Empty;
            Monto = 0;
            Balance = 0;
            Fecha = DateTime.Now;
        }
    }
}
