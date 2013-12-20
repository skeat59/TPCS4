using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPCS4
{
    static class Ex1 //string manipulations
    {
        static public void Exercice()
        {
            Console.WriteLine("\n--------------Exercice1-----------------\n");
            Console.Write("Enter your string : ");
            string str = Console.ReadLine();
            char[][] words = split_string(str);
            for (int i = 0; i < words.Length; i++)
                print_array(ref words[i]);
        }

        static void print_array(ref char[] tab)
        {
            Console.Write('(');
            for (int i = 0; i < tab.Length; i++)
                Console.Write("{0}", tab[i]);
            Console.Write(") ");
        }

        /**
        ** Returns a char array containing length element of str, starting
        ** from the start index.
        ** This index must be updated to the index following the last element
        ** copied.
        ** If it's asked to copy more element than str contains, as many
        ** elements as possible are copied.
        */
        public static char[] my_substring(string str, ref int start, int length)
        {
            char[] res = new char[length];
            int i = 0;
            if (start >= 0)
            {
                while (i < length)
                {
                    res[i] = str[start + i];
                    i++;
                }
            }
            start = start + i + 1;
            return res;


        }

        /**
        ** Returns the next word starting at start of str as a char array.
        ** Words are defined as letters seperated by a space.
        ** Update start to the next space.
        ** Handling multi spaces, only spaces or things like that is not
        ** mandatory but will be appreciated.
        */
        public static char[] get_word(string str, ref int start)
        {
            while (str[start] == ' ') start++;
            int j = 0;
            while (str[j] != ' ') j++;
            return my_substring(str, ref start, j);

        }

        /**
        ** Count the number of words str contains.
        */
        static int count_words(string str)
        {
            int res = 0;
            if (str != "")
            {
                res++;
            }
            for (int i = 1; i < str.Length; i++)
            {
                if ((str[i] == ' ') && (str[i - 1] != ' '))
                {
                    res++;
                }

            }
            return res;
        }

        /**
        ** Return an array containing the words of str as char arrays.
        */
        static char[][] split_string(string text)
        {
            int nb_case = count_words(text);
            int deb = 0;
            char[][] res = new char[nb_case][];
            for (int i = 0; i < nb_case; i++)
            {
                res[i] = get_word(text, ref deb);
            }
            return res;
        }
    }
}
