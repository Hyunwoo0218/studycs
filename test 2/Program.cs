using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace test_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Monster monster1 = new Monster();

            player.ADDAT(10);

            player.Fight(monster1.at);
            Console.WriteLine(monster1.at);
            Console.WriteLine(player.at);
            Console.ReadLine();

         
        }
    }
}