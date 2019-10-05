using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Sim
{
    class Attacks
    {
        string name; int dam;
        public Attacks(string Name, int Damage)
        {
            name = Name;
            dam = Damage;
        }

        public string GetName()
        {
            return name;
        }
        public int GetDamage()
        {
            return dam;
        }
    }
}
