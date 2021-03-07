using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLab2
{
    interface ICipher
    {
        string Encode(string text);
        string Decode(string text);
    }
}
