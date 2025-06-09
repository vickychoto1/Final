using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class Motocicleta : Vehiculo
    {
        [Required]
        public string Cilindrada { get; set; }
        [Required]
        public string Tipo { get; set; }
    }
}