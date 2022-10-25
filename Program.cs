using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_interview_questions_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "The Quick Brown Fox";
            ReverseString(str);
            ReverseSentance(str);
            ReverseWords(str);
            CountCharactors("Hello World Good Morning");
            RemoveDuplicates("HelloWorld");
            AllSubstring("ABCD");
        }

        //01. How to Reverse string
        public static void ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();

            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reverseString = new string(charArray);
            Console.WriteLine("{0} ==> {1}", str,reverseString);
        }

        //02.Reverse the order of words in given string

        public static void ReverseSentance(string str)
        {
            string[] stringArray = str.Split(' ');
            string reverse = string.Empty;

            for (int i = stringArray.Length - 1; i >= 0; i--)
            {
                if (i == stringArray.Length - 1)
                {
                    reverse = stringArray[i];
                }
                else
                {
                    reverse = reverse + ' ' + stringArray[i];
                }

            }
            Console.WriteLine("{0} ==> {1}", str,reverse);
        }

        //03.reverse each word in a given string

        public static void ReverseWords(string str)
        {
            string[] strArray = str.Split(' ');
            string finalString = string.Empty;

            for (int k = 0; k < strArray.Length - 1; k++)
            {
                char[] charArray = strArray[k].ToCharArray();
                for (int i = 0, j = strArray[k].Length - 1; i < j; i++, j--)
                {
                    charArray[i] = strArray[k][j];
                    charArray[j] = strArray[k][i];
                }
                if (k != 0)
                {
                    finalString = finalString + ' ' + new string(charArray);
                }
                else
                {
                    finalString = new string(charArray);
                }

            }
            Console.WriteLine("{0} ==> {1}",str,finalString);

        }

        //04.count the occurrence of each character in a string

        public static void CountCharactors(string str)
        {
            var charactorCount = new Dictionary<char, int>();

            foreach (var charactor in str)
            {
                if (charactor != ' ')
                {
                    if (!charactorCount.ContainsKey(charactor))
                    {
                        charactorCount.Add(charactor, 1);
                    }
                    else
                    {
                        charactorCount[charactor]++;
                    }
                }
            }

            foreach (var charactor in charactorCount)
            {
                Console.WriteLine("{0} - {1}", charactor.Key, charactor.Value);
            }

        }

        //05.Remove dupilcate charactors from string 

        public static void RemoveDuplicates(string str)
        {
            string result = string.Empty;

            for (int i = 0; i < str.Length -1; i++)
            {
                if(!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }
            Console.WriteLine("{0} ==> {1}", str, result);
        }

        //06.All possible substring of a given string

        public static void AllSubstring(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                var subString = new StringBuilder(str.Length - 1);

                for (int j = i; j <str.Length -1; j++)
                {
                    subString.Append(str[j]);
                    Console.WriteLine("{0}", subString);
                }
            }
        }
    }
}
