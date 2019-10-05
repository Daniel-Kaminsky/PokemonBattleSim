using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Sim
{
    class Pokemon
    {
         string name; int hitPoints; int maxHitPonts; string imagePath; Attacks attackONE; Attacks attackTWO; Attacks attackTHREE; Attacks attackFOUR;
        public Pokemon(string Names, int HP, string Image, Attacks Attack1, Attacks Attack2, Attacks Attack3, Attacks Attack4)
        {
            hitPoints = HP;
            maxHitPonts = HP;
            name = Names;
            imagePath = Image;
            attackONE = Attack1;
            attackTWO = Attack2;
            attackTHREE = Attack3;
            attackFOUR = Attack4;
            //////////////////////////////////////////////

        }


        public string GetNames()
        {
            return name;
        }
        public int GetHP()
        {
            return hitPoints;
        }
        public int GetMaxHP()
        {
            return maxHitPonts;
        }
        public string GetImage()
        {
            return imagePath;
        }
        public Attacks GetAttack1()
        {
            return attackONE;
        }
        public Attacks GetAttack2()
        {
            return attackTWO;
        }
        public Attacks GetAttack3()
        {
            return attackTHREE;
        }
        public Attacks GetAttack4()
        {
            return attackFOUR;
        }
    }
}
