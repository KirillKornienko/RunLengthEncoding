using System;
using System.Text.RegularExpressions;

namespace RunLengthEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string text = "AAAABBBCCXYZDDDDEEEFFFAAAAAABBBBBBBBBBBBBBBBBBBBBBBBBBBB";

                Console.WriteLine(StartEncoding(text));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //Run-Lenght Encoding
        public static string StartEncoding(string text)
        {
            if (!Regex.IsMatch(text, @"^[A-Z]+$"))
                throw new Exception("Start text contains an invalid symbol");

            int num = 1;
            text += " ";
            string encoding_string = string.Empty;

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] == text[i + 1])
                {
                    num++;
                }
                else
                {
                    encoding_string += text[i];

                    if (num != 1)
                        encoding_string += num;

                    num = 1;
                }
            }

            return encoding_string;
        }

    }
    /*
     * Реализация в виде отдельного класса
    class RLE
    {
        string start_string;
        string encoding_string;

        public RLE(string text)
        {
            if (Regex.IsMatch(text, @"^[A-Z]+$"))
                start_string = text;
            else
                throw new Exception("Start text contains an invalid symbol");
        }

        public void StartEncoding()
        {
            int num = 1;
            start_string = start_string + " ";
            encoding_string = string.Empty;

            for (int i = 0; i < start_string.Length - 1; i++)
            {
                if (start_string[i] == start_string[i + 1])
                {
                    num++;
                }
                else
                {
                    encoding_string += start_string[i];

                    if (num != 1)
                        encoding_string += num;

                    num = 1;
                }
            }
        }

        public string ReadEncoding()
        {
            return encoding_string;
        }
    }
    */
}