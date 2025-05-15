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



            string MessageDangerLevel(string message)
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


                return $"words_found: {string.Join(",", words_found)}\npoints: {points}";
            }



            Console.WriteLine(MessageDangerLevel("In a secret secret operation, the elite Nukhba fighter unit intercepted a rocket armed with a bomb, thwarting a catastrophic attack."));


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
            string NewMessage = "Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb.\r\nGsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo.\r\nYlnyh szev yvvm kozxvw mvzi pvb olxzgrlmh.\r\nMfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm.\r\nGsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt.\r\nDv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg.\r\nErxglib rh mvzi. Hgzb ivzwb.";
             string decryptedMessage = Decryption_of_a_string_cipher(NewMessage);
             
            Console.ReadLine();

        }
    }
}
