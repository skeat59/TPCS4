using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Puissance_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("How much column : ");
            string answer = Console.ReadLine();
            int nb;
            bool res = true;
            do
            {
                if (FIXME.is_only_digit(answer))
                {
                    nb = Convert.ToInt32(answer);
                    res = Game.run(nb);
                }
            }
            while (res);
        }
    }
}
