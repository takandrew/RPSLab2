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

        public string Encode(string text)
        {
            return text;
        }
        public string Decode(string text)
        {
            return text;
        }
    }
}
