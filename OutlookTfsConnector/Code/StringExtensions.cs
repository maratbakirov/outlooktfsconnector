using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookTfsConnector
{
    public static class StringExtensions
    {
        static HashSet<char> invalidCharsSet = new HashSet<char>();
        static StringExtensions(){
            foreach (char c in System.IO.Path.GetInvalidFileNameChars())
            {
                invalidCharsSet.Add(c);
            }
            foreach (char c in System.IO.Path.GetInvalidPathChars())
            {
                invalidCharsSet.Add(c);
            }
            invalidCharsSet.Add(' ');
        }



        /// <summary>
        ///     Returns a string array that contains the substrings in this instance that are delimited by specified indexes.
        /// </summary>
        /// <param name="source">The original string.</param>
        /// <param name="index">An index that delimits the substrings in this string.</param>
        /// <returns>An array whose elements contain the substrings in this instance that are delimited by one or more indexes.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="index" /> is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">An <paramref name="index" /> is less than zero or greater than the length of this instance.</exception>
        public static string[] SplitAt(this string source, params int[] index)
        {
            index = index.Distinct().OrderBy(x => x).ToArray();
            string[] output = new string[index.Length + 1];
            int pos = 0;

            for (int i = 0; i < index.Length; pos = index[i++])
                output[i] = source.Substring(pos, index[i] - pos);

            output[index.Length] = source.Substring(pos);
            return output;
        }


        public static string GetFileName(this string source)
        {
            if (source == null)
            {
                return "";
            }
            StringBuilder result = new StringBuilder();
            foreach(char c in source.ToCharArray())
            {
                if (invalidCharsSet.Contains(c))
                {
                    result.Append('_');
                }    
                else
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }
    }
}
