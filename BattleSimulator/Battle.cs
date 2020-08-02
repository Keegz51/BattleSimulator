using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace BattleSimulator
{
    class Battle
    {
        static Monster Googleyboo = new CreateFighters().CreateFighter("Googleyboo", 500, 150, 250, 200, "Slap", "Punch");
        static Monster Figglytoad = new CreateFighters().CreateFighter("Figglytoad", 300, 300, 150, 400, "Quick Hit", "Double Strike");


        static void Main(string[] args)
        {
            Console.WriteLine("Stop?");
            string readInput = Console.ReadLine();

            double hp1 = Googleyboo.Stats.Health;
            double hp2 = Figglytoad.Stats.Health;
            Monster player1 = FindPlayer1(Googleyboo, Figglytoad);
            Monster player2 = FindPlayer2(Googleyboo, Figglytoad);

            while (readInput=="Fight" && (player1.Stats.Health > 0 ) && (player2.Stats.Health > 0))
            {
                //string Player1 = (x=>x=(Googleyboo.Stats.Speed - Figglytoad.Stats.Speed));

                Console.WriteLine("\n"+player1.Name +" is Player 1, Select attack :");
                Console.WriteLine("1. "+player1.Moves1.Name+player1.Moves1.Damage.ToString().PadLeft(10)+"\n2. "+player1.Moves2.Name+ player1.Moves2.Damage.ToString().PadLeft(10));
                
                //Give user List to select from and then switch on the selection (1. Slap, 2. Smack , then pass moves damage into the Attack method)
                string readAttack = Console.ReadLine();

                switch(readAttack)
                {
                    case "1":
                        player2.Stats.Health = Attack(player1, player2,player1.Moves1.Damage, player2.Stats.Health);
                        break;

                    case "2":
                        player2.Stats.Health = Attack(player1, player2,player1.Moves2.Damage, player2.Stats.Health);
                        break;
                }

                Console.WriteLine(player2.Stats.Health);

                readInput = Console.ReadLine();

            }

        }

        private static double Attack(Monster player1, Monster player2,double damage , double health)
        {
            double damageDealth = (damage * (player1.Stats.Attack / 100) - player2.Stats.Defence / 2);

            if (damageDealth<0)
            {
                damageDealth = 1;
            }
            
            double  resultHealth = health - damageDealth;


            return resultHealth;
        }

        public static Monster FindPlayer1(Monster m1, Monster m2)
        {
            Monster monster = new Monster();

            if (m1.Stats.Speed > m2.Stats.Speed)
            {
                monster = m1;
            }
            else if (m2.Stats.Speed > m1.Stats.Speed)
            {
                monster = m2;
            }
            else
            {
                Random rand = new Random();
                int random = rand.Next(1, 2);

                if (random == 1)
                {
                    monster = m1;
                }
                else
                {
                    monster = m2;
                }
            }

            return monster;
        }

        public static Monster FindPlayer2(Monster m1, Monster m2)
        {
            Monster monster = new Monster();

            if (m1.Stats.Speed < m2.Stats.Speed)
            {
                monster = m1;
            }
            else if (m2.Stats.Speed < m1.Stats.Speed)
            {
                monster = m2;
            }
            else
            {
                Random rand = new Random();
                int random = rand.Next(1, 2);

                if (random == 1)
                {
                    monster = m1;
                }
                else
                {
                    monster = m2;
                }
            }

            return monster;
        }
    }

}
