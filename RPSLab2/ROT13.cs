using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLab2
{
    public class ROT13: ICipher
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
            var letters = text.ToCharArray();
            for (var i = 0; i < letters.Length; i++)
                if (char.IsLetter(letters[i]))
                {
                    var isLowerCase = char.IsLower(letters[i]);
                    if (IsLatin(letters[i]))
                        letters[i] = engAlphabet[(engAlphabet.IndexOf(char.ToLower(letters[i])) + 13) % engAlphabet.Length];
                    else
                        letters[i] = rusAlphabet[(rusAlphabet.IndexOf(char.ToLower(letters[i])) + 13) % rusAlphabet.Length];
                    if (!isLowerCase)
                        letters[i] = char.ToUpper(letters[i]);
                }

            return string.Join("", letters);
        }

        public string Decode(string text, string key)
        {
            var letters = text.ToCharArray();
            for (var i = 0; i < letters.Length; i++)
                if (char.IsLetter(letters[i]))
                {
                    var isLowerCase = char.IsLower(letters[i]);
                    if (IsLatin(letters[i]))
                        letters[i] = engAlphabet[(engAlphabet.Length + engAlphabet.IndexOf(char.ToLower(letters[i])) - 13) % engAlphabet.Length];
                    else
                        letters[i] = rusAlphabet[(rusAlphabet.Length + rusAlphabet.IndexOf(char.ToLower(letters[i])) - 13) % rusAlphabet.Length];
                    if (!isLowerCase)
                        letters[i] = char.ToUpper(letters[i]);
                }

            return string.Join("", letters);
        }
    }
}
