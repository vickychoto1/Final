using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class Vehiculo
    {
        [Required]
        public string Chasis { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public int Añof { get; set; }
    }
}