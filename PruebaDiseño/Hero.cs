using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PruebaDiseño
{
    public enum planet{
        TIERRA,MARTE,JUPITER
    }
    public class Hero
    {
        [Required]
        public int ID { get; set; }
        public String Name { get; set; }
        public planet Planet { get; set; }
        public List<Villain> Villians { get; set; }
        public Weapon Weapon { get; set; }
    }
}
