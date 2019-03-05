using System;
using System.Linq;

namespace SearchString
{
    public class StringUtilities
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int CountOccurences(string stringToCheck, string stringToFind)
        {
            int count = -1;

            if (stringToCheck !=null)
            {
                count = stringToCheck.Count(x => Char.ToUpperInvariant(stringToFind[0]) == Char.ToUpperInvariant(x));
            }
            return count;
            //int i = 0;
            //while ((i = stringToCheck.IndexOf(stringToFind, i)) != -1)
            //{
            //    i += stringToFind.Length;
            //    count++;
            //}
            //return count;
        }
    }
}
