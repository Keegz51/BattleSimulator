using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulator
{
    class CreateFighters
    {


        static Dictionary<string, double> moveList = new Dictionary<string, double>
        {
            { "Slap",10},
            {"Punch",50},
            {"Quick Hit",30},
            {"Double Strike",100}
        };


        public Monster CreateFighter(string Name,double Health,double Attack, double Defence, double Speed, string moveName1,string moveName2)
        {
            Monster monster = new Monster()
            {

                Name = Name,
                Stats = new Stats
                {
                    Health = Health,
                    Attack = Attack,
                    Defence = Defence,
                    Speed = Speed
                },

                Moves1 = new Moves
                {
                    Name = moveName1,
                    Damage = moveList[moveName1]
                },

                Moves2 = new Moves
                {
                    Name = moveName2,
                    Damage = moveList[moveName2]
                }


            };

            return monster;
        }

    }
}
