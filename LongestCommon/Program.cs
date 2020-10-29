using System;

namespace LongestCommon
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string[] input = { "flower", "flow", "flight" };

            Console.WriteLine("The longest Common"
                                  + " Prefix is : "
                      + longestCommonPrefix(input));
            Console.ReadLine();
        }
        static string longestCommonPrefix(String[] a)
        {
            if (a.Length == 0)
                return " ";
            string prefix = a[0];
            for(int i=1; i< a.Length;i++)
            {
                while(a[i].IndexOf(prefix) !=0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    
                }
            }
            return prefix;
        }
    }
}
