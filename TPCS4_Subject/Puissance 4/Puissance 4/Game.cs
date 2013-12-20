using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Puissance_4
{
    static class Game
    {
        private static char to_draw(int player)
        {
            switch (player)
            {
                case 1:
                    return 'X';
                case 2:
                    return 'O';
                default:
                    return ' ';
            }
        }

        private static void draw_column_number(int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write("  {0} ", i);
            Console.Write("\n ");
            for (int i = 0; i < n - 1; i++)
                Console.Write("----");
            Console.Write("---");
            Console.Write("\n");
        }

        private static int ask_column(int player)
        {
            string answer;
            do
            {
                Console.WriteLine("Player {0} turn", player);
                Console.Write("Enter column number: ");
                answer = Console.ReadLine();
            }
            while (answer.Length != 1 || answer[0] < '0'
                    || answer[0] > '6');

            return answer[0] - '0';
        }

        private static void draw_game(int[][] game)
        {
            Console.Clear();
            draw_column_number(game.Length);
            for (int r = 0; r < game.Length; r++)
            {
                for (int c = 0; c < game.Length; c++)
                    Console.Write("| {0} ", to_draw(game[c][r]));
                Console.Write("|\n");

                for (int c = 0; c < game.Length; c++)
                    Console.Write("|---");
                Console.Write("|\n");
            }
        }

        private static bool replay()
        {
            string answer;
            do
            {
                Console.Write("Replay ? ");
                answer = Console.ReadLine();
            }
            while (answer.Length != 1 && answer[0] != 'y'
                    && answer[0] != 'n');

            return answer[0] == 'y';
        }

        private static bool is_draw()
        {
            Console.WriteLine("It's a draw !");
            return replay();
        }

        private static bool game_over(int player)
        {
            Console.WriteLine("Player {0} won !", player);
            return replay();
        }

        public static bool run()
        {
            int[][] game = null;
            FIXME.init_matrix(7, ref game);
            int player = 1;
            draw_game(game);
            do
            {
                int column;
                int row;
                do
                {
                    column = ask_column(player);
                    row = FIXME.insert_game(player, column, game);
                } while (row == -1);
                draw_game(game);
                if (FIXME.has_won(player, row, column, game))
                    return game_over(player);
                if (FIXME.is_full(game))
                    return is_draw();
                player = player == 1 ? 2 : 1;
            } while (true);
        }
    }
}
