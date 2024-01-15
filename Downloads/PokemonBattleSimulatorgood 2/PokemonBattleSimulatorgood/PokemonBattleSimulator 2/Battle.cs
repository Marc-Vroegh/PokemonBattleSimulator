using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleSimulator
{
    internal class Battle
    {
        public Battle(Pokeball pokemon, Pokeball pokemon2) 
        {
            this.pokemon = pokemon;
            this.pokemon2 = pokemon2;
        }

        public Pokeball pokemon
        { get; }
        public Pokeball pokemon2
        { get; }

        //private en readonly en scorebord in arena met static variables.

        public bool checkWinner(Pokeball pokemon, Pokeball pokemon2)
        {
            // get the strenght of the attacking pokemon
            // get the weakness of the defending pokemon

            // strength == weakness, then the attacking pokemon wins

            if (pokemon.pokemon.strength == pokemon2.pokemon.weakness) {
                return true;
            } else {
                return false;
            }
        }
    }
}
