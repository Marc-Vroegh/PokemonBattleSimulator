using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleSimulator
{
    internal class Trainer
    {
        private string name { get; }
        private List<Pokeball> belt
        { get; }

        public Trainer(string name, List<Pokeball> belt)
        {
            this.name = name;
            this.belt = belt;
        }

        public void throwPokeball(int number)
        {
            Console.WriteLine(name + " has thrown a pokeball.");
            belt[number].Open(name);
        }

        public void returnPokemon(int number)
        {
            Console.WriteLine(name + " has returned a pokemon.");
            belt[number].Close();
        }
    }
}
