using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleSimulator
{
    internal abstract class Pokemon
    {
        public enum Values
        {
            grass,
            fire,
            water,
            leaf
        }
        public string name
        { get; }

        public Values strength
        { get; }

        public Values weakness
        { get; }

        protected Pokemon(string name, Values strength, Values weakness)
        {
            this.name = name;
            this.strength = strength;
            this.weakness = weakness;
        }
        public abstract string battleCry();
    }

    //public Charmander : Pokeball {

   // }

}