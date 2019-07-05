using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PruebaDiseño
{
    public class Weapon
    {
        public int ID { get; set; }
        [Required]
        public String Name { get; set; }
        [Range(1, 10, ErrorMessage = "Entero entre 1 y 10")]
        public int Power { get; set; }
    }
}
