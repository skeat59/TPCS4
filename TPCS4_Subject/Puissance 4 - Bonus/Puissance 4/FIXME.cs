using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Puissance_4
{
    static class FIXME
    {
        /*
        ** Gives to 'array' a new array of size 'n'
        ** and initializes each of its field to 0
        */
        private static void init_array(int n, ref int[] array)
        {
            /* FIXME */
        }

        /*
        ** Gives to 'matrix' a new square matrix of size 'n'
        ** Each of the field is then initializes to 0
        ** You can use the previous function...
        */
        public static void init_matrix(int n, ref int[][] matrix)
        {
            /* FIXME */
        }

        /*
        ** Inserts the token of value 'player' in the array
        ** The insertion is done with the 'Puissance 4' style
        **      - If the column is already full the function return -1
        **      - The insertion is done juste before the first token 
        **        (i.e. non zero element) encountered or at the end of the 
        **        array if this one is empty
        **      - If all went as expected, the index of the insertion is returned
        */
        private static int insert_column(int player, int[] column)
        {
            /* FIXME */
            return  0;
            /* FIXME */
        }

        /*
        ** Inserts the token 'player' in the matrix at the given column
        ** The insertion is done with the 'Puissance 4' style.
        **      - -1 is return if the column is full
        **      - the row of the insertion index is returned otherwise
        ** It would be wise to use your previous function (just saying...)
        */
        public static int insert_game(int player, int column, int[][] matrix)
        {
            /* FIXME */
            return 0;
            /* FIXME */
        }

        /*
        ** Checks if the last added token in game[column][row] now forms
        ** a row of 4.
        ** Don't hesitate to count on the left  and on the right separetly...
        */
        private static bool validate_row(int player, int row, int column, int[][] game, int nb)
        {
            /* FIXME */
            return false;
            /* FIXME */
        }

        /*
        ** Checks if the last added token in game[column][row] now forms
        ** a column of 4
        ** Don't hesitate to count to the top and to the bottom separetly...
        */
        private static bool validate_column(int player, int row, int column, int[][] game, int nb)
        {
            /* FIXME */
            return false;
            /* FIXME */
        }
        
        /* Check if the last token added in game[column][row] now forms
        ** a diagonal of 4
        ** Take care, there is 2 diagonal, so 4 sides to explore.
        */
        private static bool validate_diagonal(int player, int row, int column, int[][] game, int nb)
        {
            /* FIXME */
            return false;
            /* FIXME */
        }

        /*
        ** Checks if the last token added by player in game[column][row]
        ** made him win
        */
        public static bool has_won(int player, int row, int column, int[][] game, int nb)
        {
            /* FIXME */
            return false;
            /* FIXME */
        }

        /*
        ** Checks if the game is full
        */
        public static bool is_full(int[][] game)
        {
            /* FIXME */
            return false;
            /* FIXME */
        }

        /*
        ** Check if the string is only compose of numbers
        */
        public static bool is_only_digit(string str)
        {
            /* FIXME */
            return false;
            /* FIXME */
        }

        /*
        ** Ask the user for the column where to place the token.
        ** This function was in the Game class in the mandatory, have a look
        ** to know what to do.
        ** Please note that to convert a string to an int, you can use
        ** Convert.ToInt32
        */
        public static int ask_column(int player, int nb)
        {
            /* FIXME */
            return 0;
            /* FIXME */
        }
    }
}
