using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            var dragonHealth=100;
            var playerDamage=random.Next(0,101);
            var dragonKill = 0;
            Boolean playing = true;
            Boolean fighting = false;
            var take=0;
            var kill=0;
            var escape = 0;

            while (playing)
            {
                hide = false;
                Console.WriteLine("Enter a name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter a gender");
                string gender = Console.WriteLine();
                Console.WriteLine("Your family is stopped on the side of the road by a group of orcs. What will you do?");
                Console.WriteLine("Run, Hide, or Fight");
                string ansQ1 = Console.ReadLine();
                if (ansQ1 == "run")
                {
                    Console.WriteLine("As you make a wimpy escape the orc cheiften spots you. He shoots you with a bow and you slowly bleed to death.");
                   
                }
                if (ansQ1 == "Hide")
                {
                    Console.WriteLine("As you hide under the seat in the wagon you watch through a crack as your elven parents and siblings are brutally murdered by the orcs.");
                    hide = true;
                }
                if (ansQ1 == "Fight")
                {
                    Console.WriteLine("You charge into the hoard of orcs with your family hopping that you can survive this encounter.");
                }
                if (hide == true)
                {
                    Console.WriteLine("After watching the orcs leave you get out of your hiding spot. What will you do?");
                }
            }
            Console.ReadKey();
        }
    }
}
