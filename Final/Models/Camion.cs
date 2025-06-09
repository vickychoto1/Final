using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class Camion : Vehiculo
    {
        [Required]
        public string Carga { get; set; }
        [Required]
        public string Llanta { get; set; }
    }
}