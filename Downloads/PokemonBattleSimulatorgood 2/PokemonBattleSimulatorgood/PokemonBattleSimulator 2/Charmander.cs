using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleSimulator
{
    internal class Charmander : Pokemon
    {
        public Charmander(string name) : base(name, Values.fire, Values.water) {}

        public override string battleCry()
        {
            return name + " yells 'Charmander'!";
        }
    }
}