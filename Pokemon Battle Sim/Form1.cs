using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_Battle_Sim
{
    public partial class Form1 : Form
    {
        Pokemon[] PokemonList = new Pokemon[12];
        Attacks[] AttackList = new Attacks[48];
        bool AttackOneOn = false;
        bool PokemonOneOn = false;
        bool AttackTwoOn = false;
        bool PokemonTwoOn = false;
        int CurrentPokemoneONE = 1;
        int CurrentPokemonTWO = 7;

        public Form1()
        {
            InitializeComponent();
        }

        private void AttackOne_Click(object sender, EventArgs e)
        {
            AttackOneOn = !AttackOneOn;
            if (AttackOneOn == true)
            {
                ONEAttackOne.Enabled = true; ONEAttackOne.Visible = true;
                ONEAttackTwo.Enabled = true; ONEAttackTwo.Visible = true;
                ONEAttackThree.Enabled = true; ONEAttackThree.Visible = true;
                ONEAttackFour.Enabled = true; ONEAttackFour.Visible = true;
            }
            else 
            {
                ONEAttackOne.Enabled = false; ONEAttackOne.Visible = false;
                ONEAttackTwo.Enabled = false; ONEAttackTwo.Visible = false;
                ONEAttackThree.Enabled = false; ONEAttackThree.Visible = false;
                ONEAttackFour.Enabled = false; ONEAttackFour.Visible = false;
            }
        }

        private void PokemonOne_Click(object sender, EventArgs e)
        {
            //KANGASKHAN, DRAGONITE, BLAZEKIN, CHANSEY, FLYGON

            PokemonOneOn = !PokemonOneOn;
            if (PokemonOneOn == true)
            {
                Kangaskhan.Enabled = true; Kangaskhan.Visible = true;
                Dragonite.Enabled = true; Dragonite.Visible = true;
                Blazekin.Enabled = true; Blazekin.Visible = true;
                Chansey.Enabled = true; Chansey.Visible = true;
                Flygon.Enabled = true; Flygon.Visible = true;
            }
            else 
            {
                Kangaskhan.Enabled = false; Kangaskhan.Visible = false;
                Dragonite.Enabled = false; Dragonite.Visible = false;
                Blazekin.Enabled = false; Blazekin.Visible = false;
                Chansey.Enabled = false; Chansey.Visible = false;
                Flygon.Enabled = false; Flygon.Visible = false;
            }
        }
//\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
//
//
//
//\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void AttackTwo_Click(object sender, EventArgs e)
        {
            AttackTwoOn = !AttackTwoOn;

            if (AttackTwoOn == true)
            {
                TWOAttackOne.Enabled = true; TWOAttackOne.Visible = true;
                TWOAttackTwo.Enabled = true; TWOAttackTwo.Visible = true;
                TWOAttackThree.Enabled = true; TWOAttackThree.Visible = true;
                TWOAttackFour.Enabled = true; TWOAttackFour.Visible = true;
            }
            else
            {
                TWOAttackOne.Enabled = false; TWOAttackOne.Visible = false;
                TWOAttackTwo.Enabled = false; TWOAttackTwo.Visible = false;
                TWOAttackThree.Enabled = false; TWOAttackThree.Visible = false;
                TWOAttackFour.Enabled = false; TWOAttackFour.Visible = false;
            }
        }

        private void PokemonTwo_Click(object sender, EventArgs e)
        {
            //NINETAILS, ALAKAZAM, SLOWBRO, MUK, TOURUS
            PokemonTwoOn = !PokemonTwoOn;

            if (PokemonTwoOn == true)
            {
                Ninetails.Enabled = true; Ninetails.Visible = true;
                Alakazam.Enabled = true; Alakazam.Visible = true;
                Slowbro.Enabled = true; Slowbro.Visible = true;
                Muk.Enabled = true; Muk.Visible = true;
                Tourus.Enabled = true; Tourus.Visible = true;
            }
            else 
            {
                Ninetails.Enabled = false; Ninetails.Visible = false;
                Alakazam.Enabled = false; Alakazam.Visible = false;
                Slowbro.Enabled = false; Slowbro.Visible = false;
                Muk.Enabled = false; Muk.Visible = false;
                Tourus.Enabled = false; Tourus.Visible = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Healer attacks are 0 damage
            //Speed boost attacks are 1 damage
            //block attacks are 2 damage
            //heal and speed boost is 3 damage
            //poison attacks are 15 damage
            //fire attacks are 16 damage


            //ATTACK ARRAY
            AttackList[0] = new Attacks("FireBlast", 70);
            AttackList[1] = new Attacks("Snarl", 50);
            AttackList[2] = new Attacks("Intimidate", 2);
            AttackList[3] = new Attacks("Justify", 70);
            AttackList[4] = new Attacks("Bullet Punch", 60);
            AttackList[5] = new Attacks("Dynamic Punch", 50);
            AttackList[6] = new Attacks("Close Combat", 70);
            AttackList[7] = new Attacks("Steadfast", 0);
            AttackList[8] = new Attacks("FlashFire", 16);
            AttackList[9] = new Attacks("Drought", 80);
            AttackList[10] = new Attacks("EarlyBird", 40);
            AttackList[11] = new Attacks("Scrappy", 60);
            AttackList[12] = new Attacks("InnerFocus", 3);
            AttackList[13] = new Attacks("Synchronize", 40);
            AttackList[14] = new Attacks("MagicGuard", 2);
            AttackList[15] = new Attacks("Blaze", 16);
            AttackList[16] = new Attacks("SpeedBoost", 1);
            AttackList[17] = new Attacks("SereneGrace", 30);
            AttackList[18] = new Attacks("NaturalCure", 0);
            AttackList[19] = new Attacks("Healer", 0);
            AttackList[20] = new Attacks("Levitate", 60);
            AttackList[21] = new Attacks("Multiscale", 80);
            AttackList[22] = new Attacks("AngerPoint", 60);
            AttackList[23] = new Attacks("SheerForce", 70);
            AttackList[24] = new Attacks("Stench", 15);
            AttackList[25] = new Attacks("StickyHold", 50);
            AttackList[26] = new Attacks("PoisonTouch", 15);
            AttackList[27] = new Attacks("Obvious", 70);
            AttackList[28] = new Attacks("OwnTempo", 1);
            AttackList[29] = new Attacks("Regenerator", 0);

            // If a pokemon has no attacks:
            AttackList[30] = new Attacks("None", 4);



            //POKEMON ARRAY
            PokemonList[0] = new Pokemon("Alakazam", 85, "Alakazam", AttackList[13], AttackList[12], AttackList[14], AttackList[30]);
            PokemonList[1] = new Pokemon("Arcanine", 120, "Arcanine", AttackList[0], AttackList[1], AttackList[2], AttackList[3]);
            PokemonList[2] = new Pokemon("Blazekin", 115, "Blazekin", AttackList[16], AttackList[15], AttackList[30], AttackList[30]);
            PokemonList[3] = new Pokemon("Chansey", 250, "Chansey", AttackList[17], AttackList[18], AttackList[19], AttackList[30]);
            PokemonList[4] = new Pokemon("Dragonite", 120, "Dragonite", AttackList[12], AttackList[21], AttackList[30], AttackList[30]);
            PokemonList[5] = new Pokemon("Flygon", 100, "Flygon", AttackList[20], AttackList[30], AttackList[30], AttackList[30]);
            PokemonList[6] = new Pokemon("Kangaskhan", 135, "Kangaskhan", AttackList[10], AttackList[11], AttackList[12], AttackList[30]);
            PokemonList[7] = new Pokemon("Machamp", 105, "Machamp", AttackList[4], AttackList[5], AttackList[6], AttackList[7]);
            PokemonList[8] = new Pokemon("Muk", 130, "Muk", AttackList[24], AttackList[25], AttackList[26], AttackList[30]);
            PokemonList[9] = new Pokemon("Ninetails", 90, "Ninetails", AttackList[8], AttackList[9], AttackList[30], AttackList[30]);
            PokemonList[10] = new Pokemon("Slowbro", 125, "Slowbro", AttackList[27], AttackList[28], AttackList[29], AttackList[30]);
            PokemonList[11] = new Pokemon("Tourus", 95, "Tourus", AttackList[2], AttackList[22], AttackList[23], AttackList[30]);

        }


        //  ADD THE PICTURES OF THE POKEMON USING PROPERTIES.RESCOURCES
        private void Kangaskhan_Click(object sender, EventArgs e)
        {
            CurrentPokemonTWO = 6;
        }

        private void Dragonite_Click(object sender, EventArgs e)
        {
            CurrentPokemonTWO = 4;
        }

        private void Blazekin_Click(object sender, EventArgs e)
        {
            CurrentPokemonTWO = 2;
        }

        private void Chansey_Click(object sender, EventArgs e)
        {
            CurrentPokemonTWO = 3;
        }

        private void Flygon_Click(object sender, EventArgs e)
        {
            CurrentPokemonTWO = 5;
        }

        private void Arcanine_Click(object sender, EventArgs e)
        {
            CurrentPokemoneONE = 1;
        }

        ///////////////////////////////////////////////////////////////////////////

        private void Ninetails_Click(object sender, EventArgs e)
        {
            CurrentPokemoneONE = 9;
        }

        private void Alakazam_Click(object sender, EventArgs e)
        {
            CurrentPokemoneONE = 0;
        }

        private void Slowbro_Click(object sender, EventArgs e)
        {
            CurrentPokemoneONE = 10;
        }

        private void Muk_Click(object sender, EventArgs e)
        {
            CurrentPokemoneONE = 8;
        }

        private void Tourus_Click(object sender, EventArgs e)
        {
            CurrentPokemoneONE = 11;
        }
        private void Machamp_Click(object sender, EventArgs e)
        {
            CurrentPokemoneONE = 7;

        }
    }
}
