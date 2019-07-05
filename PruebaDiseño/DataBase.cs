using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDiseño
{
    public class DataBase
    {
        public void CrearHero(Hero hero)
        {
            try
            {
                using (var context = new Context())
                {
                    context.Heroes.Add(hero);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CrearVillain(Villain villain)
        {
            try
            {
                using (var context = new Context())
                {
                    context.Villains.Add(villain);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ActualizarHero(int id, Hero heroModified)
        {
            try
            {
                using (var context = new Context())
                {
                    Hero heroD = context.Heroes.Find(id);
                    context.Heroes.Remove(heroD);
                    context.Heroes.Add(heroModified);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ActualizarVillain(int id, Villain villainModified)
        {
            try
            {
                using (var context = new Context())
                {
                    Villain villainD = context.Villains.Find(id);
                    context.Villains.Remove(villainD);
                    context.Villains.Add(villainModified);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BorrarHero(int id)
        {
            try
            {
                using (var context = new Context())
                {
                    Hero heroD = context.Heroes.Find(id);
                    context.Heroes.Remove(heroD);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BorrarVillain(int id)
        {
            try
            {
                using (var context = new Context())
                {
                    Villain villainD = context.Villains.Find(id);
                    context.Villains.Remove(villainD);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Hero ObtenerHero(int id)
        {
            Hero heroD = null;
            try
            {
                using (var context = new Context())
                {
                    heroD = context.Heroes.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return heroD;
        }
        public Villain ObtenerVillain(int id)
        {
            Villain villainD = null;
            try
            {
                using (var context = new Context())
                {
                    villainD = context.Villains.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return villainD;
        }

        public Weapon WeaponConMenorPoder()
        {
            Weapon weapon = null;
            try
            {
                using (var context = new Context())
                {
                    var weapons = from wp in context.Weapons join wp1 in context.Weapons on
                                  wp.Power < wp1.Power
                                  select wp1;

                    weapon = weapons.First();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return weapon;
        }

        public Villain NombreAYAlMenos3Batallas()
        {
            Villain villain = null;
            try
            {
                using (var context = new Context())
                {
                    var villains = context.Villains.Any(x => x.Name[0].Equals("A") && x.NumberOfBatlles > 3);
                    villain = villains.First();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return villain;
        }
    }
}
