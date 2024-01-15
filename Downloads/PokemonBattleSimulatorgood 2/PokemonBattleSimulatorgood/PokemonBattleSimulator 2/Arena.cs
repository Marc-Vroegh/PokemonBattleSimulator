using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleSimulator
{
    internal class Arena
    {
        private string? name1
        { get; set; }
        private int numberRound
        { get; set; }
        public int round
        { get; set; }
        public static int AshNew
        { get; set; }
        public static int GaryNew
        { get; set; }
        private int? True
        { get; set; }
        private string? name2
        { get; set; }
        //public static string? name1;
        
    // What's the difference between static and instance variables?

        public void AddToBattle (Pokeball pokeball, Pokeball pokeball2) {
            True = 0;
            Battle battle = new Battle(pokeball, pokeball2);
            if(battle.checkWinner(battle.pokemon, battle.pokemon2) == true) {
               name1 = pokeball.pokemon.name;
               name2 = Program.firstTrainer;
               True = 1;
               GaryNew++;
            } else {
               if(battle.checkWinner(battle.pokemon2, battle.pokemon) == true) {
                    name1 = pokeball2.pokemon.name;
                    name2 = Program.secondTrainer;
                    True = 1;
                    AshNew++;
                } 
            }
        }
        public string won() 
        {
            if (True == 1) {
                return name1 + " has won, good job " + name2;
            } else {
                GaryNew++; 
                AshNew++;
                return "Beide trainers hebben gewonnen";
            }
        }

        public string returnRound() 
        {
            numberRound = round + 1;
            return "round " + numberRound;
        }  

        public string returnWon() 
        {
            return "Tussenstand: " + GaryNew  + " voor " + Program.firstTrainer + " en " + AshNew + " voor " + Program.secondTrainer;
        }
    }
}
