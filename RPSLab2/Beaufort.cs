using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLab2
{
    class Beaufort: ICipher
    {
        const string engAlphabet = @"abcdefghijklmnopqrstuvwxyz";
        const string rusAlphabet = @"абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        private bool IsLatin(char letter)
        {
            short minusOne = -1;
            if (engAlphabet.IndexOf(char.ToLower(letter)) == minusOne)
                return false;
            return true;
        }
        public string Encode(string text, string key)
        {
            for (int i = key.Length, j = 0; i < text.Length; i++, j++) 
            {
                key += key[((i + j) % key.Length)]; 
            }
            var letters = text.ToCharArray();
            for (var i = 0; i < letters.Length; i++)
                if (char.IsLetter(letters[i]))
                {
                    var isLowerCase = char.IsLower(letters[i]);
                    if (IsLatin(letters[i]))
                        letters[i] = engAlphabet[(((engAlphabet.Length + engAlphabet.IndexOf(key[i]) -
                    engAlphabet.IndexOf(text[i])) % engAlphabet.Length))];
                    else
                        letters[i] = rusAlphabet[(((rusAlphabet.Length + rusAlphabet.IndexOf(key[i]) -
                    rusAlphabet.IndexOf(text[i])) % rusAlphabet.Length))];
                    if (!isLowerCase)
                        letters[i] = char.ToUpper(letters[i]);
                }

            return string.Join("", letters);
        }
        public string Decode(string text, string key)
        {
            
            return text;
        }
    }
}
