using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class Automovil : Vehiculo
    {
        [Required]
        public string Npuerta { get; set; }
        [Required]
        public string Combustible { get; set; }
    }
}