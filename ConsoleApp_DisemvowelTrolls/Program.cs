using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DisemvowelTrolls
{
    public static class Kata
    {
        public static string Disemvowel(string str)
        {
            return Regex.Replace(str, "[aeiou]", "", RegexOptions.IgnoreCase);
        }

        public static string Disemvowel2(string str)
        {
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };
            string source = str;
            foreach (var item in vowels)
            {
                while (source.IndexOf(item) > -1)
                {
                    int Place = source.IndexOf(item);
                    source = source.Remove(Place, 1);
                }
            }
            return source;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "This website is for losers LOL!";

            Console.WriteLine(Kata.Disemvowel(str1));
            Console.WriteLine(Kata.Disemvowel2(str1));

            Console.ReadLine();
        }
    }
}
