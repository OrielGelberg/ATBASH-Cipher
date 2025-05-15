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


            (string,int) MessageDangerLevel(string message)
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


                return (message,points);
            }


            var message_and_points = MessageDangerLevel(decryptedMessage);



        }
    }
}
