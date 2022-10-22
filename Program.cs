using System;
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
            Console.WriteLine(str + " ==> " + reverseString);
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
            Console.WriteLine(str + " ==> " + reverse);
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
            Console.WriteLine(str + " ==> " + finalString);

        }
    }
}
