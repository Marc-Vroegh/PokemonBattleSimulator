using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace PokemonBattleSimulator
{
    internal class Bulbasaur : Pokemon
    {
        public Bulbasaur(string name) : base(name, Values.grass, Values.fire) {}

        public override string battleCry()
        {
            return name + " yells 'Bulbasaur'!";
        }
    }
}