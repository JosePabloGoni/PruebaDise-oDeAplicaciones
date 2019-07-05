using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PruebaDiseño
{
    public class Villain
    {
        public int ID { get; set; }
        [Required]
        public String Name { get; set; }
        [Range(0,11111111,ErrorMessage ="Entero debe ser mayor a 0")]
        public int NumberOfBatlles { get; set; }
        public List<Hero> Heros { get; set; }

        public Weapon weapon { get; set; }
    }
}
