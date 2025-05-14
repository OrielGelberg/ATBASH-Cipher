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
            char Decoder(char c)
            {
                
                    int temp = c - 'a';          // כמה צעדים מ-a
                    temp = 'z' - temp;           // הפוך את הספירה
                    return (char)temp;           // המר בחזרה ל-char
                

            }
            string Decryption_of_a_string_cipher(string message)
             {
                message = message.ToLower();
                //string newGoodMessage = "";
                // char currentChar;

                //StringBuilder decryptedMessage = new StringBuilder();
                string result = "";

                for (int i = 0; i < message.Length; i++)
                {
                    char currentChar = message[i];

                    if (currentChar >= 'a' && currentChar <= 'z')
                        result += Decoder(currentChar); // תו מוצפן
                    else
                        result += currentChar;          // תווים שלא מצפינים (למשל רווחים)
                }

                return result;

            }
            string NewMessage = "Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb.\r\nGsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo.\r\nYlnyh szev yvvm kozxvw mvzi pvb olxzgrlmh.\r\nMfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm.\r\nGsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt.\r\nDv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg.\r\nErxglib rh mvzi. Hgzb ivzwb.";
             string decryptedMessage = Decryption_of_a_string_cipher(NewMessage);
             Console.WriteLine("Decrypted message: " + decryptedMessage);
            Console.ReadLine();
        }
    }
}
