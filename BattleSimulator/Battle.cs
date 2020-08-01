using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace BattleSimulator
{
    class Battle
    {

        static void Main(string[] args)
        {

            CreateFighters cf=new CreateFighters();

            Monster Googleyboo = cf.CreateFighter("Googleyboo",500,150,250,200,"Slap","Punch");

            /*
            Console.WriteLine(Googleyboo.Name);
            Console.WriteLine(Googleyboo.Stats.Attack);
            Console.WriteLine(Googleyboo.Moves1.Damage);
            */

            Monster Figglytoad = cf.CreateFighter("Figglytoad",300,300,150,400,"Quick Hit","Double Strike");

            Console.WriteLine("Stop?");
            string readInput = Console.ReadLine();

            while(readInput.ToLower()!=("y"))
            {
                Console.WriteLine("Stop?");
                readInput = Console.ReadLine();
            }

            double hp1 = Googleyboo.Stats.Health;
            double hp2 = Figglytoad.Stats.Health;

            while(readInput=="Fight" && hp1>0 && hp2>0)
            {
                //string Player1 = (x=>x=(Googleyboo.Stats.Speed - Figglytoad.Stats.Speed));

                readInput = Console.ReadLine();
            }



        }
    }
}
