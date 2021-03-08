using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLab2
{
    public class Beaufort: ICipher
    {
        const string engAlphabet = @"ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string rusAlphabet = @"АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private bool IsLatin(char letter)
        {
            short minusOne = -1;
            if (engAlphabet.IndexOf(char.ToUpper(letter)) == minusOne)
                return false;
            return true;
        }
        public string Encode(string text, string key)
        {
            for (int i = key.Length, j = 0; i < text.Length; i++, j++)
                key += key[((i + j) % key.Length)];
            var keyUP = key.ToCharArray();
            for (int i = 0; i < keyUP.Length; i++)
                keyUP[i] = char.ToUpper(keyUP[i]);
            var letters = text.ToCharArray();
            for (var i = 0; i < letters.Length; i++)
                if (char.IsLetter(letters[i]))
                {
                    var isLowerCase = char.IsLower(letters[i]);
                    if (isLowerCase)
                        letters[i] = char.ToUpper(letters[i]);
                    if (IsLatin(letters[i]))
                        letters[i] = engAlphabet[(engAlphabet.Length + engAlphabet.IndexOf(keyUP[i]) -
                    engAlphabet.IndexOf(letters[i])) % engAlphabet.Length];
                    else
                        letters[i] = rusAlphabet[(rusAlphabet.Length + rusAlphabet.IndexOf(keyUP[i]) -
                    rusAlphabet.IndexOf(letters[i])) % rusAlphabet.Length];
                    if (isLowerCase)
                        letters[i] = char.ToLower(letters[i]);
                }

            return string.Join("", letters);
        }
        public string Decode(string text, string key)
        {
            text = Encode(text, key);
            return text;
        }
    }
}
