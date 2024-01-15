using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleSimulator
{
    internal class Squirtle : Pokemon
    {
        public Squirtle(string name) : base(name, Values.water, Values.leaf) {}

        public override string battleCry()
        {
            return name + " yells 'Squirtle'!";
        }
    }
}