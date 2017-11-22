using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Cricket();
            game.play();
            Console.WriteLine();

            game = new Football();
            game.play();

            Console.ReadKey();
        }
    }
}
