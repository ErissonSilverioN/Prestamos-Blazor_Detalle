using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Prestamos_Blazor.Models
{
    public class Personas
    {
        [Key]
        public int PersonaId { get; set; }

        [Required(ErrorMessage ="DEBE INGRESAR EL NOMBRE")] 
        public string Nombre { get; set; }

        [Required(ErrorMessage = "DEBE INGRESAR LA CEDULA")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "DEBE INGRESAR EL TELEFONO")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "DEBE INGRESAR LA DIRECCION")]
        public string Direccion { get; set; }

        public decimal Balance { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public DateTime Fecha { get; set; }

        public Personas()
        {
            PersonaId = 0;
            Nombre = string.Empty;
            Cedula = string.Empty;
            Telefono = string.Empty;
            Direccion = string.Empty;
            Balance = 0;
            FechaNacimiento = DateTime.Now;
            Fecha = DateTime.Now;
        }
    }
}
