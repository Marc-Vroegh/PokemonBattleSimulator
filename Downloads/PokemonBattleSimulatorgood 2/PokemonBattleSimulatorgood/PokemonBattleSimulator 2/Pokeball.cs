using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleSimulator
{
    internal class Pokeball
    {
        public Pokemon pokemon
        { get; }

        private bool isFull;

        public Pokeball(Pokemon pokemon) 
        {
            this.pokemon = pokemon;
            // pokeball is full
        }

        public void Open(string nameTrainer)   
        {
            // pokeball is empty    
            Console.WriteLine("The pokeball is opened.");
            Console.WriteLine(pokemon.battleCry());
        }

        public void Close()
        {
            if(isFull == false) {
                Console.WriteLine("The pokeball is closed.");
            }
            // if there's a pokemon inside, then
                // pokeball is full
        }
    }
}
