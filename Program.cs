using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBASH_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {



            (string, int) MessageDangerLevel(string message)

            {
                List<string> dangerous_words = new List<string> { "bomb", "nukhba", "fighter", "rocket", "secret" };

                List<string> words_found = new List<string> { };


                int points = 0;


                string[] message_words = message.Split(' ');

                foreach (string word in message_words)
                {
                    string clean_word = word.ToLower().Trim(',', '.', '!', '?', ':', ';');

                    if (dangerous_words.Contains(clean_word))
                    {
                        points += 1;
                        words_found.Add(clean_word);
                    }
                }


                return (message, points);
            }






            char Decoder(char c)
            {

                int temp = c - 'a';
                temp = 'z' - temp;
                return (char)temp;


            }
            string Decryption_of_a_string_cipher(string message)
            {
                message = message.ToLower();

                string result = "";

                for (int i = 0; i < message.Length; i++)
                {
                    char currentChar = message[i];

                    if (currentChar >= 'a' && currentChar <= 'z')
                        result += Decoder(currentChar);
                    else
                        result += currentChar;
                }

                return result;

            }

            void PrintUserData((string message, int points) message_and_points)
            {
     
                    if (message_and_points.points >= 1 && message_and_points.points <= 5)
                {
                    Console.WriteLine(message_and_points.message + "\nWARNING!\nand points is " + message_and_points.points);
                }
                else if (message_and_points.points >= 6 && message_and_points.points <= 10)
                {
                    Console.WriteLine(message_and_points.message + "\nDANGER!\nand points is " + message_and_points.points);
                }
                else if (message_and_points.points >= 11 && message_and_points.points <= 15)
                {
                    Console.WriteLine(message_and_points.message + "\nULTRA ALERT!\nand points is " + message_and_points.points);
                }

            }
            string NewMessage = "Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb.\r\nGsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo.\r\nYlnyh szev yvvm kozxvw mvzi pvb olxzgrlmh.\r\nMfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm.\r\nGsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt.\r\nDv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg.\r\nErxglib rh mvzi. Hgzb ivzwb.";
             string decryptedMessage = Decryption_of_a_string_cipher(NewMessage);
            var Tmessage_and_points = MessageDangerLevel(decryptedMessage);
            PrintUserData(Tmessage_and_points);
            Console.ReadLine();

        }
    }
}
